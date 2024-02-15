using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class FrmEmployeeManagement : Form
    {
        public int selectID = 0;
        bool isClick = false;

        public event EventHandler EmployeeManagementClosed;

        public static FrmEmployeeManagement instance;
        public static FrmEmployeeManagement GetInstance()
        {
            if(instance == null)
            {
                instance = new FrmEmployeeManagement();
            }
            return instance;
        }
        private FrmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void FrmEmployeeManagement_Load(object sender, EventArgs e)
        {
            if(selectID > 0)
            {
                read_Emp_DB();
            }
        }

        public void tempID(int id)
        {
            selectID = id;
        }

        public void tempbtnName(string txt)
        {
            btnSave.Text = txt;
        }
        
        void read_Emp_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from EMPLOYEE where EmployeeID = @newID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newID", selectID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblEmpID.Text = reader.GetInt32(0).ToString();
                            txtEmpName.Text = reader.GetString(1);
                            txtPassword.Text = reader.GetString(2);
                            txtContactNum.Text = reader.GetString(3);
                            txtAddress.Text = reader.GetString(4);
                            dtpBDay.Value = reader.GetDateTime(5);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "儲存修改")
            {
                Employee_Save();
            }
            else
            {
                Employee_Add();
            }
        }

        void Employee_Save()
        {
            if (selectID > 0 && CheckFiled())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "update EMPLOYEE set EmployeeName = @newName, e_password = @newPassword, ContactNumber = @newContact, Address = @newAddress, BDay = @newBDay where EmployeeID = @newID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtEmpName.Text.Trim());
                        cmd.Parameters.AddWithValue("newPassword", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("newContact", txtContactNum.Text.Trim());
                        cmd.Parameters.AddWithValue("newAddress", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("newBDay", dtpBDay.Value);
                        cmd.Parameters.AddWithValue("newID", selectID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"資料成功修改並儲存");
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

        void Employee_Add()
        {
            if (CheckFiled())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "insert into EMPLOYEE values(@newName, @newPassword, @newContact, @newAddress, @BDay);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtEmpName.Text.Trim());
                        cmd.Parameters.AddWithValue("newPassword", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("newContact", txtContactNum.Text.Trim());
                        cmd.Parameters.AddWithValue("newAddress", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("BDay", dtpBDay.Value);
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

        bool CheckFiled()
        {
            DateTime dateMin = new DateTime(1960, 1, 1, 0, 0, 0);
            DateTime dateMax = new DateTime(2015, 1, 1, 0, 0, 0);
            if(string.IsNullOrWhiteSpace(txtContactNum.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtContactNum.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || dtpBDay.Value < dateMin || dtpBDay.Value >= dateMax)
            {
                return false;
            }

            return true;
        }

        private void FrmEmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
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
                if (MessageBox.Show("資料儲存或新增未完成,是否關閉頁面?", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClearAllInfo();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            EmployeeManagementClosed?.Invoke(this, EventArgs.Empty);
        }

        void ClearAllInfo()
        {
            selectID = 0;
            lblEmpID.Text = "00000";
            txtEmpName.Clear();
            txtPassword.Clear();
            txtContactNum.Clear();
            txtAddress.Clear();
            dtpBDay.Value = DateTime.Now;
            isClick = false;
            btnSave.Text = "儲存修改";
        }
    }
}
