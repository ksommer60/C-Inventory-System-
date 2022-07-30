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
    public partial class MainForm : Form
    {
        int index;

        public MainForm()
        { 
            InitializeComponent();
           
            dataGridParts.DataSource = Inventory.AllParts;
            dataGridProducts.DataSource = Inventory.Products;
        }

        private void AddPartsButton(object sender, EventArgs e)
        {
            Add_Part addPart = new Add_Part();
            addPart.Show();
            this.Hide();
        }

        private void ModifyPartsButton(object sender, EventArgs e)
        {
            var selectedPart = dataGridParts.CurrentRow.DataBoundItem as Part; 

            ModifyPart modifyPart = new ModifyPart(selectedPart);
            modifyPart.Show();
            this.Hide();
        }

        private void DeletePartsButton(object sender, EventArgs e)
        {
            //verify delete of products
            string deleteMessage = "Are you sure you want to delete?";
            DialogResult messageBoxResult = MessageBox.Show("", deleteMessage, MessageBoxButtons.OKCancel);

            if (messageBoxResult == DialogResult.OK)
            {
                index = dataGridParts.CurrentCell.RowIndex;
                dataGridParts.Rows.RemoveAt(index);
            }
        }

        private void AddProductsButton(object sender, EventArgs e)
        {
            AddProducts addProduct = new AddProducts();
            addProduct.Show();
            this.Hide();
        }

        private void ModifyProductsButton(object sender, EventArgs e)
        {
            var selectedProduct = dataGridProducts.CurrentRow.DataBoundItem as Product;

            ModifyProducts modifyProduct = new ModifyProducts(selectedProduct);
            modifyProduct.Show();
            this.Hide();
        }

        private void DeleteProductsButton(object sender, EventArgs e)
        {
            //verify delete of products
            string deleteMessage = "Are you sure you want to delete?";
            DialogResult messageBoxResult = MessageBox.Show("", deleteMessage, MessageBoxButtons.OKCancel);

            if (messageBoxResult == DialogResult.OK)
            {
                Product prodAssociatedPart = dataGridProducts.CurrentRow.DataBoundItem as Product;

                //if statement to check is there is an associated part with the product
                if (prodAssociatedPart.AssociatedPart.Count == 0)
                {
                    index = dataGridProducts.CurrentCell.RowIndex;
                    dataGridProducts.Rows.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("There is an associated part with this product. Please remove this part before deleting this product."); 
                }
            }
        }

        private void SearchParts(object sender, EventArgs e)
        {
            string partSearchValue = searchPartsBox.Text.ToUpper();
            bool flag = false; 
            dataGridParts.ClearSelection();

            if (String.IsNullOrWhiteSpace(partSearchValue))
            {
                MessageBox.Show("Enter a part name.");
            }
            else
            {
                foreach(DataGridViewRow partsRow in dataGridParts.Rows)
                {
                    if (partsRow.Cells["PartName"].Value.ToString().ToUpper().Contains(partSearchValue))
                    {
                        flag = true;
                        partsRow.Selected = true;
                        break; 
                    }
                    else if (partsRow.Cells["PartID"].Value.ToString().ToUpper().Contains(partSearchValue))
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

        private void SearchProducts(object sender, EventArgs e)
        {
            string productSearchValue = searchProductBox.Text.ToUpper();
            bool flag = false;
            dataGridProducts.ClearSelection();

            if (String.IsNullOrWhiteSpace(productSearchValue))
            {
                MessageBox.Show("Enter a product name.");
            }
            else
            {
                foreach (DataGridViewRow productsRow in dataGridProducts.Rows)
                {
                    if (productsRow.Cells["ProductName"].Value.ToString().ToUpper().Contains(productSearchValue))
                    {
                        flag = true;
                        productsRow.Selected = true;
                        break;
                    }
                    else if (productsRow.Cells["PartID"].Value.ToString().ToUpper().Contains(productSearchValue))
                    {
                        flag = true;
                        productsRow.Selected = true;
                        break;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("No prodcut match!");
                }
            }
        }

        private void ExitProgram(object sender, EventArgs e)
        {
           Application.ExitThread(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridParts.ClearSelection();
            dataGridProducts.ClearSelection(); 
        }
    }

}
