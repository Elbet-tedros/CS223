namespace Lab111
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
            this.components = new System.ComponentModel.Container();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInventoryNumber = new System.Windows.Forms.Label();
            this.lblObjectNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_obj = new System.Windows.Forms.TextBox();
            this.txt_inv = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gdv = new System.Windows.Forms.DataGridView();
            this.ErrPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkAvailability = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rbu = new System.Windows.Forms.RadioButton();
            this.rbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(31, 49);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(81, 25);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(295, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblInventoryNumber
            // 
            this.lblInventoryNumber.AutoSize = true;
            this.lblInventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryNumber.Location = new System.Drawing.Point(499, 49);
            this.lblInventoryNumber.Name = "lblInventoryNumber";
            this.lblInventoryNumber.Size = new System.Drawing.Size(163, 25);
            this.lblInventoryNumber.TabIndex = 2;
            this.lblInventoryNumber.Text = "Inventory number";
            this.lblInventoryNumber.Click += new System.EventHandler(this.lblInventoryNumber_Click);
            // 
            // lblObjectNumber
            // 
            this.lblObjectNumber.AutoSize = true;
            this.lblObjectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectNumber.Location = new System.Drawing.Point(31, 168);
            this.lblObjectNumber.Name = "lblObjectNumber";
            this.lblObjectNumber.Size = new System.Drawing.Size(123, 25);
            this.lblObjectNumber.TabIndex = 3;
            this.lblObjectNumber.Text = "Object name";
            this.lblObjectNumber.Click += new System.EventHandler(this.lblObjectNumber_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(295, 168);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 25);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(543, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(36, 107);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(187, 30);
            this.txt_num.TabIndex = 6;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(504, 216);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(128, 30);
            this.txt_price.TabIndex = 7;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(233, 216);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(166, 30);
            this.txt_count.TabIndex = 8;
            // 
            // txt_obj
            // 
            this.txt_obj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obj.Location = new System.Drawing.Point(36, 216);
            this.txt_obj.Name = "txt_obj";
            this.txt_obj.Size = new System.Drawing.Size(148, 30);
            this.txt_obj.TabIndex = 9;
            // 
            // txt_inv
            // 
            this.txt_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inv.Location = new System.Drawing.Point(486, 109);
            this.txt_inv.Name = "txt_inv";
            this.txt_inv.Size = new System.Drawing.Size(215, 30);
            this.txt_inv.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(824, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(988, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // gdv
            // 
            this.gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv.Location = new System.Drawing.Point(715, 49);
            this.gdv.Name = "gdv";
            this.gdv.RowHeadersWidth = 51;
            this.gdv.RowTemplate.Height = 24;
            this.gdv.Size = new System.Drawing.Size(618, 197);
            this.gdv.TabIndex = 14;
            this.gdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_CellContentClick);
            // 
            // ErrPro
            // 
            this.ErrPro.ContainerControl = this;
            // 
            // chkAvailability
            // 
            this.chkAvailability.AutoSize = true;
            this.chkAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailability.Location = new System.Drawing.Point(59, 328);
            this.chkAvailability.Name = "chkAvailability";
            this.chkAvailability.Size = new System.Drawing.Size(139, 29);
            this.chkAvailability.TabIndex = 15;
            this.chkAvailability.Text = "isAvailable";
            this.chkAvailability.UseVisualStyleBackColor = true;
            this.chkAvailability.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "delivery",
            "fullPayment",
            "halfPayment"});
            this.checkedListBox1.Location = new System.Drawing.Point(300, 328);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(167, 89);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rbu
            // 
            this.rbu.AutoSize = true;
            this.rbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu.Location = new System.Drawing.Point(520, 337);
            this.rbu.Name = "rbu";
            this.rbu.Size = new System.Drawing.Size(94, 29);
            this.rbu.TabIndex = 17;
            this.rbu.TabStop = true;
            this.rbu.Text = "urgent";
            this.rbu.UseVisualStyleBackColor = true;
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn.Location = new System.Drawing.Point(520, 381);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(130, 29);
            this.rbn.TabIndex = 18;
            this.rbn.TabStop = true;
            this.rbn.Text = "not urgent";
            this.rbn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 450);
            this.Controls.Add(this.rbn);
            this.Controls.Add(this.rbu);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chkAvailability);
            this.Controls.Add(this.gdv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_inv);
            this.Controls.Add(this.txt_obj);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblObjectNumber);
            this.Controls.Add(this.lblInventoryNumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInventoryNumber;
        private System.Windows.Forms.Label lblObjectNumber;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_obj;
        private System.Windows.Forms.TextBox txt_inv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gdv;
        private System.Windows.Forms.ErrorProvider ErrPro;
        private System.Windows.Forms.CheckBox chkAvailability;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.RadioButton rbu;
    }
}

