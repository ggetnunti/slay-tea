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
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void GetOrderDetail()
        {
            if (ds.Tables.Contains("Join"))
                ds.Tables.Remove("Join");

            string sql = "SELECT * FROM v_orderDetail ";
            sql += "WHERE Number LIKE '%" + txtSearch.Text + "%' ";
            sql += "AND Tea LIKE '%" + cbbTea.Text + "%' ";
            sql += "AND Topping LIKE '%" + cbbTopping.Text + "%' ";
            sql += "AND Ice LIKE '%" + cbbIce.Text + "%' ";
            sql += "AND Sugar LIKE '%" + cbbSugar.Text + "%' ";
            sql += "AND [Dis.] LIKE '%" + cbbDiscount.Text + "%' ";
            sql += "AND [sold by] LIKE '%" + cbbSoldBy.Text + "%' ";
            sql += "AND [Date and Time] between '" + dtpDateSearch.Value.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dtpDateSearch.Value.ToString("yyyy-MM-dd") + " 23:59:00'";
            SqlDataAdapter da = new SqlDataAdapter(sql, frmLogin.con);
            da.Fill(ds, "Join");

            orderGridView.DataSource = ds.Tables["Join"];
            GetTotal();
        }

        private void GetTotal() 
        {
            decimal total = 0;
            foreach (DataGridViewRow row in orderGridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells[orderGridView.Columns["Total"].Index].Value);
            }
            lblSum.Text = "Total : " + total.ToString("#.##");
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            GetOrderDetail();
            string sql = "SELECT * FROM tb_userLogin";
            SqlDataAdapter da = new SqlDataAdapter(sql, frmLogin.con);
            da.Fill(ds, "dtUserLogin");
            cbbSoldBy.DisplayMember = "username";
            cbbSoldBy.DataSource = ds.Tables["dtUserLogin"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetOrderDetail();
        }
    }
}
