
namespace C968PerformanceAssessment
{
    partial class ModifyProducts
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
            this.candidatePartSearch = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productMin = new System.Windows.Forms.TextBox();
            this.productMax = new System.Windows.Forms.TextBox();
            this.productPriceCost = new System.Windows.Forms.TextBox();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.DGVCandidateParts1 = new System.Windows.Forms.DataGridView();
            this.DGVAssociatedParts1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandidateParts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts1)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatePartSearch
            // 
            this.candidatePartSearch.Location = new System.Drawing.Point(992, 92);
            this.candidatePartSearch.Name = "candidatePartSearch";
            this.candidatePartSearch.Size = new System.Drawing.Size(183, 20);
            this.candidatePartSearch.TabIndex = 66;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1100, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 65;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DeleteModifiedProduct);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1100, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 64;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddModifiedProduct);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(911, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SearchModifyProducts);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "All Candidate Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Modify Product";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1100, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelModifyOfProduct);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveModifiedProduct);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID";
            // 
            // productMin
            // 
            this.productMin.Location = new System.Drawing.Point(247, 379);
            this.productMin.Name = "productMin";
            this.productMin.Size = new System.Drawing.Size(126, 20);
            this.productMin.TabIndex = 49;
            // 
            // productMax
            // 
            this.productMax.Location = new System.Drawing.Point(63, 379);
            this.productMax.Name = "productMax";
            this.productMax.Size = new System.Drawing.Size(126, 20);
            this.productMax.TabIndex = 48;
            // 
            // productPriceCost
            // 
            this.productPriceCost.Location = new System.Drawing.Point(89, 335);
            this.productPriceCost.Name = "productPriceCost";
            this.productPriceCost.Size = new System.Drawing.Size(183, 20);
            this.productPriceCost.TabIndex = 47;
            // 
            // productInventory
            // 
            this.productInventory.Location = new System.Drawing.Point(89, 289);
            this.productInventory.Name = "productInventory";
            this.productInventory.Size = new System.Drawing.Size(183, 20);
            this.productInventory.TabIndex = 46;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(89, 245);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(183, 20);
            this.productName.TabIndex = 45;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(89, 205);
            this.productID.Multiline = true;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Size = new System.Drawing.Size(183, 20);
            this.productID.TabIndex = 44;
            // 
            // DGVCandidateParts1
            // 
            this.DGVCandidateParts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCandidateParts1.Location = new System.Drawing.Point(529, 121);
            this.DGVCandidateParts1.Name = "DGVCandidateParts1";
            this.DGVCandidateParts1.Size = new System.Drawing.Size(646, 159);
            this.DGVCandidateParts1.TabIndex = 67;
            // 
            // DGVAssociatedParts1
            // 
            this.DGVAssociatedParts1.AllowUserToAddRows = false;
            this.DGVAssociatedParts1.AllowUserToDeleteRows = false;
            this.DGVAssociatedParts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAssociatedParts1.Location = new System.Drawing.Point(529, 353);
            this.DGVAssociatedParts1.Name = "DGVAssociatedParts1";
            this.DGVAssociatedParts1.Size = new System.Drawing.Size(646, 171);
            this.DGVAssociatedParts1.TabIndex = 68;
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 622);
            this.Controls.Add(this.DGVAssociatedParts1);
            this.Controls.Add(this.DGVCandidateParts1);
            this.Controls.Add(this.candidatePartSearch);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productMin);
            this.Controls.Add(this.productMax);
            this.Controls.Add(this.productPriceCost);
            this.Controls.Add(this.productInventory);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productID);
            this.Name = "ModifyProducts";
            this.Text = "ModifyProducts";
            this.Load += new System.EventHandler(this.ModifyProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandidateParts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox candidatePartSearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productMin;
        private System.Windows.Forms.TextBox productMax;
        private System.Windows.Forms.TextBox productPriceCost;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.DataGridView DGVCandidateParts1;
        private System.Windows.Forms.DataGridView DGVAssociatedParts1;
    }
}