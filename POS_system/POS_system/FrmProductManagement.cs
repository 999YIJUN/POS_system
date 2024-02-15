using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class FrmProductManagement : Form
    {
        int selectID = 0;
        string image_name = string.Empty;
        List<string> ListCategory = new List<string>();
        bool isPicChange = false;
        int CateNum = 0;
        public event EventHandler ProductManagementClosed;
        public static FrmProductManagement instance;
        public static FrmProductManagement GetInstance()
        {
            if(instance == null)
            {
                instance = new FrmProductManagement();
            }
            return instance;
        }
        private FrmProductManagement()
        {
            InitializeComponent();
        }

        private void FrmProductManagement_Load(object sender, EventArgs e)
        {
            read_Product_DB();

            foreach (var item in ListCategory)
            {
                cboCategory.Items.Add(item);
            }

            CateNum = cboCategory.FindStringExact(cboCategory.Text) + 1;
        }

        public void tempID(int id)
        {
            selectID = id;
        }

        public void tempListCate(List<string> category)
        {
            ListCategory = category;
        }

        public void BtnText(string strBtn)
        {
            btnSave.Text = strBtn;
        }

        void read_Product_DB()
        {
            if(selectID > 0)
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "SELECT  p.ProductID, p.ProductName, p.Unit, p.Price, p.Image, p.Description, c.CategoryName FROM PRODUCT as p INNER JOIN CATEGORIES as c ON p.CategoryID = c.CategoryID where p.ProductID = @newID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newID", selectID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtPName.Text = reader.GetString(1);
                                txtUnit.Text = reader.GetInt32(2).ToString();
                                txtPrice.Text = reader.GetInt32(3).ToString();
                                image_name = reader.GetString(4);
                                string FullPath = GlobalVar.image_dir + image_name;
                                pictureBoxProductPic.Image = Image.FromFile(FullPath);
                                txtDesc.Text = reader.GetString(5);
                                cboCategory.Text = reader.GetString(6);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void FrmProductManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductManagementClosed?.Invoke(this, EventArgs.Empty);

            ClearRecord();
        }

        void ClearRecord()
        {
            selectID = 0;
            txtPName.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
            cboCategory.Items.Clear();
            cboCategory.Text = string.Empty;
            pictureBoxProductPic.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "儲存")
            {
                Product_Save();
            }
            else
            {
                Product_Add();
            }
        }

        void Product_Save()
        {
            if (isPicChange)
            {
                pictureBoxProductPic.Image.Save(GlobalVar.image_dir + image_name);
                isPicChange = false;
            }
            if (check_Info())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "UPDATE PRODUCT SET ProductName = @newName, Unit = @newUnit, Price= @newPrice,  Image = @newImage, Description = @newDesc, CategoryID = @new_C_ID FROM PRODUCT WHERE ProductID = @newID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtPName.Text.Trim());
                        int intUnit;
                        if (Int32.TryParse(txtUnit.Text.Trim(), out intUnit))
                        {
                            cmd.Parameters.AddWithValue("@newUnit", intUnit);
                        }
                        else
                        {
                            MessageBox.Show("請輸入有效的數字作為單位。");
                            return;
                        }
                        int intPrice = 0;
                        if (Int32.TryParse(txtPrice.Text.Trim(), out intPrice))
                        {
                            cmd.Parameters.AddWithValue("newPrice", intPrice);
                        }
                        else
                        {
                            MessageBox.Show("請輸入有效的數字作為單位。");
                            return;
                        }
                        cmd.Parameters.AddWithValue("newImage", image_name);
                        cmd.Parameters.AddWithValue("newDesc", txtDesc.Text.Trim());
                        cmd.Parameters.AddWithValue("new_C_ID", CateNum);
                        cmd.Parameters.AddWithValue("newID", selectID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        void Product_Add()
        {
            if (isPicChange)
            {
                pictureBoxProductPic.Image.Save(GlobalVar.image_dir + image_name);
                isPicChange = false;
            }
            if(check_Info())
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "insert into PRODUCT values (@newName, @newUnit, @newPrice, @newImage, @newCategory, @newDesc)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("newName", txtPName.Text.Trim());
                        int intUnit = 0;
                        if (Int32.TryParse(txtUnit.Text.Trim(), out intUnit))
                        {
                            cmd.Parameters.AddWithValue("newUnit", intUnit);
                        }
                        else
                        {
                            MessageBox.Show("請輸入有效的數字作為單位。");
                            return;
                        }
                        int intPrice = 0;
                        if (Int32.TryParse(txtPrice.Text.Trim(), out intPrice))
                        {
                            cmd.Parameters.AddWithValue("newPrice", intPrice);
                        }
                        else
                        {
                            MessageBox.Show("請輸入有效的數字作為單位。");
                            return;
                        }
                        cmd.Parameters.AddWithValue("newImage", image_name);
                        cmd.Parameters.AddWithValue("newCategory", CateNum);
                        cmd.Parameters.AddWithValue("newDesc", txtDesc.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("新增成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("資料填寫未完成");
            }
        }

        bool check_Info()
        {
            if(string.IsNullOrWhiteSpace(txtPName.Text) || string.IsNullOrWhiteSpace(txtUnit.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtDesc.Text) || pictureBoxProductPic.Image == null)
            {
                return false;
            }

            return true;
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            F.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            DialogResult R = F.ShowDialog();

            if(R == DialogResult.OK)
            {
                pictureBoxProductPic.Image = Image.FromFile(F.FileName); // 完整路徑
                // F.SafeFileName 檔名
                string FileExtension = Path.GetExtension(F.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + FileExtension;
                isPicChange = true;
                Console.WriteLine(image_name);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CateNum = cboCategory.FindStringExact(cboCategory.Text) + 1;
        }
    }
}
