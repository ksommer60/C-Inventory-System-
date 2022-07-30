using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C968PerformanceAssessment
{
    public partial class ModifyProducts : Form
    {
        
        public Regex integarValidation = new Regex("^(0|[1-9][0-9]*)$");
        public Regex decimalValidation = new Regex(@"-?[0-9][0-9,\.]+$");

        private int index;

        private BindingList<Part> parts = new BindingList<Part>();

        //validating the form entries are correct before submitting
        public bool IsInventoryValid()
        {
            if (integarValidation.IsMatch(productInventory.Text))
            {
                return true;
            }
            else
            {
                if (!integarValidation.IsMatch(productInventory.Text))
                {
                    MessageBox.Show("Entered inventory number is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsPriceCostValid()
        {
            if (decimalValidation.IsMatch(productPriceCost.Text))
            {
                return true;
            }
            else
            {
                if (!decimalValidation.IsMatch(productPriceCost.Text))
                {
                    MessageBox.Show("Entered Price/Cost is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsMaxEntryValid()
        {
            if (integarValidation.IsMatch(productMax.Text))
            {
                if (int.Parse(productMax.Text) < int.Parse(productInventory.Text))
                {
                    MessageBox.Show("Max value can not be lower than inventory amount.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (integarValidation.IsMatch(productMax.Text))
                {
                    MessageBox.Show("Enterd max value is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsMinEntryValid()
        {
            if (integarValidation.IsMatch(productMin.Text))
            {
                if (int.Parse(productMin.Text) > int.Parse(productMax.Text))
                {
                    MessageBox.Show("Min value can not be higher than max value");
                    return false;
                }
                else if (int.Parse(productMin.Text) > int.Parse(productInventory.Text))
                {
                    MessageBox.Show("Min value can not be higher than inventory amount.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (!integarValidation.IsMatch(productMin.Text))
                {
                    MessageBox.Show("Entered min value is invalid.");
                    return false;
                }
            }
            return true;        
        }

        public ModifyProducts()
        {
            InitializeComponent();
        }

        public ModifyProducts(Product product)
        {
            InitializeComponent();

            DGVCandidateParts1.DataSource = Inventory.AllParts;

            productID.Text = product.ProductID.ToString();
            productName.Text = product.ProductName;
            productInventory.Text = product.ProductInStock.ToString();
            productPriceCost.Text = product.ProductPrice.ToString();
            productMax.Text = product.ProductMax.ToString();
            productMin.Text = product.ProductMin.ToString();

            parts = product.AssociatedPart;

            DGVAssociatedParts1.DataSource = parts;
        }

        private void SearchModifyProducts(object sender, EventArgs e)
        {
            string candidatePartSearchValue = candidatePartSearch.Text.ToUpper();
            bool flag = false;
            DGVCandidateParts1.ClearSelection();

            if (String.IsNullOrWhiteSpace(candidatePartSearchValue))
            {
                MessageBox.Show("Enter a part name.");
            }
            else
            {
                foreach (DataGridViewRow partsRow in DGVCandidateParts1.Rows)
                {
                    if (partsRow.Cells["PartName"].Value.ToString().ToUpper().Contains(candidatePartSearchValue))
                    {
                        flag = true;
                        partsRow.Selected = true;
                        break;
                    }
                    else if (partsRow.Cells["PartID"].Value.ToString().ToUpper().Contains(candidatePartSearchValue))
                    {
                        flag = true;
                        partsRow.Selected = true;
                        break;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("No part match");
                }
            }
        }

        private void AddModifiedProduct(object sender, EventArgs e)
        {
            //add selcted parts from All Candidate parts grid to the Parts associated gird 
            Part newCanidatePart = DGVCandidateParts1.CurrentRow.DataBoundItem as Part;
            parts.Add(newCanidatePart);

            DGVAssociatedParts1.DataSource = parts;
        }

        private void DeleteModifiedProduct(object sender, EventArgs e)
        {
            //verify delete of products in parts associated grid
            string deleteMessage = "Are you sure you want to delete?";
            DialogResult messageBoxResult = MessageBox.Show("", deleteMessage, MessageBoxButtons.OKCancel);
            

            if (messageBoxResult == DialogResult.OK)
            {
                Product product = DGVAssociatedParts1.CurrentRow.DataBoundItem as Product;
                var currentRow = DGVAssociatedParts1.CurrentRow.DataBoundItem; 
                
                index = DGVAssociatedParts1.CurrentCell.RowIndex;
                DGVAssociatedParts1.Rows.RemoveAt(index);
            }
        }

        void UpdatingProduct()
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productID.Text ==  Inventory.Products[i].ProductID.ToString())
                {
                    Inventory.Products.Remove(Inventory.Products[i]);

                    Product newProduct = new Product();

                    newProduct.AssociatedPart = parts;
                    newProduct.ProductID = int.Parse(productID.Text);
                    newProduct.ProductName = productName.Text;
                    newProduct.ProductInStock = int.Parse(productInventory.Text);
                    newProduct.ProductPrice = decimal.Parse(productPriceCost.Text);
                    newProduct.ProductMax = int.Parse(productMax.Text);
                    newProduct.ProductMin = int.Parse(productMin.Text);

                    foreach (DataGridViewRow row in DGVAssociatedParts1.Rows)
                    {
                        Part part = row.DataBoundItem as Part;
                        newProduct.addAssociatedPart(part); 
                    }

                    Inventory.Products.Add(newProduct);
                }
            }
        }

        private void SaveModifiedProduct(object sender, EventArgs e)
        {
            if (IsInventoryValid() && IsMaxEntryValid() && IsMinEntryValid() && IsPriceCostValid())
            {
                UpdatingProduct();
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Entry is invalid. Please verify all fields are filled in and are the correct values."); 
            }
        }

        private void CancelModifyOfProduct(object sender, EventArgs e)
        {
            //will close the window and reset the text
            this.Hide();
            ResetText();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ModifyProducts_Load(object sender, EventArgs e)
        {
            DGVCandidateParts1.ClearSelection();
        }
    }
}
