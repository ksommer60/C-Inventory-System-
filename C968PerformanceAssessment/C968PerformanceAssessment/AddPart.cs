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
    public partial class Add_Part : Form
    {
        public Regex integarValidation = new Regex("^(0|[1-9][0-9]*)$");
        public Regex decimalValidation = new Regex(@"-?[0-9][0-9,\.]+$");

        //validating the form entries are correct before submitting
        public bool IsRadioBtnTextValid()
        {
            if (radioBtnInHouse.Checked)
            {
                if (integarValidation.IsMatch(radioBtnValidation.Text))
                {
                    return true ;
                }
                else
                {
                 MessageBox.Show("Entered machine id value is invaid");
                 return false;
                }
            }
            return true;
        }

        public bool IsInventoryValid()
        {
            if (integarValidation.IsMatch(inventoryEntryBox.Text))
            {
                return true;
            }
            else
            {
                if (!integarValidation.IsMatch(inventoryEntryBox.Text))
                {
                    MessageBox.Show("Entered inventory number is invalid.");
                    return false;
                }
            }

            return true;
        }

        public bool IsPriceCostValid()
        {
            if (decimalValidation.IsMatch(priceCostValidation.Text))
            {

                return true;
            }
            else
            {
                if (!decimalValidation.IsMatch(priceCostValidation.Text))
                {
                    MessageBox.Show("Entered Price/Cost is invalid.");
                    return false;
                }
            }

            return true;
        }

        public bool IsMaxValid()
        {
            if (integarValidation.IsMatch(maxIntValidation.Text))
            {
                if (int.Parse(maxIntValidation.Text) < int.Parse(inventoryEntryBox.Text))
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
                if (!integarValidation.IsMatch(maxIntValidation.Text))
                {
                    MessageBox.Show("Enterd max value is invalid.");
                    return false;
                }
            }
            return true; 
        }

        public bool IsMinValid()
        {
            if (integarValidation.IsMatch(minIntValidation.Text))
            {
                if (int.Parse(minIntValidation.Text) > int.Parse(maxIntValidation.Text))
                {
                    MessageBox.Show("Min value can not be higher than max value");
                    return false;
                }
                
                if (int.Parse(minIntValidation.Text) > int.Parse(inventoryEntryBox.Text))
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
                if (!integarValidation.IsMatch(minIntValidation.Text))
                {
                    MessageBox.Show("Entered min value is invalid.");
                    return false;
                }
            }
            return true;
        }

        //method to create the part
        public void CreateNewPart()
        {
            if (radioBtnInHouse.Checked)
            {
                //creates a new in house part
                var newInHousePart = new InHouse
                {
                    PartID = int.Parse(partIDEntry.Text),
                    PartName = partNameEntry.Text,
                    InStock = int.Parse(inventoryEntryBox.Text),
                    PartPrice = decimal.Parse(priceCostValidation.Text),
                    Max = int.Parse(maxIntValidation.Text),
                    Min = int.Parse(minIntValidation.Text),
                    MachineID = int.Parse(radioBtnValidation.Text)
                };

                Inventory.addParts(newInHousePart);
            }
            else if (radioBtnCompany.Checked)
            {
                //creates a new outsourced part
                var newOutsourcedPart = new Outsourced
                {
                    PartID = int.Parse(partIDEntry.Text),
                    PartName = partNameEntry.Text,
                    InStock = int.Parse(inventoryEntryBox.Text),
                    PartPrice = decimal.Parse(priceCostValidation.Text),
                    Max = int.Parse(maxIntValidation.Text),
                    Min = int.Parse(minIntValidation.Text),
                    CompanyName = radioBtnValidation.Text
                };

                Inventory.addParts(newOutsourcedPart);
            }
        }

        public Add_Part()
        {
            InitializeComponent();

            partIDEntry.Text = Inventory.PartID().ToString();
            btnRadioButtonLabel.Text = "Machine ID";
        }

        private void SaveNewPart(object sender, EventArgs e)
        {
            if (IsRadioBtnTextValid() && IsInventoryValid() && IsPriceCostValid() && IsMaxValid() && IsMinValid())
            {
                CreateNewPart();
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Entry is invalid. Please verify all fields are filled in and are the correct values.");
            }
        }

        private void CancelAddingPart(object sender, EventArgs e)
        {
            //when user clicks cancel, window will close and text will be reset
            this.Hide();
            ResetText();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void InHouseRadioBtn(object sender, MouseEventArgs e)
        {
            //checking to see if the in house radio button is checked to display Machine ID
            if (radioBtnInHouse.Checked == true)
            {
                btnRadioButtonLabel.Text = "Machine ID";
            }
            else
            { 
                btnRadioButtonLabel.Text = " ";
            }
        }

        private void CompanyRadioButton(object sender, MouseEventArgs e)
        {
           
            //checking to see if the outsourced radio button is checked to display Company
            if (radioBtnCompany.Checked)
            {
               btnRadioButtonLabel.Text = "Company Name";
            }
            else
            {
                btnRadioButtonLabel.Text = " ";
            }
        }

        private void Add_Part_Load(object sender, EventArgs e)
        {

        }
    }
}
