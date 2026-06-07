using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    internal class Portfolio
    {

        public int PortfolioId { get; set; }
        public string OwnerName { get; set; }

        public string ProfessionalTitle { get; set; }

        public string Biography { get; set; }

        public string ContactEmail { get; set; }

        public void DisplayPortfolio()
        {
            Console.WriteLine(ProfessionalTitle);
        }

        public void UpdateBio(string newBio)
        {
            this.Biography = newBio;
        }
    }
}
