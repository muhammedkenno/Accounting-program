namespace Accounting_program
{
    partial class Customers
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            this.txtStartedDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(473, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 40);
            this.label4.TabIndex = 38;
            this.label4.Text = "Customers";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(195)))), ((int)(((byte)(168)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.button2.Location = new System.Drawing.Point(583, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 50);
            this.button2.TabIndex = 42;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(301, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 50);
            this.button1.TabIndex = 41;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addBtn_Click);
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
            this.txtType.Location = new System.Drawing.Point(884, 71);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(193, 34);
            this.txtType.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(878, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(602, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtCompanyName.Location = new System.Drawing.Point(29, 71);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(243, 34);
            this.txtCompanyName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(303, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(32, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Started Working:";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtPaymentDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtPaymentDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtPaymentDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPaymentDate.CustomFormat = "yyyy-MM-dd dddd";
            this.txtPaymentDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPaymentDate.Location = new System.Drawing.Point(414, 190);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPaymentDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.txtPaymentDate.MinDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(219, 30);
            this.txtPaymentDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(408, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Payment Date:";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtName.Location = new System.Drawing.Point(314, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 34);
            this.txtName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.label8.Location = new System.Drawing.Point(782, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 32);
            this.label8.TabIndex = 44;
            this.label8.Text = "Status:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.radioButton1.Location = new System.Drawing.Point(788, 190);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 27);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Working";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.radioButton2.Location = new System.Drawing.Point(914, 190);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(183, 27);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stopped Working";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AllowUserToAddRows = false;
            this.customersDataGrid.AllowUserToDeleteRows = false;
            this.customersDataGrid.AllowUserToResizeColumns = false;
            this.customersDataGrid.AllowUserToResizeRows = false;
            this.customersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDataGrid.ColumnHeadersHeight = 29;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customersDataGrid.EnableHeadersVisualStyles = false;
            this.customersDataGrid.GridColor = System.Drawing.Color.White;
            this.customersDataGrid.Location = new System.Drawing.Point(166, 369);
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.ReadOnly = true;
            this.customersDataGrid.RowHeadersWidth = 10;
            this.customersDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customersDataGrid.RowTemplate.Height = 24;
            this.customersDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customersDataGrid.Size = new System.Drawing.Size(811, 259);
            this.customersDataGrid.TabIndex = 48;
            this.customersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGrid_CellContentClick);
            // 
            // txtStartedDate
            // 
            this.txtStartedDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtStartedDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtStartedDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtStartedDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStartedDate.CustomFormat = "yyyy-MM-dd dddd";
            this.txtStartedDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartedDate.Location = new System.Drawing.Point(38, 190);
            this.txtStartedDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStartedDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.txtStartedDate.MinDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.txtStartedDate.Name = "txtStartedDate";
            this.txtStartedDate.Size = new System.Drawing.Size(220, 30);
            this.txtStartedDate.TabIndex = 36;
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.txtAmount.Location = new System.Drawing.Point(608, 71);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(243, 34);
            this.txtAmount.TabIndex = 31;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 654);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtStartedDate);
            this.Controls.Add(this.customersDataGrid);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtPaymentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView customersDataGrid;
        private System.Windows.Forms.DateTimePicker txtStartedDate;
        private System.Windows.Forms.TextBox txtAmount;
    }
}