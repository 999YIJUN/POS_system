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
    public partial class FrmOrderManagement : Form
    {
        
        public static FrmOrderManagement instance;
        public static FrmOrderManagement GetIntance()
        {
            if(instance == null)
            {
                instance = new FrmOrderManagement();
            }
            return instance;
        }

        private FrmOrderManagement()
        {
            InitializeComponent();
        }

        private void FrmOrderManagement_Load(object sender, EventArgs e)
        {
            read_Orders_DB();
        }

        void read_Orders_DB()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = "select * from ORDERS as O inner join CUSTOMER as C on C.CustomerID = O.CustomerID inner join EMPLOYEE as E on E.EmployeeID = O.EmployeeID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvOrderInfo.AutoGenerateColumns = false;
                            dgvOrderInfo.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvOrderInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvOrderInfo.Rows[e.RowIndex];
                int orderID =  Convert.ToInt32(selectedRow.Cells[0].Value);

                FrmMain.GetIntance().tempOrderID(orderID);

                this.Close();
            }
        }
    }
}
