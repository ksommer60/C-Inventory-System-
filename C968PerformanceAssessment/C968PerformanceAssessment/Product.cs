using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968PerformanceAssessment
{
    public class Product
    {       
        //a list of parts
        public BindingList<Part> ListsOfParts = new BindingList<Part>();
        // a list of associated parts 
        public BindingList<Part> AssociatedPart = new BindingList<Part>();

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductInStock { get; set; }
        public int ProductMin { get; set; }
        public int ProductMax { get; set; }

        //methods of product 
        
        public void addAssociatedPart(Part listOfParts)
        {
            AssociatedPart.Add(listOfParts);
        }

        internal static bool Contains(object p)
        {
            throw new NotImplementedException();
        }

        public bool removeAssociatedPart(int partID)
        {
            for (int i = 0; i < AssociatedPart.Count; i++)
            {
                if (AssociatedPart[i].PartID == partID)
                {
                    AssociatedPart.Remove(AssociatedPart[i]);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            Part result = null;

            for (int i = 0; i < AssociatedPart.Count; i++)
            {
                if (AssociatedPart[i].PartID == partID)
                {
                    _ = AssociatedPart[i];
                }
            }
            return result;
        }

        internal static void Show(int productID)
        {
            throw new NotImplementedException();
        }
    }
}
