
namespace C968PerformanceAssessment
{
    partial class ModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelModify = new System.Windows.Forms.Button();
            this.btnSaveModPart = new System.Windows.Forms.Button();
            this.radioBtnCompany = new System.Windows.Forms.RadioButton();
            this.radioBtnInHouse = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnModify = new System.Windows.Forms.TextBox();
            this.minModifyBox = new System.Windows.Forms.TextBox();
            this.maxModifyBox = new System.Windows.Forms.TextBox();
            this.priceCostModify = new System.Windows.Forms.TextBox();
            this.inventoryModifyBox = new System.Windows.Forms.TextBox();
            this.modifyPartName = new System.Windows.Forms.TextBox();
            this.modifyPartID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRadioButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelModify
            // 
            this.btnCancelModify.Location = new System.Drawing.Point(448, 358);
            this.btnCancelModify.Name = "btnCancelModify";
            this.btnCancelModify.Size = new System.Drawing.Size(75, 23);
            this.btnCancelModify.TabIndex = 37;
            this.btnCancelModify.Text = "Cancel";
            this.btnCancelModify.UseVisualStyleBackColor = true;
            this.btnCancelModify.Click += new System.EventHandler(this.CancelModifyPart);
            // 
            // btnSaveModPart
            // 
            this.btnSaveModPart.Location = new System.Drawing.Point(353, 358);
            this.btnSaveModPart.Name = "btnSaveModPart";
            this.btnSaveModPart.Size = new System.Drawing.Size(75, 23);
            this.btnSaveModPart.TabIndex = 36;
            this.btnSaveModPart.Text = "Save";
            this.btnSaveModPart.UseVisualStyleBackColor = true;
            this.btnSaveModPart.Click += new System.EventHandler(this.SaveModifiedPart);
            // 
            // radioBtnCompany
            // 
            this.radioBtnCompany.AutoSize = true;
            this.radioBtnCompany.Location = new System.Drawing.Point(291, 12);
            this.radioBtnCompany.Name = "radioBtnCompany";
            this.radioBtnCompany.Size = new System.Drawing.Size(80, 17);
            this.radioBtnCompany.TabIndex = 35;
            this.radioBtnCompany.Text = "Outsourced";
            this.radioBtnCompany.UseVisualStyleBackColor = true;
            this.radioBtnCompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OutSourcedRadioBtn);
            // 
            // radioBtnInHouse
            // 
            this.radioBtnInHouse.AutoSize = true;
            this.radioBtnInHouse.Checked = true;
            this.radioBtnInHouse.Location = new System.Drawing.Point(170, 12);
            this.radioBtnInHouse.Name = "radioBtnInHouse";
            this.radioBtnInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioBtnInHouse.TabIndex = 34;
            this.radioBtnInHouse.TabStop = true;
            this.radioBtnInHouse.Text = "In-House";
            this.radioBtnInHouse.UseVisualStyleBackColor = true;
            this.radioBtnInHouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InHouseRadioButton);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // radioBtnModify
            // 
            this.radioBtnModify.Location = new System.Drawing.Point(170, 307);
            this.radioBtnModify.Name = "radioBtnModify";
            this.radioBtnModify.Size = new System.Drawing.Size(183, 20);
            this.radioBtnModify.TabIndex = 26;
            // 
            // minModifyBox
            // 
            this.minModifyBox.Location = new System.Drawing.Point(353, 266);
            this.minModifyBox.Name = "minModifyBox";
            this.minModifyBox.Size = new System.Drawing.Size(126, 20);
            this.minModifyBox.TabIndex = 25;
            // 
            // maxModifyBox
            // 
            this.maxModifyBox.Location = new System.Drawing.Point(170, 266);
            this.maxModifyBox.Name = "maxModifyBox";
            this.maxModifyBox.Size = new System.Drawing.Size(126, 20);
            this.maxModifyBox.TabIndex = 24;
            // 
            // priceCostModify
            // 
            this.priceCostModify.Location = new System.Drawing.Point(170, 222);
            this.priceCostModify.Name = "priceCostModify";
            this.priceCostModify.Size = new System.Drawing.Size(183, 20);
            this.priceCostModify.TabIndex = 23;
            // 
            // inventoryModifyBox
            // 
            this.inventoryModifyBox.Location = new System.Drawing.Point(170, 176);
            this.inventoryModifyBox.Name = "inventoryModifyBox";
            this.inventoryModifyBox.Size = new System.Drawing.Size(183, 20);
            this.inventoryModifyBox.TabIndex = 22;
            // 
            // modifyPartName
            // 
            this.modifyPartName.Location = new System.Drawing.Point(170, 132);
            this.modifyPartName.Name = "modifyPartName";
            this.modifyPartName.Size = new System.Drawing.Size(183, 20);
            this.modifyPartName.TabIndex = 21;
            // 
            // modifyPartID
            // 
            this.modifyPartID.Location = new System.Drawing.Point(170, 92);
            this.modifyPartID.Name = "modifyPartID";
            this.modifyPartID.ReadOnly = true;
            this.modifyPartID.Size = new System.Drawing.Size(183, 20);
            this.modifyPartID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modify Part";
            // 
            // btnRadioButtonLabel
            // 
            this.btnRadioButtonLabel.AutoSize = true;
            this.btnRadioButtonLabel.Location = new System.Drawing.Point(80, 307);
            this.btnRadioButtonLabel.Name = "btnRadioButtonLabel";
            this.btnRadioButtonLabel.Size = new System.Drawing.Size(33, 13);
            this.btnRadioButtonLabel.TabIndex = 38;
            this.btnRadioButtonLabel.Text = "Lable";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 420);
            this.Controls.Add(this.btnRadioButtonLabel);
            this.Controls.Add(this.btnCancelModify);
            this.Controls.Add(this.btnSaveModPart);
            this.Controls.Add(this.radioBtnCompany);
            this.Controls.Add(this.radioBtnInHouse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnModify);
            this.Controls.Add(this.minModifyBox);
            this.Controls.Add(this.maxModifyBox);
            this.Controls.Add(this.priceCostModify);
            this.Controls.Add(this.inventoryModifyBox);
            this.Controls.Add(this.modifyPartName);
            this.Controls.Add(this.modifyPartID);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelModify;
        private System.Windows.Forms.Button btnSaveModPart;
        private System.Windows.Forms.RadioButton radioBtnCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radioBtnModify;
        private System.Windows.Forms.TextBox minModifyBox;
        private System.Windows.Forms.TextBox maxModifyBox;
        private System.Windows.Forms.TextBox priceCostModify;
        private System.Windows.Forms.TextBox inventoryModifyBox;
        private System.Windows.Forms.TextBox modifyPartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnRadioButtonLabel;
        private System.Windows.Forms.RadioButton radioBtnInHouse;
        public System.Windows.Forms.TextBox modifyPartID;
    }
}