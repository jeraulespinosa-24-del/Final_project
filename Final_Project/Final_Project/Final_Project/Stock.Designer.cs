namespace Final_Project
{
    partial class Stock
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
            dataGridView1 = new DataGridView();
            P_ID = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            P_Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDelete = new Button();
            Updatebtn = new Button();
            txtclear = new Button();
            label9 = new Label();
            button1 = new Button();
            procat = new ComboBox();
            proprice = new TextBox();
            label7 = new Label();
            prounit = new TextBox();
            label6 = new Label();
            proquan = new TextBox();
            label5 = new Label();
            prodesc = new TextBox();
            label4 = new Label();
            proname = new TextBox();
            label3 = new Label();
            prosku = new TextBox();
            label1 = new Label();
            proid = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { P_ID, SKU, P_Name, Description, Category, Quantity, Unit, Price });
            dataGridView1.Location = new Point(370, 1);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 787);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // P_ID
            // 
            P_ID.Frozen = true;
            P_ID.HeaderText = "P_ID";
            P_ID.MinimumWidth = 6;
            P_ID.Name = "P_ID";
            P_ID.Width = 110;
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 6;
            SKU.Name = "SKU";
            SKU.Width = 125;
            // 
            // P_Name
            // 
            P_Name.HeaderText = "P_Name";
            P_Name.MinimumWidth = 6;
            P_Name.Name = "P_Name";
            P_Name.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(Updatebtn);
            panel1.Controls.Add(txtclear);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(procat);
            panel1.Controls.Add(proprice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(prounit);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(proquan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(prodesc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(proname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(prosku);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(proid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 933);
            panel1.TabIndex = 34;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(159, 496);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btndelete_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(123, 462);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(78, 28);
            Updatebtn.TabIndex = 40;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // txtclear
            // 
            txtclear.Location = new Point(240, 462);
            txtclear.Name = "txtclear";
            txtclear.Size = new Size(78, 28);
            txtclear.TabIndex = 39;
            txtclear.Text = "Clear";
            txtclear.UseVisualStyleBackColor = true;
            txtclear.Click += txtclear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 254);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 38;
            label9.Text = "Category";
            // 
            // button1
            // 
            button1.Location = new Point(24, 462);
            button1.Name = "button1";
            button1.Size = new Size(78, 28);
            button1.TabIndex = 37;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // procat
            // 
            procat.FormattingEnabled = true;
            procat.Items.AddRange(new object[] { "Frozen Food,", " Beverages", "Personal Care", "Household Supplies" });
            procat.Location = new Point(175, 247);
            procat.Name = "procat";
            procat.Size = new Size(177, 28);
            procat.TabIndex = 36;
            // 
            // proprice
            // 
            proprice.Location = new Point(175, 409);
            proprice.Margin = new Padding(3, 4, 3, 4);
            proprice.Name = "proprice";
            proprice.Size = new Size(177, 27);
            proprice.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 412);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 33;
            label7.Text = "PRICE";
            // 
            // prounit
            // 
            prounit.Location = new Point(175, 355);
            prounit.Margin = new Padding(3, 4, 3, 4);
            prounit.Name = "prounit";
            prounit.Size = new Size(177, 27);
            prounit.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 358);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 31;
            label6.Text = "UNIT";
            // 
            // proquan
            // 
            proquan.Location = new Point(175, 296);
            proquan.Margin = new Padding(3, 4, 3, 4);
            proquan.Name = "proquan";
            proquan.Size = new Size(177, 27);
            proquan.TabIndex = 30;
            proquan.TextChanged += proquan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 299);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 29;
            label5.Text = "Quantity";
            // 
            // prodesc
            // 
            prodesc.Location = new Point(175, 200);
            prodesc.Margin = new Padding(3, 4, 3, 4);
            prodesc.Name = "prodesc";
            prodesc.Size = new Size(177, 27);
            prodesc.TabIndex = 28;
            prodesc.TextChanged += Desc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 203);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 27;
            label4.Text = "DESCRIPTION";
            // 
            // proname
            // 
            proname.Location = new Point(175, 116);
            proname.Margin = new Padding(3, 4, 3, 4);
            proname.Name = "proname";
            proname.Size = new Size(177, 27);
            proname.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 119);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 25;
            label3.Text = "PRODUCT NAME";
            // 
            // prosku
            // 
            prosku.Location = new Point(175, 64);
            prosku.Margin = new Padding(3, 4, 3, 4);
            prosku.Name = "prosku";
            prosku.Size = new Size(177, 27);
            prosku.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 23;
            label1.Text = "SKU";
            // 
            // proid
            // 
            proid.Location = new Point(175, 29);
            proid.Margin = new Padding(3, 4, 3, 4);
            proid.Name = "proid";
            proid.Size = new Size(177, 27);
            proid.TabIndex = 22;
            proid.TextChanged += proid_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 32);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 21;
            label2.Text = "PRODUCT ID";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 893);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private TextBox proid;
        private TextBox proname;
        private Label label3;
        private TextBox prosku;
        private Label label1;
        private TextBox prodesc;
        private Label label4;
        private TextBox proprice;
        private Label label7;
        private TextBox prounit;
        private Label label6;
        private TextBox proquan;
        private Label label5;
        private Label label8;
        private ComboBox procat;
        private Button button1;
        private DataGridViewTextBoxColumn P_ID;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn P_Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private Label label9;
        private Button txtclear;
        private Button Updatebtn;
        private Button btnDelete;
    }
}