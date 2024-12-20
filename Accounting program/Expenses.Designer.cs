namespace Accounting_program
{
    partial class Expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.ExpensesDataGrid = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(483, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 40);
            this.label4.TabIndex = 27;
            this.label4.Text = "Expenses";
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
            this.delete.Location = new System.Drawing.Point(596, 139);
            this.delete.Margin = new System.Windows.Forms.Padding(6);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(243, 50);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.add.Location = new System.Drawing.Point(304, 139);
            this.add.Margin = new System.Windows.Forms.Padding(6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(243, 50);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(603, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(310, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(860, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "For:";
            // 
            // txtFor
            // 
            this.txtFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtFor.Location = new System.Drawing.Point(29, 71);
            this.txtFor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFor.Multiline = true;
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(243, 34);
            this.txtFor.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.AutoCompleteCustomSource.AddRange(new string[] {
            "Monthly Payment",
            "Yearly Payment",
            "Once Payment"});
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Font = new System.Drawing.Font("Arial", 14F);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Once ",
            "Monthly",
            "Yearly"});
            this.txtType.Location = new System.Drawing.Point(609, 71);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(208, 34);
            this.txtType.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDate.CustomFormat = "yyyy-MM-dd dddd";
            this.txtDate.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(866, 71);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(224, 34);
            this.txtDate.TabIndex = 4;
            // 
            // ExpensesDataGrid
            // 
            this.ExpensesDataGrid.AllowUserToAddRows = false;
            this.ExpensesDataGrid.AllowUserToDeleteRows = false;
            this.ExpensesDataGrid.AllowUserToResizeColumns = false;
            this.ExpensesDataGrid.AllowUserToResizeRows = false;
            this.ExpensesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ExpensesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpensesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpensesDataGrid.ColumnHeadersHeight = 29;
            this.ExpensesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExpensesDataGrid.EnableHeadersVisualStyles = false;
            this.ExpensesDataGrid.GridColor = System.Drawing.Color.White;
            this.ExpensesDataGrid.Location = new System.Drawing.Point(308, 315);
            this.ExpensesDataGrid.Name = "ExpensesDataGrid";
            this.ExpensesDataGrid.ReadOnly = true;
            this.ExpensesDataGrid.RowHeadersWidth = 10;
            this.ExpensesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ExpensesDataGrid.RowTemplate.Height = 24;
            this.ExpensesDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExpensesDataGrid.Size = new System.Drawing.Size(527, 259);
            this.ExpensesDataGrid.TabIndex = 49;
            this.ExpensesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesDataGrid_CellContentClick);
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtAmount.Location = new System.Drawing.Point(316, 71);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(243, 34);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 654);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.ExpensesDataGrid);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DataGridView ExpensesDataGrid;
        private System.Windows.Forms.TextBox txtAmount;
    }
}