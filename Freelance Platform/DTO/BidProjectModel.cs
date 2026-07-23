using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_Platform.model
{
    public class BidProjectModel
    {

       
            public int ProjectId { get; set; }
            public string Title { get; set; }
            public decimal Budget { get; set; }
          
            public int TotalBids { get; set; }
            public int NewBids { get; set; }
       
    }
}
