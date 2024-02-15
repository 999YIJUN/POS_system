using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace POS_system
{
    public partial class Form1 : Form
    {
        int tempID = 0;
        int selectedCBOIndex = 0;
        bool isProductUpdate = false;

        #region 頁數變數
        int currentPage = 1;  // 定義當前頁數
        int perPage = 8;     //  定義每頁筆數
        int totalRecords = 0;   //   定義總筆數
        int totalPages = 0;    //    定義總頁數
        int currentCUSPage = 1;
        int totalCUSRecords = 0;
        int totalCUSPages = 0;
        #endregion

        List<string> listCategories = new List<string>();
        List<int> list_pID = new List<int>();
        List<string> list_pName = new List<string>();
        List<int> list_Unit = new List<int>();
        List<int> list_Price = new List<int>();
        // Button --> Image Management
        Dictionary<Button, (Image hoverImage, Image leaveImage)> ButtonImage = new Dictionary<Button, (Image hoverImage, Image leaveImage)>();
        
        private static Form1 instance;
        public static Form1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }

        private Form1()
        {
            InitializeComponent();
            // 選取 row 時 column header 不要跟著被選
            dgvEmployeeInfo.EnableHeadersVisualStyles = false;
            dgvEmployeeInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvEmployeeInfo.ColumnHeadersDefaultCellStyle.BackColor;
            dgvCustomerInfo.EnableHeadersVisualStyles = false;
            dgvCustomerInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor;

            totalRecords = GetTotalRecordsCount("EMPLOYEE");
            totalPages = (int)Math.Ceiling((double)totalRecords / perPage);

            totalCUSRecords = GetTotalRecordsCount("CUSTOMER");
            totalCUSPages = (int)Math.Ceiling((double)totalCUSRecords / perPage);

            initEvents();
        }

        public void initEvents()
        {
            FrmEmployeeManagement employeeManagementForm = FrmEmployeeManagement.GetInstance();
            employeeManagementForm.EmployeeManagementClosed += (ss, ee) => { Show_EmpInfo_DGV(); };

            FrmCustomerManagement customerManagementForm = FrmCustomerManagement.GetInstance();
            customerManagementForm.CustomerManagementClosed += (ss, ee) => { Show_CustomerInfo_DGV(); };

            FrmProductManagement productManagementForm = FrmProductManagement.GetInstance();
            productManagementForm.ProductManagementClosed += ProductManagementForm_Closed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_EmpInfo_DGV();
            Show_CustomerInfo_DGV();
            Show_ProductInfo_PicMode();
            read_Category_DB();
            dgvEmployeeInfo.ClearSelection();
            dgvCustomerInfo.ClearSelection();
            //lblEmpName.Text = GlobalVar.strName;
            lblEmpName.Visible = false;
            foreach(var cboText in listCategories)
            {
                cboCategorySelect.Items.Add(cboText);
            }
           
            
            // tabControl tabPage hide
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            InitializeButtonImages();

        }



        private void ProductManagementForm_Closed(object sender, EventArgs e)
        {
            //if (!isProductUpdate)
            //{
                ListViewInit();
                cboCategorySelect.Text = "總類篩選";
                Show_ProductInfo_PicMode();
            //}
        }

        #region Employee Management 
        private void btnEmployeeMan_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabEmployee;
            btnVisibleState(btnPrevious, true);
            btnVisibleState(btnNext, true);
        }

        void Show_EmpInfo_DGV()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    int offset = currentPage > 1 ? (currentPage - 1) * perPage : 0;// 實現分頁

                    string strSQL = $"SELECT EmployeeID, EmployeeName, ContactNumber, BDay FROM EMPLOYEE ORDER BY EmployeeID OFFSET {offset} ROWS FETCH NEXT {perPage} ROWS ONLY";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvEmployeeInfo.AutoGenerateColumns = false;

                            //DataGridViewColumn columnID = dataGridView1.Columns["dgv_em_id"];

                            //if(columnID != null)
                            //{
                            //    columnID.DataPropertyName = "EmployeeID";
                            //}
                            dgvEmployeeInfo.DataSource = dt;
                            lblPages.Text = $"頁數: {currentPage} / {totalPages}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvEmployeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ContentName = dgvEmployeeInfo.Columns[e.ColumnIndex].Name.ToString();
            if (ContentName == "dgv_Select")
            {
                SelectRow(e.RowIndex);
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            tempID = 0;
            FrmEmployeeManagement EmpManagement = FrmEmployeeManagement.GetInstance();
            EmpManagement.tempbtnName("新增");
            EmpManagement.ShowDialog();
        }

        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmpSearch.Text))
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "select * from EMPLOYEE where EmployeeName like @SearchName;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("SearchName", $"%{txtEmpSearch.Text.Trim()}%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dgvEmployeeInfo.AutoGenerateColumns = false;
                                dgvEmployeeInfo.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("查無此人");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtEmpSearch.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入文字");
                txtEmpSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpSearch.Text == string.Empty)
            {
                Show_EmpInfo_DGV();
            }
        }
        #endregion

        #region Customer Management
        private void btnCustomerMan_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabCustomer;
            btnVisibleState(btnPrevious, true);
            btnVisibleState(btnNext, true);
        }

        void Show_CustomerInfo_DGV()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    int offset = currentCUSPage > 1 ? (currentCUSPage - 1) * perPage : 0;
                    string strSQL = $"select * from CUSTOMER ORDER BY CustomerID offset {offset} rows fetch next {perPage} rows only";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvCustomerInfo.AutoGenerateColumns = false;
                            dgvCustomerInfo.DataSource = dt;

                            lblCUSPages.Text = $"頁數: {currentCUSPage} / {totalCUSPages}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ContentName = dgvCustomerInfo.Columns[e.ColumnIndex].Name.ToString();
            if (ContentName == "dgvSelect")
            {
                SelectRow(e.RowIndex);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            tempID = 0;
            FrmCustomerManagement CusManagement = FrmCustomerManagement.GetInstance();
            CusManagement.tempbtnName("新增");
            CusManagement.ShowDialog();
        }

        private void btnCusSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCusSearch.Text))
            {
                using (SqlConnection con = new SqlConnection((GlobalVar.strMyDBConnectionString)))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "select * from CUSTOMER where CustomerName like @SearchName;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("SearchName", $"%{txtCusSearch.Text.Trim()}%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == true)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dgvCustomerInfo.AutoGenerateColumns = false;
                                dgvCustomerInfo.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("查無此人");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtCusSearch.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入文字");
                txtCusSearch.Focus();
            }
        }

        private void txtCusSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusSearch.Text == string.Empty)
            {
                Show_CustomerInfo_DGV();
            }
        }
        #endregion

        #region Product Management
        private void btnProductMan_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabProuct;
            btnVisibleState(btnPrevious, false);
            btnVisibleState(btnNext, false);
        }

        void Show_ProductInfo_PicMode()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select ProductID, ProductName, Image from PRODUCT";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    listViewProduct.Clear();
                    listViewProduct.View = View.LargeIcon;
                    imageListProduct.ImageSize = new Size(120, 100);
                    listViewProduct.LargeImageList = imageListProduct;

                    int count = 0;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list_pID.Add(reader.GetInt32(0));
                            list_pName.Add(reader.GetString(1));
                            string imageName = reader.GetString(2);
                            string image_WholePath = GlobalVar.image_dir + imageName;
                            Image imgProuct = Image.FromFile(image_WholePath);
                            imageListProduct.Images.Add(imgProuct);

                            ListViewItem item = new ListViewItem();
                            item.ImageIndex = count;
                            item.Font = new Font("標楷體", 12, FontStyle.Regular);
                            item.Text = $"{list_pName[count]}";
                            item.Tag = list_pID[count];

                            listViewProduct.Items.Add(item);
                            count++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void read_Category_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from CATEGORIES;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listCategories.Add(reader["CategoryName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            tempID = 0;
            isProductUpdate = false;
            FrmProductManagement.GetInstance().BtnText("新增");
            FrmProductManagement.GetInstance().tempListCate(listCategories);
            FrmProductManagement.GetInstance().ShowDialog();
        }

        private void cboCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewInit();
            selectedCBOIndex = cboCategorySelect.SelectedIndex + 1;
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select ProductID, ProductName, Image from PRODUCT where CategoryID = @newID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newID", selectedCBOIndex);
                    listViewProduct.Clear();
                    listViewProduct.View = View.LargeIcon;
                    imageListProduct.ImageSize = new Size(120, 100);
                    listViewProduct.LargeImageList = imageListProduct;

                    int count = 0;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list_pID.Add(reader.GetInt32(0));
                            list_pName.Add(reader.GetString(1));
                            string imageName = reader.GetString(2);
                            string image_WholePath = GlobalVar.image_dir + imageName;
                            Image imgProuct = Image.FromFile(image_WholePath);
                            imageListProduct.Images.Add(imgProuct);

                            ListViewItem item = new ListViewItem();
                            item.ImageIndex = count;
                            item.Font = new Font("標楷體", 12, FontStyle.Regular);
                            item.Text = $"{list_pName[count]}";
                            item.Tag = list_pID[count];

                            listViewProduct.Items.Add(item);
                            count++;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void ListViewInit()
        {
            list_pID.Clear();
            list_pName.Clear();
            imageListProduct.Images.Clear();
        }
        #endregion

        #region DGV Controls
        private void dgvEmployeeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow(e.RowIndex);
        }

        private void dgvCustomerInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow(e.RowIndex);
        }

        private void SelectRow(int idxRow)
        {
            if (this.tabControl1.SelectedTab == tabEmployee)
            {
                tempID = (int)dgvEmployeeInfo.Rows[idxRow].Cells["dgv_em_id"].Value;
                FrmEmployeeManagement EmpManagement = FrmEmployeeManagement.GetInstance();
                EmpManagement.tempID(tempID);
                EmpManagement.ShowDialog();
            }
            else if (this.tabControl1.SelectedTab == tabCustomer)
            {
                int dgvCIdColumnIndex = dgvCustomerInfo.Columns["dgv_C_ID"].Index;
                tempID = (int)dgvCustomerInfo.Rows[idxRow].Cells[dgvCIdColumnIndex].Value;
                FrmCustomerManagement CusManagement = FrmCustomerManagement.GetInstance();
                CusManagement.tempID(tempID);
                CusManagement.ShowDialog();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //int totalRecords = GetTotalRecordsCount();
            //int totalPages = (int)Math.Ceiling((double)totalRecords / perPage);
            if (this.tabControl1.SelectedTab == tabEmployee)
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    Show_EmpInfo_DGV();
                }
                else
                {
                    MessageBox.Show("已達最上頁");
                }
            }
            else if (this.tabControl1.SelectedTab == tabCustomer)
            {
                if (currentCUSPage > 1)
                {
                    currentCUSPage--;
                    Show_CustomerInfo_DGV();
                }
                else
                {
                    MessageBox.Show("已達最上頁");
                }
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //int totalRecords = GetTotalRecordsCount();
            //int totalPages = (int)Math.Ceiling((double)totalRecords / perPage);
            if (this.tabControl1.SelectedTab == tabEmployee)
            {
                if (currentPage < totalPages)
                {
                    currentPage++;
                    Show_EmpInfo_DGV();
                }
                else
                {
                    MessageBox.Show("已達最後頁");
                }
            }
            else if (this.tabControl1.SelectedTab == tabCustomer)
            {
                if (currentCUSPage < totalCUSPages)
                {
                    currentCUSPage++;
                    Show_CustomerInfo_DGV();
                }
                else
                {
                    MessageBox.Show("已達最後頁");
                }
            }

        }

        private int GetTotalRecordsCount(string tableName)
        {
            int totalRecords = 0;
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = $"SELECT COUNT(*) FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    //cmd.Connection.Open();
                    totalRecords = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return totalRecords;
        }

        private void listViewProduct_ItemActivate(object sender, EventArgs e)
        {
            int tempID = 0;
            tempID = (int)listViewProduct.SelectedItems[0].Tag;
            isProductUpdate = true;
            FrmProductManagement.GetInstance().tempID(tempID);
            FrmProductManagement.GetInstance().tempListCate(listCategories);
            FrmProductManagement.GetInstance().ShowDialog();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain.GetIntance().ShowDialog();
        }

        private void btnCategoryEdit_Click(object sender, EventArgs e)
        {
            FrmCategoryEdit.GetInstance().ShowDialog();
        }

        #region Button --> Image Management
        /// <summary>
        /// 使用 Dictionary 集中處理 Hover Event 和 Leave Event
        /// </summary>
        private void InitializeButtonImages()
        {
            ButtonImage.Add(btnEmpSearch, (Properties.Resources.icons8_search_40, Properties.Resources.icons8_search_30));
            ButtonImage.Add(btnAddEmp, (Properties.Resources.icons8_add_user_40, Properties.Resources.icons8_add_user_30));
            ButtonImage.Add(btnCusSearch, (Properties.Resources.icons8_search_40, Properties.Resources.icons8_search_30));
            ButtonImage.Add(btnAddCustomer, (Properties.Resources.icons8_add_user_40, Properties.Resources.icons8_add_user_30));
            ButtonImage.Add(btnAddProduct, (Properties.Resources.icons8_add_image_40, Properties.Resources.icons8_add_image_30));

            foreach (var btn in ButtonImage.Keys)
            {
                btn.MouseHover += (sender, e) => { btn.Image = ButtonImage[btn].hoverImage; };
                btn.MouseLeave += (sender, e) => { btn.Image = ButtonImage[btn].leaveImage; };
            }
        }
        // 原有的 Hover Event 和 Leave Event
        private void ChangeButtonImage(object sender, Image image)
        {
            //if (sender is Button button)
            //{
            //    button.Image = image;
            //}
        }
        private void btnEmpSearch_MouseHover(object sender, EventArgs e)
        {
            ChangeButtonImage(sender, Properties.Resources.icons8_search_40);
        }

        private void btnEmpSearch_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonImage(sender, Properties.Resources.icons8_search_30);
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ButtonImage.Clear();
            listCategories.Clear();
            cboCategorySelect.Items.Clear();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            ListViewInit();
            cboCategorySelect.Text = "總類篩選";
            Show_ProductInfo_PicMode();
        }

        private void btnVisibleState(Button btn, bool isVisible)
        {
            btn.Visible = isVisible;
        }
    }
}
