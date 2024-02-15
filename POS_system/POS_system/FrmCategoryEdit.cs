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
    public partial class FrmCategoryEdit : Form
    {
        int selectID = 0;
        public static FrmCategoryEdit instance;
        public static FrmCategoryEdit GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmCategoryEdit();
            }
            return instance;
        }
        private FrmCategoryEdit()
        {
            InitializeComponent();
        }

        private void FrmCategoryEdit_Load(object sender, EventArgs e)
        {
            Load_Category_DB();
        }

        void Load_Category_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from CATEGORIES;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string str = string.Empty;
                        while (reader.Read())
                        {
                            listBoxCategory.Tag = reader.GetInt32(0);
                            listBoxCategory.Items.Add(reader.GetString(1));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAddCategory.Text))
            {
                Update_Category();
                ClearListBox();
                Load_Category_DB();
                //Add_Category();
            }
            else
            {
                MessageBox.Show("請輸入文字");
            }
        }

        void Add_Category()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "insert into CATEGORIES(CategoryName) values(@newName);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newName", txtAddCategory.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("新增成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Update_Category()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "update CATEGORIES set CategoryName = @newName where CategoryID = @newID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("newName", txtAddCategory.Text.Trim());
                    cmd.Parameters.AddWithValue("newID", selectID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("更新成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Delete_Category()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "delete from CATEGORIES where CategoryID = @newID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    //cmd.Parameters.AddWithValue("newID", );
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectID = (int)listBoxCategory.Tag;
            txtAddCategory.Text = listBoxCategory.SelectedItem.ToString();
        }

        void ClearListBox()
        {
            listBoxCategory.Items.Clear();
            txtAddCategory.Clear();
        }
    }
}
