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

namespace SlayTea
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        DataTable confirmOrderDetail = new DataTable();
        DataSet ds = new DataSet();

        private void UpdateDB(DataTable dt)
        {
            string sql = "SELECT * FROM tb_orderDetail";
            SqlDataAdapter da = new SqlDataAdapter(sql, frmLogin.con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        private void Calculation()
        {
            double teaPrice = 0, toppingPrice = 0, price =0, discount = 0, total = 0, sumTotal = 0;

            for (int i = 0; i < confirmOrderDetail.Rows.Count; i++)
            {
                if (confirmOrderDetail.Rows[i]["Tea"] == "-")
                {
                    confirmOrderDetail.Rows[i].Delete();
                    i -= 1;
                }
            }

            foreach (DataRow row in confirmOrderDetail.Rows) {
                //Tea price calculation
                switch (row["Tea"])
                {
                    case "Milk Tea":
                        teaPrice = 3.5; break;
                    case "Thai Tea":
                        teaPrice = 4; break;
                    case "Matcha Green Tea":
                        teaPrice = 4; break;
                    case "Peach Tea":
                        teaPrice = 3; break;
                    case "Passion Fruit Tea":
                        teaPrice = 3; break;
                    case "Lemon Tea":
                        teaPrice = 3; break;
                    default:
                        break;
                }
                //Topping price calculation
                switch (row["Topping"])
                {
                    case "-":
                        toppingPrice = 0; break;
                    case "Bubble":
                        toppingPrice = 0.5; break;
                    case "Pudding":
                        toppingPrice = 1; break;
                    case "Pop Pearl":
                        toppingPrice = 0.75; break;
                    case "Coconut Jelly":
                        toppingPrice = 0.25; break;
                    case "Cream Cheese":
                        toppingPrice = 0.5; break;
                    default:
                        break;
                }
                price = teaPrice + toppingPrice;
                //Discount Caculation
                switch (row["Discount"])
                {
                    case "-":
                        discount = 0; break;
                    case "10%":
                        discount = price * 0.1; break;
                    case "30%":
                        discount = price * 0.3; break;
                    case "50%":
                        discount = price * 0.5; break;
                    case "100%":
                        discount = price; break;
                    default:
                        break;
                }
                total = price - discount;
                row["Price"] = price;
                row["Total"] = total;
                sumTotal += total;
            }
            lblTotal.Text = "Total : " + sumTotal.ToString();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            confirmOrderDetail = frmMain.orderDetailTable;
            Calculation();
            orderGridView.DataSource = confirmOrderDetail;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //get table order detail
            string sql = "SELECT * FROM tb_orderDetail";
            SqlDataAdapter da = new SqlDataAdapter(sql, frmLogin.con);
            da.Fill(ds, "dtOrderDetail");

            //get last order number
            sql = "SELECT MAX(orderNumber) FROM tb_orderDetail";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, frmLogin.con);
            da.Fill(dt);

            foreach (DataRow row in confirmOrderDetail.Rows)
            {
                DataRow dr = ds.Tables["dtOrderDetail"].NewRow();
                dr["orderNumber"] = Convert.ToInt32(dt.Rows[0][0]) + 1;
                dr["tea"] = row["Tea"];
                dr["topping"] = row["Topping"];
                dr["ice"] = row["Ice"];
                dr["sugar"] = row["Sugar"];
                dr["discount"] = row["Discount"];
                dr["price"] = row["Price"];
                dr["total"] = row["Total"];
                dr["datetimes"] = DateTime.Now;
                dr["soldBy"] = frmLogin.username;
                ds.Tables["dtOrderDetail"].Rows.Add(dr);
            }

            UpdateDB(ds.Tables["dtOrderDetail"]);

            DialogResult res = MessageBox.Show("This order is confirmed", "Succeed!");
            if (res == DialogResult.OK)
            {
                frmMain.orderDetailTable.Clear();
                DataRow row = frmMain.orderDetailTable.NewRow();
                row["Tea"] = "-";
                row["Topping"] = "-";
                row["Ice"] = "-";
                row["Sugar"] = "-";
                row["Discount"] = "-";
                frmMain.orderDetailTable.Rows.Add(row);
                frmMain.selectedCell = 0;
                this.Close();
            }
        }
    }
}
