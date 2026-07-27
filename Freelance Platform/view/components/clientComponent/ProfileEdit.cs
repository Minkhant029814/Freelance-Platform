using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace Freelance_Platform.view.components.clientComponent
{
    public partial class ProfileEdit : UserControl
    {
        private readonly ClientService clientService;
        private string selectedFilePath = null;
        private Client client;

        public ProfileEdit()
        {
            InitializeComponent();
            clientService = new ClientService();
            int clientId;
            if (int.TryParse(UserSession.ClientId.ToString(), out clientId))
            {
                client = clientService.GetClientDetails(clientId);
            }
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            btnSaveChanges.Image = IconChar.Save.ToBitmap(color: Color.White, 30);
            if (client != null)
            {
                PopulateForm(client);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine profile picture name (upload if a new file was selected)
            string profileName = client?.ProfilePic;
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                int userId;
                if (!int.TryParse(UserSession.UserId.ToString(), out userId))
                {
                    MessageBox.Show("Invalid user session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var uploaded = HandleImageUpload(userId, selectedFilePath);
                if (uploaded == null)
                {
                    // Upload failed (message shown inside method); abort update
                    return;
                }
                profileName = uploaded;
            }

            var updatedClient = new Client(username: txtName.Text, password: "", type: client?.Type ?? string.Empty)
            {
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                ProfilePic = profileName
            };

            int userIdForUpdate;
            if (!int.TryParse(UserSession.UserId.ToString(), out userIdForUpdate))
            {
                MessageBox.Show("Invalid user session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = clientService.UpdateProfile(updatedClient, userIdForUpdate);

            if (success)
            {
                // Refresh client data (ClientId stays the same)
                int clientId;
                if (int.TryParse(UserSession.ClientId.ToString(), out clientId))
                {
                    client = clientService.GetClientDetails(clientId);
                    if (client != null) PopulateForm(client);
                }

                MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateForm(Client c)
        {
            if (c == null) return;

            txtName.Text = c.Username ?? string.Empty;
            txtEmail.Text = c.Email ?? string.Empty;
            txtPhone.Text = c.Phone ?? string.Empty;
            txtAddress.Text = c.Address ?? string.Empty;

            // Load profile picture safely and avoid locking the file
            if (!string.IsNullOrEmpty(c.ProfilePic))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", c.ProfilePic);

                if (File.Exists(imgPath))
                {
                    try
                    {
                        using (var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                        {
                            using (var img = Image.FromStream(fs))
                            {
                                ProfilePict.Image?.Dispose();
                                ProfilePict.Image = new Bitmap(img);
                            }
                        }
                        return;
                    }
                    catch
                    {
                        // Fall through to default image on any failure
                    }
                }
            }

            ProfilePict.Image?.Dispose();
            ProfilePict.Image = Properties.Resources.register;
        }

        private string HandleImageUpload(int userId, string sourceFilePath)
        {
            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
            {
                return null;
            }

            try
            {
                string targetFolder = Path.Combine(Application.StartupPath, "Uploads");
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                // Use a GUID to avoid collisions and keep an identifiable prefix
                string uniqueFileName = $"client_{userId}_{Guid.NewGuid()}{Path.GetExtension(sourceFilePath)}";
                string destinationPath = Path.Combine(targetFolder, uniqueFileName);

                File.Copy(sourceFilePath, destinationPath, true);

                return uniqueFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image upload failed: " + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;

                    try
                    {
                        // Load preview without locking the file
                        using (var fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var img = Image.FromStream(fs))
                            {
                                ProfilePict.Image?.Dispose();
                                ProfilePict.Image = new Bitmap(img);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot load selected image: " + ex.Message, "Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        selectedFilePath = null;
                    }
                }
            }
        }
    }
}