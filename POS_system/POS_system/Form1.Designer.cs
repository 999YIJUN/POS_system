namespace POS_system
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEmployeeMan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.dgv_em_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_em_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPages = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.dgv_C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnCusSearch = new System.Windows.Forms.Button();
            this.txtCusSearch = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCUSPages = new System.Windows.Forms.Label();
            this.tabProuct = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.cboCategorySelect = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCategoryEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCustomerMan = new System.Windows.Forms.Button();
            this.btnProductMan = new System.Windows.Forms.Button();
            this.imageListProduct = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabProuct.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeMan
            // 
            this.btnEmployeeMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeMan.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeMan.Location = new System.Drawing.Point(12, 42);
            this.btnEmployeeMan.Name = "btnEmployeeMan";
            this.btnEmployeeMan.Size = new System.Drawing.Size(133, 79);
            this.btnEmployeeMan.TabIndex = 0;
            this.btnEmployeeMan.Text = "員工管理";
            this.btnEmployeeMan.UseVisualStyleBackColor = true;
            this.btnEmployeeMan.Click += new System.EventHandler(this.btnEmployeeMan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabProuct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 10);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 563);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.panel4);
            this.tabEmployee.Controls.Add(this.panel2);
            this.tabEmployee.Location = new System.Drawing.Point(4, 14);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(907, 545);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvEmployeeInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 454);
            this.panel4.TabIndex = 6;
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.AllowUserToAddRows = false;
            this.dgvEmployeeInfo.AllowUserToDeleteRows = false;
            this.dgvEmployeeInfo.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvEmployeeInfo.ColumnHeadersHeight = 54;
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_em_id,
            this.dgv_em_Name,
            this.dgvNumber,
            this.dgvBDay,
            this.dgv_Select});
            this.dgvEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeInfo.MultiSelect = false;
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.ReadOnly = true;
            this.dgvEmployeeInfo.RowHeadersVisible = false;
            this.dgvEmployeeInfo.RowHeadersWidth = 50;
            this.dgvEmployeeInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeeInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvEmployeeInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeInfo.RowTemplate.Height = 40;
            this.dgvEmployeeInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(901, 454);
            this.dgvEmployeeInfo.TabIndex = 0;
            this.dgvEmployeeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellContentClick);
            this.dgvEmployeeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellDoubleClick);
            // 
            // dgv_em_id
            // 
            this.dgv_em_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_em_id.DataPropertyName = "EmployeeID";
            this.dgv_em_id.HeaderText = "員工編號";
            this.dgv_em_id.MinimumWidth = 6;
            this.dgv_em_id.Name = "dgv_em_id";
            this.dgv_em_id.ReadOnly = true;
            // 
            // dgv_em_Name
            // 
            this.dgv_em_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_em_Name.DataPropertyName = "EmployeeName";
            this.dgv_em_Name.HeaderText = "姓名";
            this.dgv_em_Name.MinimumWidth = 6;
            this.dgv_em_Name.Name = "dgv_em_Name";
            this.dgv_em_Name.ReadOnly = true;
            // 
            // dgvNumber
            // 
            this.dgvNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNumber.DataPropertyName = "ContactNumber";
            this.dgvNumber.HeaderText = "聯絡資訊";
            this.dgvNumber.MinimumWidth = 6;
            this.dgvNumber.Name = "dgvNumber";
            this.dgvNumber.ReadOnly = true;
            // 
            // dgvBDay
            // 
            this.dgvBDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBDay.DataPropertyName = "BDay";
            this.dgvBDay.HeaderText = "生日";
            this.dgvBDay.MinimumWidth = 6;
            this.dgvBDay.Name = "dgvBDay";
            this.dgvBDay.ReadOnly = true;
            // 
            // dgv_Select
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgv_Select.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgv_Select.HeaderText = "";
            this.dgv_Select.MinimumWidth = 6;
            this.dgv_Select.Name = "dgv_Select";
            this.dgv_Select.ReadOnly = true;
            this.dgv_Select.Text = "修改";
            this.dgv_Select.ToolTipText = "修改";
            this.dgv_Select.UseColumnTextForButtonValue = true;
            this.dgv_Select.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPages);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 85);
            this.panel2.TabIndex = 5;
            // 
            // lblPages
            // 
            this.lblPages.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPages.Location = new System.Drawing.Point(727, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(174, 85);
            this.lblPages.TabIndex = 4;
            this.lblPages.Text = "label1";
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnEmpSearch);
            this.panel10.Controls.Add(this.txtEmpSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(100, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(290, 85);
            this.panel10.TabIndex = 1;
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpSearch.FlatAppearance.BorderSize = 0;
            this.btnEmpSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmpSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpSearch.Image = global::POS_system.Properties.Resources.icons8_search_30;
            this.btnEmpSearch.Location = new System.Drawing.Point(0, 0);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(56, 85);
            this.btnEmpSearch.TabIndex = 2;
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            this.btnEmpSearch.MouseLeave += new System.EventHandler(this.btnEmpSearch_MouseLeave);
            this.btnEmpSearch.MouseHover += new System.EventHandler(this.btnEmpSearch_MouseHover);
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpSearch.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpSearch.Location = new System.Drawing.Point(62, 23);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(228, 40);
            this.txtEmpSearch.TabIndex = 3;
            this.txtEmpSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnAddEmp);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 85);
            this.panel9.TabIndex = 0;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Image = global::POS_system.Properties.Resources.icons8_add_user_30;
            this.btnAddEmp.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(100, 85);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.panel6);
            this.tabCustomer.Controls.Add(this.panel5);
            this.tabCustomer.Location = new System.Drawing.Point(4, 14);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(907, 545);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvCustomerInfo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(901, 454);
            this.panel6.TabIndex = 7;
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.AllowUserToAddRows = false;
            this.dgvCustomerInfo.AllowUserToDeleteRows = false;
            this.dgvCustomerInfo.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvCustomerInfo.ColumnHeadersHeight = 54;
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_C_ID,
            this.dgv_C_Name,
            this.dgvEmail,
            this.dgvContactNum,
            this.dgvAddress,
            this.dgvBirthday,
            this.dgvSelect});
            this.dgvCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerInfo.MultiSelect = false;
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.ReadOnly = true;
            this.dgvCustomerInfo.RowHeadersVisible = false;
            this.dgvCustomerInfo.RowHeadersWidth = 50;
            this.dgvCustomerInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomerInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvCustomerInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomerInfo.RowTemplate.Height = 40;
            this.dgvCustomerInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCustomerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(901, 454);
            this.dgvCustomerInfo.TabIndex = 0;
            this.dgvCustomerInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerInfo_CellContentClick);
            this.dgvCustomerInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerInfo_CellDoubleClick);
            // 
            // dgv_C_ID
            // 
            this.dgv_C_ID.DataPropertyName = "CustomerID";
            this.dgv_C_ID.HeaderText = "會員編號";
            this.dgv_C_ID.MinimumWidth = 6;
            this.dgv_C_ID.Name = "dgv_C_ID";
            this.dgv_C_ID.ReadOnly = true;
            this.dgv_C_ID.Visible = false;
            this.dgv_C_ID.Width = 125;
            // 
            // dgv_C_Name
            // 
            this.dgv_C_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_C_Name.DataPropertyName = "CustomerName";
            this.dgv_C_Name.HeaderText = "姓名";
            this.dgv_C_Name.MinimumWidth = 6;
            this.dgv_C_Name.Name = "dgv_C_Name";
            this.dgv_C_Name.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "信箱";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvContactNum
            // 
            this.dgvContactNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvContactNum.DataPropertyName = "ContactNumber";
            this.dgvContactNum.HeaderText = "聯絡資訊";
            this.dgvContactNum.MinimumWidth = 6;
            this.dgvContactNum.Name = "dgvContactNum";
            this.dgvContactNum.ReadOnly = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAddress.DataPropertyName = "Address";
            this.dgvAddress.HeaderText = "地址";
            this.dgvAddress.MinimumWidth = 6;
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // dgvBirthday
            // 
            this.dgvBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBirthday.DataPropertyName = "BDay";
            this.dgvBirthday.HeaderText = "生日";
            this.dgvBirthday.MinimumWidth = 6;
            this.dgvBirthday.Name = "dgvBirthday";
            this.dgvBirthday.ReadOnly = true;
            // 
            // dgvSelect
            // 
            this.dgvSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvSelect.HeaderText = "";
            this.dgvSelect.MinimumWidth = 6;
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.ReadOnly = true;
            this.dgvSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvSelect.Text = "修改";
            this.dgvSelect.ToolTipText = "修改";
            this.dgvSelect.UseColumnTextForButtonValue = true;
            this.dgvSelect.Width = 125;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.lblCUSPages);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 457);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(901, 85);
            this.panel5.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnCusSearch);
            this.panel12.Controls.Add(this.txtCusSearch);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(100, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(290, 85);
            this.panel12.TabIndex = 7;
            // 
            // btnCusSearch
            // 
            this.btnCusSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCusSearch.FlatAppearance.BorderSize = 0;
            this.btnCusSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCusSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCusSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusSearch.Image = global::POS_system.Properties.Resources.icons8_search_30;
            this.btnCusSearch.Location = new System.Drawing.Point(0, 0);
            this.btnCusSearch.Name = "btnCusSearch";
            this.btnCusSearch.Size = new System.Drawing.Size(56, 85);
            this.btnCusSearch.TabIndex = 2;
            this.btnCusSearch.UseVisualStyleBackColor = true;
            this.btnCusSearch.Click += new System.EventHandler(this.btnCusSearch_Click);
            // 
            // txtCusSearch
            // 
            this.txtCusSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusSearch.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCusSearch.Location = new System.Drawing.Point(62, 23);
            this.txtCusSearch.Name = "txtCusSearch";
            this.txtCusSearch.Size = new System.Drawing.Size(228, 40);
            this.txtCusSearch.TabIndex = 4;
            this.txtCusSearch.TextChanged += new System.EventHandler(this.txtCusSearch_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnAddCustomer);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 85);
            this.panel11.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Image = global::POS_system.Properties.Resources.icons8_add_user_30;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 85);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCUSPages
            // 
            this.lblCUSPages.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCUSPages.Location = new System.Drawing.Point(727, 0);
            this.lblCUSPages.Name = "lblCUSPages";
            this.lblCUSPages.Size = new System.Drawing.Size(174, 85);
            this.lblCUSPages.TabIndex = 5;
            this.lblCUSPages.Text = "label1";
            this.lblCUSPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProuct
            // 
            this.tabProuct.Controls.Add(this.panel8);
            this.tabProuct.Controls.Add(this.panel7);
            this.tabProuct.Location = new System.Drawing.Point(4, 14);
            this.tabProuct.Name = "tabProuct";
            this.tabProuct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProuct.Size = new System.Drawing.Size(907, 545);
            this.tabProuct.TabIndex = 2;
            this.tabProuct.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.listViewProduct);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(901, 454);
            this.panel8.TabIndex = 4;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(0, 0);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(901, 454);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 457);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(901, 85);
            this.panel7.TabIndex = 3;
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelFilter.Location = new System.Drawing.Point(336, 0);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(145, 85);
            this.btnCancelFilter.TabIndex = 6;
            this.btnCancelFilter.Text = "取消篩選";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // cboCategorySelect
            // 
            this.cboCategorySelect.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCategorySelect.FormattingEnabled = true;
            this.cboCategorySelect.Location = new System.Drawing.Point(171, 27);
            this.cboCategorySelect.Name = "cboCategorySelect";
            this.cboCategorySelect.Size = new System.Drawing.Size(145, 31);
            this.cboCategorySelect.TabIndex = 5;
            this.cboCategorySelect.Text = "總類篩選";
            this.cboCategorySelect.SelectedIndexChanged += new System.EventHandler(this.cboCategorySelect_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnAddProduct);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(100, 85);
            this.panel13.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = global::POS_system.Properties.Resources.icons8_add_image_30;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 85);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnCategoryEdit
            // 
            this.btnCategoryEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCategoryEdit.Location = new System.Drawing.Point(0, 0);
            this.btnCategoryEdit.Name = "btnCategoryEdit";
            this.btnCategoryEdit.Size = new System.Drawing.Size(145, 85);
            this.btnCategoryEdit.TabIndex = 3;
            this.btnCategoryEdit.Text = "總類編輯";
            this.btnCategoryEdit.UseVisualStyleBackColor = true;
            this.btnCategoryEdit.Click += new System.EventHandler(this.btnCategoryEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1078, 241);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 230);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一頁";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1078, 17);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 212);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "上一頁";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnCustomerMan
            // 
            this.btnCustomerMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerMan.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustomerMan.Location = new System.Drawing.Point(12, 127);
            this.btnCustomerMan.Name = "btnCustomerMan";
            this.btnCustomerMan.Size = new System.Drawing.Size(133, 79);
            this.btnCustomerMan.TabIndex = 0;
            this.btnCustomerMan.Text = "會員管理";
            this.btnCustomerMan.UseVisualStyleBackColor = true;
            this.btnCustomerMan.Click += new System.EventHandler(this.btnCustomerMan_Click);
            // 
            // btnProductMan
            // 
            this.btnProductMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductMan.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductMan.Location = new System.Drawing.Point(12, 212);
            this.btnProductMan.Name = "btnProductMan";
            this.btnProductMan.Size = new System.Drawing.Size(133, 79);
            this.btnProductMan.TabIndex = 0;
            this.btnProductMan.Text = "商品管理";
            this.btnProductMan.UseVisualStyleBackColor = true;
            this.btnProductMan.Click += new System.EventHandler(this.btnProductMan_Click);
            // 
            // imageListProduct
            // 
            this.imageListProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListProduct.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.btnProductMan);
            this.panel1.Controls.Add(this.btnCustomerMan);
            this.panel1.Controls.Add(this.btnEmployeeMan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 563);
            this.panel1.TabIndex = 2;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmpName.Location = new System.Drawing.Point(24, 517);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(96, 28);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(157, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 563);
            this.panel3.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnCancelFilter);
            this.panel14.Controls.Add(this.cboCategorySelect);
            this.panel14.Controls.Add(this.btnCategoryEdit);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(100, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(481, 85);
            this.panel14.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 563);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1250, 610);
            this.MinimumSize = new System.Drawing.Size(1250, 610);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.tabProuct.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeMan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnCustomerMan;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCusSearch;
        private System.Windows.Forms.TextBox txtCusSearch;
        private System.Windows.Forms.Button btnProductMan;
        private System.Windows.Forms.TabPage tabProuct;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ImageList imageListProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblCUSPages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnCategoryEdit;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cboCategorySelect;
        private System.Windows.Forms.Button btnCancelFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_em_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_em_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBDay;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBirthday;
        private System.Windows.Forms.DataGridViewButtonColumn dgvSelect;
        private System.Windows.Forms.Panel panel14;
    }
}

