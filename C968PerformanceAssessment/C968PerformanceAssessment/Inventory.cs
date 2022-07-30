using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968PerformanceAssessment
{
    class Inventory
    {
        //below are the product and parts lists and associated properties 
        static public BindingList<Product> Products = new BindingList<Product>();
        static public BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddDataToLists()
        {
            Inventory.AllParts.Add(new InHouse { PartID = 0, PartName = "Tire", InStock = 9, PartPrice = 9.00m, Max = 14, Min = 2, MachineID = 2215 });
            Inventory.AllParts.Add(new InHouse { PartID = 1, PartName = "Wheel", InStock = 14, PartPrice = 5.00m, Max = 22, Min = 8, MachineID = 2245 });
            Inventory.AllParts.Add(new InHouse { PartID = 2, PartName = "Brakes", InStock = 30, PartPrice = 15.00m, Max = 66, Min = 22, MachineID = 2200 });
        }

        public static void addProduct(Product products)
        {
            Products.Add(products);
        }

        public static bool removeProduct(int productID)
        {
            if (Product.Contains(Products[productID]))
            {
                Products.Remove(Products[productID]);
                return true;
            }
            else
            {
                return false;    
            }
        }

        public static Product lookUpProduct(int productID)
        {
            foreach (Product products in Products)
            {
                if (products.ProductID == productID)
                {
                    return products;
                }
            }
            return null; 
        }

        public void updateProduct(int productID, Product products)
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productID == Inventory.Products[i].ProductID)
                {
                    removeProduct(productID);
                }
                addProduct(products);
            }
        }

        public static void addParts(Part inventoryParts)
        {
            Inventory.AllParts.Add(inventoryParts);
        }

        public static bool deletePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void updatePart(int partID, Part allParts, object part)
        {
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (partID == Inventory.AllParts[i].PartID)
                {
                    deletePart((Part)part);
                }
                addParts(allParts);
            }
        }

        //loop through numbers for part id
        public static int PartID()
        {
            int partIDNumber = 0;

            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (partIDNumber == Inventory.AllParts[i].PartID)
                {
                    partIDNumber++;
                }
            } 
            return partIDNumber;
        }

        //loop through numbers for product id
        public static int ProductID()
        {
            int productIDNumber = 0;

            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productIDNumber == Inventory.Products[i].ProductID)
                {
                    productIDNumber++;
                }
            }
            return productIDNumber;
        }
    }































}
