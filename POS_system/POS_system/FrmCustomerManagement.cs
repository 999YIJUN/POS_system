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

namespace POS_system
{
    public partial class FrmCustomerManagement : Form
    {
        int selectID = 0;
        bool isClick = false;
        public event EventHandler CustomerManagementClosed;

        public static FrmCustomerManagement instance;
        public static FrmCustomerManagement GetInstance()
        {
            if(instance == null)
            {
                instance = new FrmCustomerManagement();
            }
            return instance;
        }
        private FrmCustomerManagement()
        {
            InitializeComponent();
        }

        private void FrmCustomerManagement_Load(object sender, EventArgs e)
        {
            if (selectID > 0)
            {
                read_Cus_DB();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "儲存修改")
            {
                Customer_Save();
            }
            else
            {
                Customer_Add();
            }
        }

        public void tempID(int id)
        {
            selectID = id;
        }

        public void tempbtnName(string strBtn)
        {
            btnSave.Text = strBtn;
        }

        void read_Cus_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select CustomerName, Email, ContactNumber, Address, BDay from CUSTOMER where CustomerID = @newID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newID", selectID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCusName.Text = reader.GetString(0);
                            txtEmail.Text = reader.GetString(1);
                            txtContactNum.Text = reader.GetString(2);
                            txtAddress.Text = reader.GetString(3);
                            dtpBDay.Value = reader.GetDateTime(4);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Customer_Add()
        {
            if (checkField())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "insert into CUSTOMER values(@newName, @newEmail, @newContact, @newAddress, @newBDay);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtCusName.Text.Trim());
                        cmd.Parameters.AddWithValue("newEmail", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("newContact", txtContactNum.Text.Trim());
                        cmd.Parameters.AddWithValue("newAddress", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("newBDay", dtpBDay.Value);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("新增成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        isClick = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("資料輸入不完成或有誤");
            }  
        }

        bool checkField()
        {
            DateTime dateMin = new DateTime(1960, 1, 1, 0, 0, 0);
            DateTime dateMax = new DateTime(2015, 1, 1, 0, 0, 0);
            if (string.IsNullOrWhiteSpace(txtContactNum.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContactNum.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || dtpBDay.Value < dateMin || dtpBDay.Value >= dateMax)
            {
                return false;
            }
            return true;
        }

        void Customer_Save()
        {
            if (selectID > 0 && checkField())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "update CUSTOMER set CustomerName = @newName, Email = @newEmail, ContactNumber = @newContact, Address = @newAddress, BDay = @newBDay where CustomerID = @newID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtCusName.Text.Trim());
                        cmd.Parameters.AddWithValue("newEmail", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("newContact", txtContactNum.Text.Trim());
                        cmd.Parameters.AddWithValue("newAddress", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("newBDay", dtpBDay.Value);
                        cmd.Parameters.AddWithValue("newID", selectID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("修改儲存成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        isClick = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("欄位填寫有誤");
            }
        }

        private void FrmCustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClick)
            {
                if (MessageBox.Show("是否繼續操作", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    ClearAllInfo();
                }
            }
            else
            {
                if (MessageBox.Show("資料未儲存或新增未完成,是否關閉頁面?", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClearAllInfo();
                }
                else
                {
                    e.Cancel = true;
                }
            }

            CustomerManagementClosed?.Invoke(this, EventArgs.Empty);
        }

        void ClearAllInfo()
        {
            selectID = 0;
            txtCusName.Clear();
            txtEmail.Clear();
            txtContactNum.Clear();
            txtAddress.Clear();
            dtpBDay.Value = DateTime.Now;
            isClick = false;
            btnSave.Text = "儲存修改";
        }
    }
}
