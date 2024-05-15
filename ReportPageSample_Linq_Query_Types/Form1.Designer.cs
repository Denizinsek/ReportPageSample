namespace ReportPageSample_Linq_Query_Types
{
    partial class Form1
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
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.BtnIncreasingProductPrice = new System.Windows.Forms.Button();
            this.BtnListSpain = new System.Windows.Forms.Button();
            this.BtnListSevilla = new System.Windows.Forms.Button();
            this.BtnListNameTitle = new System.Windows.Forms.Button();
            this.BtnProductAndCategory = new System.Windows.Forms.Button();
            this.BtnProductsAndSuppliers = new System.Windows.Forms.Button();
            this.BtnSalesDetailProductsAndCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(12, 12);
            this.DGridView.Name = "DGridView";
            this.DGridView.Size = new System.Drawing.Size(1237, 203);
            this.DGridView.TabIndex = 0;
            // 
            // BtnIncreasingProductPrice
            // 
            this.BtnIncreasingProductPrice.Location = new System.Drawing.Point(12, 234);
            this.BtnIncreasingProductPrice.Name = "BtnIncreasingProductPrice";
            this.BtnIncreasingProductPrice.Size = new System.Drawing.Size(217, 68);
            this.BtnIncreasingProductPrice.TabIndex = 1;
            this.BtnIncreasingProductPrice.Text = "Ürünler Tablosunu  Birim Fiyata Göre/ Artan Sırala";
            this.BtnIncreasingProductPrice.UseVisualStyleBackColor = true;
            this.BtnIncreasingProductPrice.Click += new System.EventHandler(this.BtnIncreasingProductPrice_Click);
            // 
            // BtnListSpain
            // 
            this.BtnListSpain.Location = new System.Drawing.Point(235, 234);
            this.BtnListSpain.Name = "BtnListSpain";
            this.BtnListSpain.Size = new System.Drawing.Size(217, 68);
            this.BtnListSpain.TabIndex = 2;
            this.BtnListSpain.Text = "İspanya\'daki Müşterilerin Listesi";
            this.BtnListSpain.UseVisualStyleBackColor = true;
            this.BtnListSpain.Click += new System.EventHandler(this.BtnListSpain_Click);
            // 
            // BtnListSevilla
            // 
            this.BtnListSevilla.Location = new System.Drawing.Point(458, 234);
            this.BtnListSevilla.Name = "BtnListSevilla";
            this.BtnListSevilla.Size = new System.Drawing.Size(217, 68);
            this.BtnListSevilla.TabIndex = 3;
            this.BtnListSevilla.Text = "İspanya\'daki Sevilla Şehrinde Olan Müşterilerin Listesi";
            this.BtnListSevilla.UseVisualStyleBackColor = true;
            this.BtnListSevilla.Click += new System.EventHandler(this.BtnListSevilla_Click);
            // 
            // BtnListNameTitle
            // 
            this.BtnListNameTitle.Location = new System.Drawing.Point(681, 234);
            this.BtnListNameTitle.Name = "BtnListNameTitle";
            this.BtnListNameTitle.Size = new System.Drawing.Size(217, 68);
            this.BtnListNameTitle.TabIndex = 4;
            this.BtnListNameTitle.Text = "Müşterilerin Sadece, Ad,Ünvan ve Adres Kolonlarını Listele";
            this.BtnListNameTitle.UseVisualStyleBackColor = true;
            this.BtnListNameTitle.Click += new System.EventHandler(this.BtnListNameTitle_Click);
            // 
            // BtnProductAndCategory
            // 
            this.BtnProductAndCategory.Location = new System.Drawing.Point(904, 234);
            this.BtnProductAndCategory.Name = "BtnProductAndCategory";
            this.BtnProductAndCategory.Size = new System.Drawing.Size(217, 68);
            this.BtnProductAndCategory.TabIndex = 5;
            this.BtnProductAndCategory.Text = "Ürünler ve Kategori Tablosu Join İşlemi";
            this.BtnProductAndCategory.UseVisualStyleBackColor = true;
            this.BtnProductAndCategory.Click += new System.EventHandler(this.BtnProductAndCategory_Click);
            // 
            // BtnProductsAndSuppliers
            // 
            this.BtnProductsAndSuppliers.Location = new System.Drawing.Point(12, 308);
            this.BtnProductsAndSuppliers.Name = "BtnProductsAndSuppliers";
            this.BtnProductsAndSuppliers.Size = new System.Drawing.Size(217, 68);
            this.BtnProductsAndSuppliers.TabIndex = 6;
            this.BtnProductsAndSuppliers.Text = "Ürünler ve Tedarikçiler Tablosu Join İşlemi";
            this.BtnProductsAndSuppliers.UseVisualStyleBackColor = true;
            this.BtnProductsAndSuppliers.Click += new System.EventHandler(this.BtnProductsAndSuppliers_Click);
            // 
            // BtnSalesDetailProductsAndCategories
            // 
            this.BtnSalesDetailProductsAndCategories.Location = new System.Drawing.Point(235, 308);
            this.BtnSalesDetailProductsAndCategories.Name = "BtnSalesDetailProductsAndCategories";
            this.BtnSalesDetailProductsAndCategories.Size = new System.Drawing.Size(217, 68);
            this.BtnSalesDetailProductsAndCategories.TabIndex = 7;
            this.BtnSalesDetailProductsAndCategories.Text = "Satış Detayları, Ürünler ve Kategoriler Tablosu Join İşlemi";
            this.BtnSalesDetailProductsAndCategories.UseVisualStyleBackColor = true;
            this.BtnSalesDetailProductsAndCategories.Click += new System.EventHandler(this.BtnSalesDetailProductsAndCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 450);
            this.Controls.Add(this.BtnSalesDetailProductsAndCategories);
            this.Controls.Add(this.BtnProductsAndSuppliers);
            this.Controls.Add(this.BtnProductAndCategory);
            this.Controls.Add(this.BtnListNameTitle);
            this.Controls.Add(this.BtnListSevilla);
            this.Controls.Add(this.BtnListSpain);
            this.Controls.Add(this.BtnIncreasingProductPrice);
            this.Controls.Add(this.DGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.Button BtnIncreasingProductPrice;
        private System.Windows.Forms.Button BtnListSpain;
        private System.Windows.Forms.Button BtnListSevilla;
        private System.Windows.Forms.Button BtnListNameTitle;
        private System.Windows.Forms.Button BtnProductAndCategory;
        private System.Windows.Forms.Button BtnProductsAndSuppliers;
        private System.Windows.Forms.Button BtnSalesDetailProductsAndCategories;
    }
}

