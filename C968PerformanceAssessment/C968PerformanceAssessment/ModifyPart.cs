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
    public partial class ModifyPart : Form
    {
        public Regex integarValidation = new Regex("^(0|[1-9][0-9]*)$");
        public Regex decimalValidation = new Regex(@"-?[0-9][0-9,\.]+$");

        //validating the form entries are correct before submitting
        public bool IsInventoryValid()
        {
            if (integarValidation.IsMatch(inventoryModifyBox.Text))
            {
                return true;
            }
            else
            {
                if (!integarValidation.IsMatch(inventoryModifyBox.Text))
                {
                    MessageBox.Show("Entered inventory number is invalid.");
                    return false;
                }
            }
            return true; 
        }

        public bool IsPriceCostValid()
        {
            if (decimalValidation.IsMatch(priceCostModify.Text))
            {
                return true;
            }
            else
            {
                if (!decimalValidation.IsMatch(priceCostModify.Text))
                {
                    MessageBox.Show("Entered Price/Cost is invalid.");
                    return false;
                }
            }

            return true;
        }

        public bool IsRadioBtnTextValid()
        {
            if (radioBtnInHouse.Checked)
            {
                if (integarValidation.IsMatch(radioBtnModify.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Entered machine id value is invaid");
                    return false;
                }
            }
            return true;
        }

        public bool IsMaxEntryValid()
        {
            if (integarValidation.IsMatch(maxModifyBox.Text))
            {
                if (int.Parse(maxModifyBox.Text) < int.Parse(inventoryModifyBox.Text))
                {
                    MessageBox.Show("Max and min valuse can not be lower than inventory amount.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (integarValidation.IsMatch(maxModifyBox.Text))
                {
                    MessageBox.Show("Enterd max value is invalid.");
                    return false;
                }
            }

            return true;
        }

        public bool IsMinEntryValid()
        {
            if (integarValidation.IsMatch(minModifyBox.Text))
            {
                if (int.Parse(minModifyBox.Text) > int.Parse(maxModifyBox.Text))
                {
                    MessageBox.Show("Min value can not be higher than max value");
                    return false;
                }
                else if (int.Parse(minModifyBox.Text) > int.Parse(inventoryModifyBox.Text))
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
                if (integarValidation.IsMatch(minModifyBox.Text))
                {
                    MessageBox.Show("Entered min value is invalid.");
                    return false;
                }
            }
            return true;
        }

        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(Part part)
        {
            InitializeComponent();
            btnRadioButtonLabel.Text = "Machine ID";

            modifyPartID.Text = part.PartID.ToString();
            modifyPartName.Text = part.PartName;
            inventoryModifyBox.Text = part.InStock.ToString();
            priceCostModify.Text = part.PartPrice.ToString();
            maxModifyBox.Text = part.Max.ToString();
            minModifyBox.Text = part.Min.ToString();

            if (part is InHouse)
            {
                radioBtnInHouse.Checked = true;
                btnRadioButtonLabel.Text = "Machine ID";
                 
                InHouse inHouse = (InHouse)part;
                radioBtnModify.Text = inHouse.MachineID.ToString();
            }
            else
            {
                radioBtnCompany.Checked = true;
                btnRadioButtonLabel.Text = "Company Name";

                Outsourced outsourced = (Outsourced)part;
                radioBtnModify.Text = outsourced.CompanyName; 
            }
        }

        public void UpdatingPart()
        {
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (modifyPartID.Text == Inventory.AllParts[i].PartID.ToString())
                {
                    if (radioBtnInHouse.Checked && Inventory.AllParts[i] is InHouse)
                    {
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);

                        InHouse inHousePart = new InHouse();
                        inHousePart.PartID = int.Parse(modifyPartID.Text);
                        inHousePart.PartName = modifyPartName.Text;
                        inHousePart.InStock = int.Parse(inventoryModifyBox.Text);
                        inHousePart.PartPrice = decimal.Parse(priceCostModify.Text);
                        inHousePart.Max = int.Parse(maxModifyBox.Text);
                        inHousePart.Min = int.Parse(minModifyBox.Text);
                        inHousePart.MachineID = int.Parse(radioBtnModify.Text);
           
                        Inventory.AllParts.Add(inHousePart);
                    }
                    else if (radioBtnCompany.Checked && Inventory.AllParts[i] is Outsourced)
                    {
                        Inventory.AllParts.Remove(Inventory.AllParts[i]);

                        Outsourced outSourcePart = new Outsourced();
                        outSourcePart.PartID = int.Parse(modifyPartID.Text);
                        outSourcePart.PartName = modifyPartName.Text;
                        outSourcePart.InStock = int.Parse(inventoryModifyBox.Text);
                        outSourcePart.PartPrice = decimal.Parse(priceCostModify.Text);
                        outSourcePart.Max = int.Parse(maxModifyBox.Text);
                        outSourcePart.Min = int.Parse(minModifyBox.Text);
                        outSourcePart.CompanyName = radioBtnModify.Text;

                        Inventory.AllParts.Add(outSourcePart);
                    }
                }
            }
        }

        private void SaveModifiedPart(object sender, EventArgs e)
        {
            if (IsInventoryValid() && IsMinEntryValid() && IsMaxEntryValid() && IsRadioBtnTextValid() && IsPriceCostValid())
            {
                UpdatingPart();
                this.Close();

                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Entry is invalid. Please verify all fields are filled in and are the correct values.");
            }
        }

        private void CancelModifyPart(object sender, EventArgs e)
        {
            //will close the window and reset the text
            this.Close();
            ResetText();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void InHouseRadioButton(object sender, MouseEventArgs e)
        {
            bool isRadioButtonCheck;

            //checking to see if the in house radio button is checked to display Machine ID
            if (radioBtnInHouse.Checked)
            {
                isRadioButtonCheck = true;
                btnRadioButtonLabel.Text = "Machine ID";
            }
            else
            {
                isRadioButtonCheck = false;
                btnRadioButtonLabel.Text = " ";
            }
        }

        private void OutSourcedRadioBtn(object sender, MouseEventArgs e)
        {
            bool isRadioButtonCheck;

            //checking to see if the outsourced radio button is checked to display company
            if (radioBtnCompany.Checked)
            {
                isRadioButtonCheck = true;
                btnRadioButtonLabel.Text = "Company";
            }
            else
            {
                isRadioButtonCheck = false;
                btnRadioButtonLabel.Text = " ";
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }
    }
}
