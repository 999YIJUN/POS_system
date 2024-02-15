using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace POS_system
{
    public partial class FrmMain : Form
    {
        // 定義委派
        //public delegate void ButtonClickHandler(object sender, EventArgs e);
        // 定義事件
        public event EventHandler ButtonClick;
        public event EventHandler FrmMainClosed;

        public int temp_orderID = 0;
        public int temp_ID = 0;
        string image_name = string.Empty;
        public static FrmMain instance;
        public static FrmMain GetIntance()
        {
            if(instance == null)
            {
                instance = new FrmMain();
            }
            return instance;
        }
        private FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                read_Product_DB();
                listViewCreate();
            }

            if(GlobalVar.permission == 1000)
            {
                lblEmp.Text = string.Empty;
                lblCustomer_O.Text = GlobalVar.strName;
                controlEnableState(btnOrderHistory, false);
            }
            else
            {
                lblEmp.Text = GlobalVar.strName;
                controlEnableState(txtCusSearch, false);
            }
            controlEnableState(txtTotalPrice, false);
        }

        void read_Product_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from PRODUCT";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserControlProuct ucProduct = new UserControlProuct();
                            ucProduct.SelectID = (int)reader["ProductID"];
                            ucProduct.lblProductName.Text = reader["ProductName"].ToString();
                            ucProduct.lblPrice.Text = reader["Price"].ToString();
                            image_name = reader["Image"].ToString();
                            string FullName = GlobalVar.image_dir + image_name;
                            ucProduct.pictureBoxProuct.Image = Image.FromFile(FullName);
                            flowLayoutPanel1.Controls.Add(ucProduct);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void listViewCreate()
        {
            listViewOrderDetail.View = View.Details;
            listViewOrderDetail.FullRowSelect = true;
            listViewOrderDetail.GridLines = true;
            //listViewOrderDetail.OwnerDraw = true;
            listViewOrderDetail.CheckBoxes = true;
            listViewOrderDetail.LabelEdit = false;
            listViewOrderDetail.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            listViewOrderDetail.Columns.Add("商品名稱", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("價錢", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("數量", 100).Tag = "visible";
            listViewOrderDetail.Columns.Add("小計", 100).Tag = "visible";


            // 隱藏標記為"hidden"的列
            foreach (ColumnHeader column in listViewOrderDetail.Columns)
            {
                if (column.Tag != null && column.Tag.ToString() == "hidden")
                {
                    column.Width = 0;
                }
            }
        }

        public void tempText(int ID, string Name, string Price, string Numeric, string subTotal)
        {
            ListViewItem item = new ListViewItem(Name);
            item.SubItems.Add(Price);
            item.SubItems.Add(Numeric);
            item.SubItems.Add(subTotal);
            item.Tag = ID;

            listViewOrderDetail.Items.Add(item);
            sum();
        }

        public void tempOrderID(int ID)
        {
            temp_orderID = ID;
            if(temp_orderID > 0)
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "SELECT OD.OrderID, P.ProductName, P.Price, OD.Quantity, OD.Subtotal, O.OrderDate, C.CustomerName, E.EmployeeName FROM ORDERDETAIL as OD INNER JOIN PRODUCT as P ON P.ProductID = OD.ProductID INNER JOIN ORDERS as O ON O.OrderID = OD.OrderID INNER JOIN CUSTOMER as C ON C.CustomerID = O.CustomerID INNER JOIN EMPLOYEE as E ON E.EmployeeID = O.EmployeeID WHERE OD.OrderID = @newID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newID", temp_orderID);

                        string c_name = string.Empty;
                        string e_name = string.Empty;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader.GetString(1));
                                item.SubItems.Add(reader.GetInt32(2).ToString());
                                item.SubItems.Add(reader.GetInt32(3).ToString());
                                item.SubItems.Add(reader.GetInt32(4).ToString());
                                listViewOrderDetail.Items.Add(item);

                                c_name = reader.GetString(6);
                                e_name = reader.GetString(7);
                                sum();
                            }
                        }
                        lblCustomer.Text = c_name;
                        lblCustomer_O.Text = e_name;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        void sum()
        {
            int intSum = 0;
            foreach (ListViewItem item in listViewOrderDetail.Items)
            {
                int item_to_int = 0;
                Int32.TryParse(item.SubItems[3].Text, out item_to_int);
                intSum += item_to_int;
            }
            txtTotalPrice.Text = Convert.ToString(intSum);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if(listViewOrderDetail.Items.Count > 0 && !string.IsNullOrEmpty(lblCustomer.Text))
            {
                Order_Add();
                listViewOrderDetail.Items.Clear();
                temp_ID = 0;
                lblCustomer.Text = string.Empty;
                txtCusSearch.Text = null;
                //ButtonClick?.Invoke(sender, e);
                ButtonClick?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if(listViewOrderDetail.Items.Count == 0)
                {
                    MessageBox.Show("尚未選取商品");
                }
                else
                {
                    MessageBox.Show("尚未輸入會員");
                }
            }
        }

        void Order_Add()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    int newOrderID = 0;
                    con.Open();
                    string strSQL_Order = "INSERT INTO ORDERS (CustomerID, EmployeeID, OrderDate, TotalPrice) VALUES (@newC_ID, @newE_ID, @newDate, @newTotalPrice); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd_Order = new SqlCommand(strSQL_Order, con);
                    cmd_Order.Parameters.AddWithValue("newC_ID", temp_ID);
                    cmd_Order.Parameters.AddWithValue("newE_ID", GlobalVar.intID);
                    cmd_Order.Parameters.AddWithValue("newDate", DateTime.Now.ToString());
                    int intTotalPrice = 0;
                    Int32.TryParse(txtTotalPrice.Text, out intTotalPrice);
                    cmd_Order.Parameters.AddWithValue("newTotalPrice", intTotalPrice);
                    newOrderID = Convert.ToInt32(cmd_Order.ExecuteScalar()); // 取最新插入的 OrderID

                    foreach (ListViewItem item in listViewOrderDetail.Items)
                    {
                        string strSQL_OrderDetail = "INSERT INTO OrderDetail (OrderID, ProductID, Quantity, Subtotal) VALUES (@newOrder, @newProduct, @newQuan, @newSubtotal)";
                        SqlCommand cmd_OrderDetail = new SqlCommand(strSQL_OrderDetail, con);

                        int intProduct = (int)item.Tag;
                        int intQuan = 0;
                        Int32.TryParse(item.SubItems[2].Text, out intQuan);
                        int intSubtotal = 0;
                        Int32.TryParse(item.SubItems[3].Text, out intSubtotal);
                        cmd_OrderDetail.Parameters.AddWithValue("newOrder", newOrderID);
                        cmd_OrderDetail.Parameters.AddWithValue("newProduct", intProduct);
                        cmd_OrderDetail.Parameters.AddWithValue("newQuan", intQuan);
                        cmd_OrderDetail.Parameters.AddWithValue("newSubtotal", intSubtotal);
                        cmd_OrderDetail.ExecuteNonQuery();
                    }
                    MessageBox.Show("訂單新增成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            temp_orderID = 0;
            listViewOrderDetail.Items.Clear();
            lblCustomer.Text = string.Empty;
            lblCustomer_O.Text = string.Empty;
            txtCusSearch.Clear();
            txtTotalPrice.Clear();
            ButtonClick?.Invoke(this, EventArgs.Empty);
            FrmOrderManagement.GetIntance().ShowDialog();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Load_CustomerDB();
        }

        void Load_CustomerDB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select CustomerID, CustomerName from CUSTOMER where ContactNumber = @newContact;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newContact", txtCusSearch.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        temp_ID = reader.GetInt32(0);
                        lblCustomer.Text = reader.GetString(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMainClosed?.Invoke(this, EventArgs.Empty);

            if (listViewOrderDetail.Items.Count > 0)
            {
                if (MessageBox.Show("訂單未完成，要關閉視窗", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    listViewOrderDetail.Items.Clear();
                    txtTotalPrice.Clear();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void controlEnableState(Control control, bool isEnable)
        {
            control.Enabled = isEnable;
        }

        private void DeleteSelectedItems()
        {
            // 使用迴圈遍歷每一個 ListViewItem
            for (int i = listViewOrderDetail.Items.Count-1; i >=0; i--)
            {
                ListViewItem item = listViewOrderDetail.Items[i];

                // 檢查該項是否被勾選
                if (item.Checked)
                {
                    // 如果被勾選，刪除該項
                    listViewOrderDetail.Items.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }
    }
}
