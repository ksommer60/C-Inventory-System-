using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968PerformanceAssessment
{
    public partial class AddProducts : Form
    {
        public Regex integarValidation = new Regex("^(0|[1-9][0-9]*)$");
        public Regex decimalValidation = new Regex(@"-?[0-9][0-9,\.]+$");

        private int index;

        public BindingList<Part> parts = new BindingList<Part>();
        
        private void AddProducts_Load(object sender, EventArgs e)
        {
            DGVCandidateParts.ClearSelection();
        }

        //validating the form entries are correct before submitting
        public bool IsInventoryValid()
        {
            if (integarValidation.IsMatch(productsInventory.Text))
            {
                return true;
            }
            else
            {
                if (!integarValidation.IsMatch(productsInventory.Text))
                {
                    MessageBox.Show("Entered inventory number is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsPriceCostValid()
        {
            if (decimalValidation.IsMatch(productsPriceCost.Text))
            {
                return true;
            }
            else
            {
                if (!decimalValidation.IsMatch(productsPriceCost.Text))
                {
                    MessageBox.Show("Entered Price/Cost is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsMaxEntryValid()
        {
            if (integarValidation.IsMatch(productsMax.Text))
            {
                if (int.Parse(productsMax.Text) < int.Parse(productsInventory.Text))
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
                if (!integarValidation.IsMatch(productsMax.Text))
                {
                    MessageBox.Show("Enterd max value is invalid.");
                    return false;
                }
            }
            return true;
        }

        public bool IsMinEntryValid()
        {
            if (integarValidation.IsMatch(productsMin.Text))
            {
                if (int.Parse(productsMin.Text) > int.Parse(productsMax.Text))
                {
                    MessageBox.Show("Min value can not be higher than max value");
                    return false;
                }
                else if (int.Parse(productsMin.Text) > int.Parse(productsInventory.Text))
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
                if (!integarValidation.IsMatch(productsMin.Text))
                {
                    MessageBox.Show("Entered min value is invalid.");
                    return false;
                }
            }
            return true;
        }

        public AddProducts()
        {
            InitializeComponent();

            productsID.Text = Inventory.ProductID().ToString();
            DGVCandidateParts.DataSource = Inventory.AllParts;

            DGVCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCandidateParts.ReadOnly = true;
            DGVCandidateParts.MultiSelect = false;
            DGVCandidateParts.AllowUserToAddRows = false;

            DGVAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAssociatedParts.ReadOnly = true;
            DGVAssociatedParts.MultiSelect = false;
            DGVAssociatedParts.AllowUserToAddRows = false;

        }

        private void SearchAddProductBtn(object sender, EventArgs e)
        {
            string candidatePartSearchValue = candidatePartsSearch.Text.ToUpper();
            bool flag = false;
            Part currentRow = DGVCandidateParts.CurrentRow.DataBoundItem as Part; 
            DGVCandidateParts.ClearSelection();
            
            if (String.IsNullOrWhiteSpace(candidatePartSearchValue))
            {
                MessageBox.Show("Enter a part name.");
            }
            else
            {
                foreach (DataGridViewRow partsRow in DGVCandidateParts.Rows)
                {
                    if (partsRow.Cells["PartName"].Value.ToString().ToUpper().Contains(candidatePartSearchValue))
                    {
                        flag = true;
                        partsRow.Selected = true;

                        //if (partsRow.Selected)
                        //{
                               
                        //}

                        break;
                    }
                    else if (partsRow.Cells["PartID"].Value.ToString().ToUpper().Contains(candidatePartSearchValue))
                    {
                        flag = true;
                        partsRow.Selected = true;
                        break;
                    }
                }
            }

            if (!flag)
            {
               MessageBox.Show("No part match");
            }
        }

        public void AddProductsBtn(object sender, EventArgs e)
        {
            //add selcted parts from All Candidate parts grid to the Parts associated gird
            Part newCanidatePart = DGVCandidateParts.CurrentRow.DataBoundItem as Part;
            parts.Add(newCanidatePart);

            DGVAssociatedParts.DataSource = parts;
        }

        private void DeleteProductBtn(object sender, EventArgs e)
        {
            //verify delete of products
            string deleteMessage = "Are you sure you want to delete?";
            DialogResult messageBoxResult = MessageBox.Show("", deleteMessage, MessageBoxButtons.OKCancel);

            if (messageBoxResult == DialogResult.OK)
            {            
                index = DGVAssociatedParts.CurrentCell.RowIndex;
                parts.RemoveAt(index);   
            }
        }

        private void SaveProductsBtn(object sender, EventArgs e)
        {
            //save the new product information - returns to main form screen 
            if (IsInventoryValid() && IsMinEntryValid() && IsMaxEntryValid() && IsPriceCostValid())
            {
                Product newProduct = new Product();

                newProduct.AssociatedPart = parts;
                newProduct.ProductID = int.Parse(productsID.Text);
                newProduct.ProductName = productsName.Text;
                newProduct.ProductInStock = int.Parse(productsInventory.Text);
                newProduct.ProductPrice = decimal.Parse(productsPriceCost.Text);
                newProduct.ProductMax = int.Parse(productsMax.Text);
                newProduct.ProductMin = int.Parse(productsMin.Text);

                Inventory.Products.Add(newProduct);

                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Entry is invalid.Please verify all fields are filled in and are the correct values.");
            }
        }

        private void CancelAddProduct(object sender, EventArgs e)
        {
            //will close the window and reset the text
            this.Close();
            ResetText();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
