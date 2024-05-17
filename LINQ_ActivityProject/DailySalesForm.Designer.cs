namespace LINQ_ActivityProject
{
    partial class DailySalesForm
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
            this.GenerateDailySales = new System.Windows.Forms.Button();
            this.SalesDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DailySalesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateDailySales
            // 
            this.GenerateDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDailySales.Location = new System.Drawing.Point(91, 136);
            this.GenerateDailySales.Name = "GenerateDailySales";
            this.GenerateDailySales.Size = new System.Drawing.Size(109, 43);
            this.GenerateDailySales.TabIndex = 0;
            this.GenerateDailySales.Text = "Generate";
            this.GenerateDailySales.UseVisualStyleBackColor = true;
            this.GenerateDailySales.Click += new System.EventHandler(this.GenerateDailySales_Click);
            // 
            // SalesDatePicker
            // 
            this.SalesDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDatePicker.Location = new System.Drawing.Point(47, 94);
            this.SalesDatePicker.Name = "SalesDatePicker";
            this.SalesDatePicker.Size = new System.Drawing.Size(179, 36);
            this.SalesDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick a date:";
            // 
            // DailySalesGrid
            // 
            this.DailySalesGrid.AllowUserToAddRows = false;
            this.DailySalesGrid.AllowUserToDeleteRows = false;
            this.DailySalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailySalesGrid.Location = new System.Drawing.Point(326, 45);
            this.DailySalesGrid.Name = "DailySalesGrid";
            this.DailySalesGrid.ReadOnly = true;
            this.DailySalesGrid.RowHeadersWidth = 51;
            this.DailySalesGrid.Size = new System.Drawing.Size(551, 396);
            this.DailySalesGrid.TabIndex = 3;
            // 
            // DailySalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 513);
            this.Controls.Add(this.DailySalesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesDatePicker);
            this.Controls.Add(this.GenerateDailySales);
            this.Name = "DailySalesForm";
            this.Text = "DailySalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateDailySales;
        private System.Windows.Forms.DateTimePicker SalesDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DailySalesGrid;
    }
}