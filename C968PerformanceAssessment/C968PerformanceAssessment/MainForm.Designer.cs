
namespace C968PerformanceAssessment
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.searchPartsBox = new System.Windows.Forms.TextBox();
            this.searchProductBox = new System.Windows.Forms.TextBox();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(424, 427);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(75, 23);
            this.btnAddParts.TabIndex = 5;
            this.btnAddParts.Text = "Add";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.AddPartsButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ModifyPartsButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeletePartsButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1104, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddProductsButton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1185, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ModifyProductsButton);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1266, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DeleteProductsButton);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1265, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.Location = new System.Drawing.Point(424, 120);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 12;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = true;
            this.searchPartsBtn.Click += new System.EventHandler(this.SearchParts);
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.Location = new System.Drawing.Point(1079, 120);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchProductsBtn.TabIndex = 13;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = true;
            this.searchProductsBtn.Click += new System.EventHandler(this.SearchProducts);
            // 
            // searchPartsBox
            // 
            this.searchPartsBox.Location = new System.Drawing.Point(505, 122);
            this.searchPartsBox.Name = "searchPartsBox";
            this.searchPartsBox.Size = new System.Drawing.Size(156, 20);
            this.searchPartsBox.TabIndex = 14;
            // 
            // searchProductBox
            // 
            this.searchProductBox.Location = new System.Drawing.Point(1160, 122);
            this.searchProductBox.Name = "searchProductBox";
            this.searchProductBox.Size = new System.Drawing.Size(180, 20);
            this.searchProductBox.TabIndex = 15;
            // 
            // dataGridParts
            // 
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Location = new System.Drawing.Point(17, 144);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(644, 277);
            this.dataGridParts.TabIndex = 16;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(695, 144);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(645, 277);
            this.dataGridProducts.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 523);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.searchProductBox);
            this.Controls.Add(this.searchPartsBox);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.Button searchProductsBtn;
        private System.Windows.Forms.TextBox searchPartsBox;
        private System.Windows.Forms.TextBox searchProductBox;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.DataGridView dataGridProducts;
    }
}

