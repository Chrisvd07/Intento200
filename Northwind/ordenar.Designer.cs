namespace Northwind
{
    partial class ordenar
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_ShipName = new TextBox();
            ShipViaComboBox = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            dataGridView13 = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            CustomerComboBox = new ComboBox();
            EmployeeComboBox = new ComboBox();
            txt_Region = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label23 = new Label();
            txt_ShipCountry = new TextBox();
            label24 = new Label();
            label9 = new Label();
            txt_PostalCode = new TextBox();
            label10 = new Label();
            txt_City = new TextBox();
            txt_Address = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView13).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(699, 350);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 47;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(478, 449);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 46;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(596, 449);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 45;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(359, 449);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 44;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_ShipName
            // 
            txt_ShipName.Font = new Font("Rockwell Condensed", 9F);
            txt_ShipName.Location = new Point(120, 431);
            txt_ShipName.Margin = new Padding(3, 4, 3, 4);
            txt_ShipName.Name = "txt_ShipName";
            txt_ShipName.Size = new Size(166, 25);
            txt_ShipName.TabIndex = 43;
            // 
            // ShipViaComboBox
            // 
            ShipViaComboBox.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShipViaComboBox.FormattingEnabled = true;
            ShipViaComboBox.Location = new Point(120, 472);
            ShipViaComboBox.Margin = new Padding(3, 4, 3, 4);
            ShipViaComboBox.Name = "ShipViaComboBox";
            ShipViaComboBox.Size = new Size(166, 26);
            ShipViaComboBox.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label12.Location = new Point(17, 474);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 40;
            label12.Text = "Ship Via:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label11.Location = new Point(12, 431);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 41;
            label11.Text = "Ship Name:";
            // 
            // dataGridView13
            // 
            dataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView13.Location = new Point(12, 231);
            dataGridView13.Name = "dataGridView13";
            dataGridView13.RowHeadersWidth = 51;
            dataGridView13.Size = new Size(550, 193);
            dataGridView13.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CustomerComboBox);
            panel2.Controls.Add(EmployeeComboBox);
            panel2.Controls.Add(txt_Region);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(txt_ShipCountry);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txt_PostalCode);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txt_City);
            panel2.Controls.Add(txt_Address);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 224);
            panel2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label4.Location = new Point(35, 132);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 13;
            label4.Text = "Required Date ";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Location = new Point(184, 162);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(143, 25);
            dateTimePicker3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label1.Location = new Point(76, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Customer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label2.Location = new Point(75, 63);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "Employee:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label3.Location = new Point(64, 99);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 3;
            label3.Text = "Order Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label5.Location = new Point(42, 166);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 3;
            label5.Text = "Shipped Date:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(184, 28);
            CustomerComboBox.Margin = new Padding(3, 4, 3, 4);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(143, 26);
            CustomerComboBox.TabIndex = 4;
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Location = new Point(184, 62);
            EmployeeComboBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new Size(143, 26);
            EmployeeComboBox.TabIndex = 4;
            // 
            // txt_Region
            // 
            txt_Region.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Region.FormattingEnabled = true;
            txt_Region.Items.AddRange(new object[] { "Eastern", "Western", "Northern", "Southern" });
            txt_Region.Location = new Point(605, 93);
            txt_Region.Margin = new Padding(3, 4, 3, 4);
            txt_Region.Name = "txt_Region";
            txt_Region.Size = new Size(143, 26);
            txt_Region.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(184, 96);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 25);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(184, 129);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 25);
            dateTimePicker2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label6.Location = new Point(509, 36);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 3;
            label6.Text = "Address:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label23.Location = new Point(548, 61);
            label23.Name = "label23";
            label23.Size = new Size(51, 20);
            label23.TabIndex = 3;
            label23.Text = "City:";
            // 
            // txt_ShipCountry
            // 
            txt_ShipCountry.Font = new Font("Rockwell Condensed", 9F);
            txt_ShipCountry.Location = new Point(605, 163);
            txt_ShipCountry.Margin = new Padding(3, 4, 3, 4);
            txt_ShipCountry.Name = "txt_ShipCountry";
            txt_ShipCountry.Size = new Size(143, 25);
            txt_ShipCountry.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label24.Location = new Point(522, 99);
            label24.Name = "label24";
            label24.Size = new Size(77, 20);
            label24.TabIndex = 3;
            label24.Text = "Region:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label9.Location = new Point(478, 129);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 3;
            label9.Text = "Postal Code:";
            // 
            // txt_PostalCode
            // 
            txt_PostalCode.Font = new Font("Rockwell Condensed", 9F);
            txt_PostalCode.Location = new Point(605, 127);
            txt_PostalCode.Margin = new Padding(3, 4, 3, 4);
            txt_PostalCode.Name = "txt_PostalCode";
            txt_PostalCode.Size = new Size(143, 25);
            txt_PostalCode.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label10.Location = new Point(465, 165);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 3;
            label10.Text = "Ship Country:";
            // 
            // txt_City
            // 
            txt_City.Font = new Font("Rockwell Condensed", 9F);
            txt_City.Location = new Point(605, 62);
            txt_City.Margin = new Padding(3, 4, 3, 4);
            txt_City.Name = "txt_City";
            txt_City.Size = new Size(143, 25);
            txt_City.TabIndex = 6;
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Rockwell Condensed", 9F);
            txt_Address.Location = new Point(605, 31);
            txt_Address.Margin = new Padding(3, 4, 3, 4);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(143, 25);
            txt_Address.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 242);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 48;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(652, 242);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 49;
            label8.Text = "label8";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(708, 239);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 50;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(601, 272);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 51;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(669, 274);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 52;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(737, 268);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 53;
            label16.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(605, 307);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 54;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(666, 312);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 55;
            label18.Text = "label18";
            // 
            // ordenar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_ShipName);
            Controls.Add(ShipViaComboBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dataGridView13);
            Controls.Add(panel2);
            Name = "ordenar";
            Text = "_ordenar";
            Load += ordenar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView13).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        public TextBox txt_ShipName;
        public ComboBox ShipViaComboBox;
        private Label label12;
        private Label label11;
        private DataGridView dataGridView13;
        public Panel panel2;
        private Label label4;
        public DateTimePicker dateTimePicker3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        public ComboBox CustomerComboBox;
        public ComboBox EmployeeComboBox;
        private ComboBox txt_Region;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
        private Label label6;
        private Label label23;
        public TextBox txt_ShipCountry;
        private Label label24;
        private Label label9;
        public TextBox txt_PostalCode;
        private Label label10;
        public TextBox txt_City;
        public TextBox txt_Address;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}