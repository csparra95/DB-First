namespace WindowsFormsApp2
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
            this.northwindDataSet = new WindowsFormsApp2.NorthwindDataSet();
            this.northwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp2.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.fKOrdersEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApp2.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.Label();
            this.contactname = new System.Windows.Forms.Label();
            this.contacttitle = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.postcode = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.fax = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp2.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindDataSetBindingSource
            // 
            this.northwindDataSetBindingSource.DataSource = this.northwindDataSet;
            this.northwindDataSetBindingSource.Position = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrdersEmployeesBindingSource
            // 
            this.fKOrdersEmployeesBindingSource.DataMember = "FK_Orders_Employees";
            this.fKOrdersEmployeesBindingSource.DataSource = this.employeesBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.northwindDataSetBindingSource;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.northwindDataSetBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 20);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 268);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(173, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 303);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(173, 20);
            this.textBox9.TabIndex = 2;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 338);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(173, 20);
            this.textBox10.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 373);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(173, 20);
            this.textBox11.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(199, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // companyname
            // 
            this.companyname.AutoSize = true;
            this.companyname.Location = new System.Drawing.Point(199, 57);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(82, 13);
            this.companyname.TabIndex = 5;
            this.companyname.Text = "Company Name";
            // 
            // contactname
            // 
            this.contactname.AutoSize = true;
            this.contactname.Location = new System.Drawing.Point(199, 92);
            this.contactname.Name = "contactname";
            this.contactname.Size = new System.Drawing.Size(75, 13);
            this.contactname.TabIndex = 5;
            this.contactname.Text = "Contact Name";
            // 
            // contacttitle
            // 
            this.contacttitle.AutoSize = true;
            this.contacttitle.Location = new System.Drawing.Point(199, 128);
            this.contacttitle.Name = "contacttitle";
            this.contacttitle.Size = new System.Drawing.Size(64, 13);
            this.contacttitle.TabIndex = 5;
            this.contacttitle.Text = "Contac Title";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(199, 163);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(39, 13);
            this.adress.TabIndex = 5;
            this.adress.Text = "Adress";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(199, 198);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 5;
            this.city.Text = "City";
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(199, 232);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(41, 13);
            this.region.TabIndex = 5;
            this.region.Text = "Region";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(199, 303);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(43, 13);
            this.country.TabIndex = 5;
            this.country.Text = "Country";
            // 
            // postcode
            // 
            this.postcode.AutoSize = true;
            this.postcode.Location = new System.Drawing.Point(199, 267);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(64, 13);
            this.postcode.TabIndex = 5;
            this.postcode.Text = "Postal Code";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(199, 338);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(38, 13);
            this.phone.TabIndex = 5;
            this.phone.Text = "Phone";
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Location = new System.Drawing.Point(199, 373);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(24, 13);
            this.fax.TabIndex = 5;
            this.fax.Text = "Fax";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactTitleDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 382);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            // 
            // contactTitleDataGridViewTextBoxColumn
            // 
            this.contactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.Name = "contactTitleDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSetBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(661, 404);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(91, 34);
            this.delete.TabIndex = 7;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(425, 404);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 34);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(314, 404);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(91, 34);
            this.select.TabIndex = 7;
            this.select.Text = "SELECT";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(543, 404);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 33);
            this.update.TabIndex = 8;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.city);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.country);
            this.Controls.Add(this.contactname);
            this.Controls.Add(this.region);
            this.Controls.Add(this.contacttitle);
            this.Controls.Add(this.companyname);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource northwindDataSetBindingSource;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource fKOrdersEmployeesBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label companyname;
        private System.Windows.Forms.Label contactname;
        private System.Windows.Forms.Label contacttitle;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label postcode;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label fax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button update;
    }
}

