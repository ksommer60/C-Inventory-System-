
namespace C968PerformanceAssessment
{
    partial class AddProducts
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsMin = new System.Windows.Forms.TextBox();
            this.productsMax = new System.Windows.Forms.TextBox();
            this.productsPriceCost = new System.Windows.Forms.TextBox();
            this.productsInventory = new System.Windows.Forms.TextBox();
            this.productsName = new System.Windows.Forms.TextBox();
            this.productsID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.candidatePartsSearch = new System.Windows.Forms.TextBox();
            this.DGVCandidateParts = new System.Windows.Forms.DataGridView();
            this.DGVAssociatedParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1089, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelAddProduct);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveProductsBtn);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID";
            // 
            // productsMin
            // 
            this.productsMin.Location = new System.Drawing.Point(242, 375);
            this.productsMin.Name = "productsMin";
            this.productsMin.Size = new System.Drawing.Size(126, 20);
            this.productsMin.TabIndex = 24;
            // 
            // productsMax
            // 
            this.productsMax.Location = new System.Drawing.Point(58, 375);
            this.productsMax.Name = "productsMax";
            this.productsMax.Size = new System.Drawing.Size(126, 20);
            this.productsMax.TabIndex = 23;
            // 
            // productsPriceCost
            // 
            this.productsPriceCost.Location = new System.Drawing.Point(84, 331);
            this.productsPriceCost.Name = "productsPriceCost";
            this.productsPriceCost.Size = new System.Drawing.Size(183, 20);
            this.productsPriceCost.TabIndex = 22;
            // 
            // productsInventory
            // 
            this.productsInventory.Location = new System.Drawing.Point(84, 285);
            this.productsInventory.Name = "productsInventory";
            this.productsInventory.Size = new System.Drawing.Size(183, 20);
            this.productsInventory.TabIndex = 21;
            // 
            // productsName
            // 
            this.productsName.Location = new System.Drawing.Point(84, 241);
            this.productsName.Name = "productsName";
            this.productsName.Size = new System.Drawing.Size(183, 20);
            this.productsName.TabIndex = 20;
            // 
            // productsID
            // 
            this.productsID.Location = new System.Drawing.Point(84, 201);
            this.productsID.Multiline = true;
            this.productsID.Name = "productsID";
            this.productsID.ReadOnly = true;
            this.productsID.Size = new System.Drawing.Size(183, 20);
            this.productsID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SearchAddProductBtn);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1089, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddProductsBtn);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1089, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DeleteProductBtn);
            // 
            // candidatePartsSearch
            // 
            this.candidatePartsSearch.Location = new System.Drawing.Point(981, 68);
            this.candidatePartsSearch.Name = "candidatePartsSearch";
            this.candidatePartsSearch.Size = new System.Drawing.Size(183, 20);
            this.candidatePartsSearch.TabIndex = 43;
            // 
            // DGVCandidateParts
            // 
            this.DGVCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCandidateParts.Location = new System.Drawing.Point(517, 91);
            this.DGVCandidateParts.Name = "DGVCandidateParts";
            this.DGVCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCandidateParts.Size = new System.Drawing.Size(647, 185);
            this.DGVCandidateParts.TabIndex = 68;
            // 
            // DGVAssociatedParts
            // 
            this.DGVAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAssociatedParts.Location = new System.Drawing.Point(517, 338);
            this.DGVAssociatedParts.Name = "DGVAssociatedParts";
            this.DGVAssociatedParts.Size = new System.Drawing.Size(647, 185);
            this.DGVAssociatedParts.TabIndex = 69;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 654);
            this.Controls.Add(this.DGVAssociatedParts);
            this.Controls.Add(this.DGVCandidateParts);
            this.Controls.Add(this.candidatePartsSearch);
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
            this.Controls.Add(this.productsMin);
            this.Controls.Add(this.productsMax);
            this.Controls.Add(this.productsPriceCost);
            this.Controls.Add(this.productsInventory);
            this.Controls.Add(this.productsName);
            this.Controls.Add(this.productsID);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productsMin;
        private System.Windows.Forms.TextBox productsMax;
        private System.Windows.Forms.TextBox productsPriceCost;
        private System.Windows.Forms.TextBox productsInventory;
        private System.Windows.Forms.TextBox productsName;
        private System.Windows.Forms.TextBox productsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox candidatePartsSearch;
        private System.Windows.Forms.DataGridView DGVCandidateParts;
        private System.Windows.Forms.DataGridView DGVAssociatedParts;
    }
}