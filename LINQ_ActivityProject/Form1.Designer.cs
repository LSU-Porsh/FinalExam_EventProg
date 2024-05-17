namespace LINQ_ActivityProject
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
            this.SalesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DailySalesRepBtn = new System.Windows.Forms.Button();
            this.SalesByProdutBtn = new System.Windows.Forms.Button();
            this.SalesByProCatBtn = new System.Windows.Forms.Button();
            this.SalesByItemSoldBtn = new System.Windows.Forms.Button();
            this.ListProdCatBtn = new System.Windows.Forms.Button();
            this.FreqCustomersBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerComBo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerNumTB = new System.Windows.Forms.TextBox();
            this.CustomerIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductCombo = new System.Windows.Forms.ComboBox();
            this.ProductQtyTB = new System.Windows.Forms.TextBox();
            this.ProductIDTB = new System.Windows.Forms.TextBox();
            this.ProdCatLbl = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.ProdCatTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalAmountlbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.MasterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.SupplierBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.MasterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGridView.Location = new System.Drawing.Point(277, 104);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.RowHeadersWidth = 51;
            this.SalesDataGridView.RowTemplate.Height = 24;
            this.SalesDataGridView.Size = new System.Drawing.Size(892, 285);
            this.SalesDataGridView.TabIndex = 0;
            this.SalesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Transactions";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DailySalesRepBtn);
            this.flowLayoutPanel1.Controls.Add(this.SalesByProdutBtn);
            this.flowLayoutPanel1.Controls.Add(this.SalesByProCatBtn);
            this.flowLayoutPanel1.Controls.Add(this.SalesByItemSoldBtn);
            this.flowLayoutPanel1.Controls.Add(this.ListProdCatBtn);
            this.flowLayoutPanel1.Controls.Add(this.FreqCustomersBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1177, 104);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 285);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // DailySalesRepBtn
            // 
            this.DailySalesRepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailySalesRepBtn.Location = new System.Drawing.Point(3, 3);
            this.DailySalesRepBtn.Name = "DailySalesRepBtn";
            this.DailySalesRepBtn.Size = new System.Drawing.Size(197, 28);
            this.DailySalesRepBtn.TabIndex = 1;
            this.DailySalesRepBtn.Text = "Daily Sales Report";
            this.DailySalesRepBtn.UseVisualStyleBackColor = true;
            this.DailySalesRepBtn.Click += new System.EventHandler(this.DailySalesRep_Click);
            // 
            // SalesByProdutBtn
            // 
            this.SalesByProdutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesByProdutBtn.Location = new System.Drawing.Point(3, 37);
            this.SalesByProdutBtn.Name = "SalesByProdutBtn";
            this.SalesByProdutBtn.Size = new System.Drawing.Size(197, 28);
            this.SalesByProdutBtn.TabIndex = 2;
            this.SalesByProdutBtn.Text = "Sales by Product";
            this.SalesByProdutBtn.UseVisualStyleBackColor = true;
            // 
            // SalesByProCatBtn
            // 
            this.SalesByProCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesByProCatBtn.Location = new System.Drawing.Point(3, 71);
            this.SalesByProCatBtn.Name = "SalesByProCatBtn";
            this.SalesByProCatBtn.Size = new System.Drawing.Size(197, 28);
            this.SalesByProCatBtn.TabIndex = 0;
            this.SalesByProCatBtn.Text = "Sales by Product Category";
            this.SalesByProCatBtn.UseVisualStyleBackColor = true;
            this.SalesByProCatBtn.Click += new System.EventHandler(this.SalesByProCat_Click);
            // 
            // SalesByItemSoldBtn
            // 
            this.SalesByItemSoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesByItemSoldBtn.Location = new System.Drawing.Point(3, 105);
            this.SalesByItemSoldBtn.Name = "SalesByItemSoldBtn";
            this.SalesByItemSoldBtn.Size = new System.Drawing.Size(197, 28);
            this.SalesByItemSoldBtn.TabIndex = 0;
            this.SalesByItemSoldBtn.Text = "Sales by Items Sold";
            this.SalesByItemSoldBtn.UseVisualStyleBackColor = true;
            // 
            // ListProdCatBtn
            // 
            this.ListProdCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListProdCatBtn.Location = new System.Drawing.Point(3, 139);
            this.ListProdCatBtn.Name = "ListProdCatBtn";
            this.ListProdCatBtn.Size = new System.Drawing.Size(197, 28);
            this.ListProdCatBtn.TabIndex = 0;
            this.ListProdCatBtn.Text = "List of Product Category";
            this.ListProdCatBtn.UseVisualStyleBackColor = true;
            // 
            // FreqCustomersBtn
            // 
            this.FreqCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreqCustomersBtn.Location = new System.Drawing.Point(3, 173);
            this.FreqCustomersBtn.Name = "FreqCustomersBtn";
            this.FreqCustomersBtn.Size = new System.Drawing.Size(197, 28);
            this.FreqCustomersBtn.TabIndex = 0;
            this.FreqCustomersBtn.Text = "Top 5 Frequent Customers";
            this.FreqCustomersBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer:";
            // 
            // CustomerComBo
            // 
            this.CustomerComBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerComBo.FormattingEnabled = true;
            this.CustomerComBo.Items.AddRange(new object[] {
            "Evelyn Turner",
            "Leo Bennett",
            "Sophia Foster",
            "Nathan Hayes",
            "Isabella Murphy",
            "Oliver Collins",
            "Lily Parker",
            "Henry Mitchell",
            "Ava Reed",
            "Lucas Morgan"});
            this.CustomerComBo.Location = new System.Drawing.Point(382, 486);
            this.CustomerComBo.Name = "CustomerComBo";
            this.CustomerComBo.Size = new System.Drawing.Size(227, 28);
            this.CustomerComBo.TabIndex = 6;
            this.CustomerComBo.SelectedIndexChanged += new System.EventHandler(this.CustomerComBo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact No:";
            // 
            // CustomerNumTB
            // 
            this.CustomerNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNumTB.Location = new System.Drawing.Point(382, 524);
            this.CustomerNumTB.Name = "CustomerNumTB";
            this.CustomerNumTB.Size = new System.Drawing.Size(227, 26);
            this.CustomerNumTB.TabIndex = 8;
            // 
            // CustomerIDTB
            // 
            this.CustomerIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTB.Location = new System.Drawing.Point(382, 450);
            this.CustomerIDTB.Name = "CustomerIDTB";
            this.CustomerIDTB.ReadOnly = true;
            this.CustomerIDTB.Size = new System.Drawing.Size(227, 27);
            this.CustomerIDTB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CustomerID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "ProductID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Product Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(720, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantity Sold:";
            // 
            // ProductCombo
            // 
            this.ProductCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCombo.FormattingEnabled = true;
            this.ProductCombo.Location = new System.Drawing.Point(850, 486);
            this.ProductCombo.Name = "ProductCombo";
            this.ProductCombo.Size = new System.Drawing.Size(227, 28);
            this.ProductCombo.TabIndex = 9;
            this.ProductCombo.SelectedIndexChanged += new System.EventHandler(this.ProductCombo_SelectedIndexChanged);
            // 
            // ProductQtyTB
            // 
            this.ProductQtyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQtyTB.Location = new System.Drawing.Point(850, 592);
            this.ProductQtyTB.Name = "ProductQtyTB";
            this.ProductQtyTB.Size = new System.Drawing.Size(227, 26);
            this.ProductQtyTB.TabIndex = 10;
            this.ProductQtyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductQtyTB_KeyDown);
            // 
            // ProductIDTB
            // 
            this.ProductIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTB.Location = new System.Drawing.Point(850, 450);
            this.ProductIDTB.Name = "ProductIDTB";
            this.ProductIDTB.ReadOnly = true;
            this.ProductIDTB.Size = new System.Drawing.Size(227, 27);
            this.ProductIDTB.TabIndex = 8;
            // 
            // ProdCatLbl
            // 
            this.ProdCatLbl.AutoSize = true;
            this.ProdCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCatLbl.Location = new System.Drawing.Point(689, 527);
            this.ProdCatLbl.Name = "ProdCatLbl";
            this.ProdCatLbl.Size = new System.Drawing.Size(144, 20);
            this.ProdCatLbl.TabIndex = 5;
            this.ProdCatLbl.Text = "Product Category:";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(561, 657);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(262, 59);
            this.button7.TabIndex = 11;
            this.button7.Text = "Post Sale";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Form";
            // 
            // PriceTB
            // 
            this.PriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB.Location = new System.Drawing.Point(850, 560);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(227, 26);
            this.PriceTB.TabIndex = 10;
            // 
            // ProdCatTB
            // 
            this.ProdCatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCatTB.Location = new System.Drawing.Point(850, 523);
            this.ProdCatTB.Name = "ProdCatTB";
            this.ProdCatTB.Size = new System.Drawing.Size(227, 26);
            this.ProdCatTB.TabIndex = 10;
            this.ProdCatTB.Text = "Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(718, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Product Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1103, 560);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 31);
            this.label11.TabIndex = 5;
            this.label11.Text = "TotalAmount:";
            // 
            // TotalAmountlbl
            // 
            this.TotalAmountlbl.AutoSize = true;
            this.TotalAmountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountlbl.ForeColor = System.Drawing.Color.Red;
            this.TotalAmountlbl.Location = new System.Drawing.Point(1114, 598);
            this.TotalAmountlbl.Name = "TotalAmountlbl";
            this.TotalAmountlbl.Size = new System.Drawing.Size(155, 29);
            this.TotalAmountlbl.TabIndex = 5;
            this.TotalAmountlbl.Text = "AmountHere";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(847, 621);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Press \"Enter\" to Calculate the Total Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1177, 484);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1083, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Date Sold:";
            // 
            // MasterPanel
            // 
            this.MasterPanel.BackColor = System.Drawing.Color.Green;
            this.MasterPanel.Controls.Add(this.ProductBtn);
            this.MasterPanel.Controls.Add(this.CustomerBtn);
            this.MasterPanel.Controls.Add(this.SupplierBtn);
            this.MasterPanel.Location = new System.Drawing.Point(0, -2);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(175, 753);
            this.MasterPanel.TabIndex = 14;
            // 
            // ProductBtn
            // 
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductBtn.Location = new System.Drawing.Point(3, 3);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(167, 65);
            this.ProductBtn.TabIndex = 15;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerBtn.Location = new System.Drawing.Point(3, 74);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(167, 65);
            this.CustomerBtn.TabIndex = 15;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplierBtn.Location = new System.Drawing.Point(3, 145);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Size = new System.Drawing.Size(167, 65);
            this.SupplierBtn.TabIndex = 15;
            this.SupplierBtn.Text = "Supplier";
            this.SupplierBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 746);
            this.Controls.Add(this.MasterPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ProdCatTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.ProductQtyTB);
            this.Controls.Add(this.ProductCombo);
            this.Controls.Add(this.ProductIDTB);
            this.Controls.Add(this.CustomerIDTB);
            this.Controls.Add(this.CustomerNumTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerComBo);
            this.Controls.Add(this.TotalAmountlbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProdCatLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesDataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MasterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SalesByItemSoldBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustomerComBo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerNumTB;
        private System.Windows.Forms.TextBox CustomerIDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ProductCombo;
        private System.Windows.Forms.TextBox ProductQtyTB;
        private System.Windows.Forms.TextBox ProductIDTB;
        private System.Windows.Forms.Label ProdCatLbl;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotalAmountlbl;
        private System.Windows.Forms.Button ListProdCatBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SalesByProCatBtn;
        private System.Windows.Forms.Button FreqCustomersBtn;
        private System.Windows.Forms.Button DailySalesRepBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SalesByProdutBtn;
        private System.Windows.Forms.FlowLayoutPanel MasterPanel;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.TextBox ProdCatTB;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button SupplierBtn;
    }
}

