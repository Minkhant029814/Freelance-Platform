
using System.Collections.Generic;


namespace Freelance_Platform.model
{
    public class Portfolio
    {
       
        public int PortfolioId { get; set; }
        public string OwnerName { get; set; }
        public string ProfessionalTitle { get; set; }

        public string Profile { get; set; }
        public string Biography { get; set; }

        public string ContactEmail { get; set; }

        public string ExternalLink { get; set; }

        //public  project { get; set; }
        public List<Project> Projects { get; set; }

       

        

       
        public Portfolio()
        {
            OwnerName = string.Empty;
            ProfessionalTitle = string.Empty;
            Biography = string.Empty;
           
        }

        //public Portfolio(string ownerName, string professionalTitle, string biography,string conEmail,string externalLink)
        //{
        //    OwnerName = ownerName;
        //    ProfessionalTitle = professionalTitle;
        //    Biography = biography;
        //    ContactEmail = conEmail;
        //    ExternalLink = externalLink;
        //    //this.project = project;
        //}

       
        //public void DisplayPortfolio()
        //{
        //    Console.WriteLine($"Title: {ProfessionalTitle} | Owner: {OwnerName}");
        //}

        //public void UpdateBio(string newBio)
        //{
        //    this.Biography = newBio;
        //}
    }
}