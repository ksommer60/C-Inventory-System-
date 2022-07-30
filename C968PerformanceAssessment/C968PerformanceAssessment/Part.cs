using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968PerformanceAssessment
{
    public class Part 
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal PartPrice { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
     
        internal static bool Contains(Part part)
        {
            throw new NotImplementedException();
        }

        internal static void Show(int partID)
        {
            throw new NotImplementedException();
        }
    }
}
