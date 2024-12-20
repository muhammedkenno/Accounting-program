namespace Accounting_program
{
    partial class income
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.incomeDataGrid = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.AutoCompleteCustomSource.AddRange(new string[] {
            "Monthly Payment",
            "Yearly Payment",
            "Once Payment"});
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Once ",
            "Monthly",
            "Yearly"});
            this.txtType.Location = new System.Drawing.Point(609, 71);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(216, 35);
            this.txtType.TabIndex = 3;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.add.Location = new System.Drawing.Point(328, 162);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(225, 49);
            this.add.TabIndex = 5;
            this.add.Text = "Add Income";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(195)))), ((int)(((byte)(168)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.delete.Location = new System.Drawing.Point(589, 162);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(225, 49);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete Income";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Income Payments";
            // 
            // txtFrom
            // 
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtFrom.Location = new System.Drawing.Point(29, 73);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(243, 34);
            this.txtFrom.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDate.CustomFormat = "yyyy-MM-dd dddd";
            this.txtDate.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(866, 73);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(227, 34);
            this.txtDate.TabIndex = 4;
            // 
            // incomeDataGrid
            // 
            this.incomeDataGrid.AllowUserToAddRows = false;
            this.incomeDataGrid.AllowUserToDeleteRows = false;
            this.incomeDataGrid.AllowUserToResizeColumns = false;
            this.incomeDataGrid.AllowUserToResizeRows = false;
            this.incomeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.incomeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.incomeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.incomeDataGrid.ColumnHeadersHeight = 29;
            this.incomeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.incomeDataGrid.EnableHeadersVisualStyles = false;
            this.incomeDataGrid.GridColor = System.Drawing.Color.White;
            this.incomeDataGrid.Location = new System.Drawing.Point(374, 312);
            this.incomeDataGrid.Name = "incomeDataGrid";
            this.incomeDataGrid.ReadOnly = true;
            this.incomeDataGrid.RowHeadersWidth = 10;
            this.incomeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.incomeDataGrid.RowTemplate.Height = 24;
            this.incomeDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.incomeDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.incomeDataGrid.Size = new System.Drawing.Size(394, 259);
            this.incomeDataGrid.TabIndex = 50;
            this.incomeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeDataGrid_CellContentClick);
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtAmount.Location = new System.Drawing.Point(310, 73);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(243, 34);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 654);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.incomeDataGrid);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "income";
            this.Text = "income";
            this.Load += new System.EventHandler(this.income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DataGridView incomeDataGrid;
        private System.Windows.Forms.TextBox txtAmount;
    }
}