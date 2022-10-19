namespace HW1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_fN = new System.Windows.Forms.TextBox();
            this.textBox_lN = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_addCustomer = new System.Windows.Forms.Button();
            this.button_listCustomer = new System.Windows.Forms.Button();
            this.button_addEMP = new System.Windows.Forms.Button();
            this.button_listEMP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_custID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_EmpID = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(111, 39);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(123, 27);
            this.textBox_ID.TabIndex = 0;
            // 
            // textBox_fN
            // 
            this.textBox_fN.Location = new System.Drawing.Point(111, 77);
            this.textBox_fN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_fN.Name = "textBox_fN";
            this.textBox_fN.Size = new System.Drawing.Size(123, 27);
            this.textBox_fN.TabIndex = 1;
            // 
            // textBox_lN
            // 
            this.textBox_lN.Location = new System.Drawing.Point(111, 116);
            this.textBox_lN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_lN.Name = "textBox_lN";
            this.textBox_lN.Size = new System.Drawing.Size(123, 27);
            this.textBox_lN.TabIndex = 2;
            this.textBox_lN.TextChanged += new System.EventHandler(this.textBox_lN_TextChanged);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(111, 155);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(123, 27);
            this.textBox_address.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // button_addCustomer
            // 
            this.button_addCustomer.Location = new System.Drawing.Point(24, 216);
            this.button_addCustomer.Name = "button_addCustomer";
            this.button_addCustomer.Size = new System.Drawing.Size(143, 58);
            this.button_addCustomer.TabIndex = 8;
            this.button_addCustomer.Text = "Add Customer";
            this.button_addCustomer.UseVisualStyleBackColor = true;
            this.button_addCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_listCustomer
            // 
            this.button_listCustomer.Location = new System.Drawing.Point(173, 216);
            this.button_listCustomer.Name = "button_listCustomer";
            this.button_listCustomer.Size = new System.Drawing.Size(143, 58);
            this.button_listCustomer.TabIndex = 9;
            this.button_listCustomer.Text = "List Customer";
            this.button_listCustomer.UseVisualStyleBackColor = true;
            this.button_listCustomer.Click += new System.EventHandler(this.button_listCustomer_Click);
            // 
            // button_addEMP
            // 
            this.button_addEMP.Location = new System.Drawing.Point(24, 280);
            this.button_addEMP.Name = "button_addEMP";
            this.button_addEMP.Size = new System.Drawing.Size(143, 58);
            this.button_addEMP.TabIndex = 10;
            this.button_addEMP.Text = "Add Employee";
            this.button_addEMP.UseVisualStyleBackColor = true;
            this.button_addEMP.Click += new System.EventHandler(this.button_addEMP_Click);
            // 
            // button_listEMP
            // 
            this.button_listEMP.Location = new System.Drawing.Point(173, 280);
            this.button_listEMP.Name = "button_listEMP";
            this.button_listEMP.Size = new System.Drawing.Size(143, 58);
            this.button_listEMP.TabIndex = 11;
            this.button_listEMP.Text = "List Employee";
            this.button_listEMP.UseVisualStyleBackColor = true;
            this.button_listEMP.Click += new System.EventHandler(this.button_listEMP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cust ID";
            // 
            // comboBox_custID
            // 
            this.comboBox_custID.FormattingEnabled = true;
            this.comboBox_custID.Location = new System.Drawing.Point(423, 29);
            this.comboBox_custID.Name = "comboBox_custID";
            this.comboBox_custID.Size = new System.Drawing.Size(151, 28);
            this.comboBox_custID.TabIndex = 13;
            this.comboBox_custID.SelectedIndexChanged += new System.EventHandler(this.comboBox_custID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Emp ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox_EmpID
            // 
            this.comboBox_EmpID.FormattingEnabled = true;
            this.comboBox_EmpID.Location = new System.Drawing.Point(703, 29);
            this.comboBox_EmpID.Name = "comboBox_EmpID";
            this.comboBox_EmpID.Size = new System.Drawing.Size(151, 28);
            this.comboBox_EmpID.TabIndex = 15;
            this.comboBox_EmpID.SelectedIndexChanged += new System.EventHandler(this.comboBox_EmpID_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(361, 99);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(493, 164);
            this.listBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Remove Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(448, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remove Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBox_EmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_custID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_listEMP);
            this.Controls.Add(this.button_addEMP);
            this.Controls.Add(this.button_listCustomer);
            this.Controls.Add(this.button_addCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_lN);
            this.Controls.Add(this.textBox_fN);
            this.Controls.Add(this.textBox_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_ID;
        private TextBox textBox_fN;
        private TextBox textBox_lN;
        private TextBox textBox_address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_addCustomer;
        private Button button_listCustomer;
        private Button button_addEMP;
        private Button button_listEMP;
        private Label label5;
        private ComboBox comboBox_custID;
        private Label label6;
        private ComboBox comboBox_EmpID;
        private ListBox listBox;
        private Button button1;
        private Button button2;
    }
}