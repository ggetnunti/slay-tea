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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SlayTea
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static int selectedCell = 0;
        public static DataTable orderDetailTable = new DataTable();

        private void CreateOrderDetail()
        {
            orderDetailTable = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("Tea", typeof(String)),
                new DataColumn("Topping", typeof(String)),
                new DataColumn("Ice", typeof(String)),
                new DataColumn("Sugar", typeof(String)),
                new DataColumn("Price", typeof(float)),
                new DataColumn("Discount", typeof(String)),
                new DataColumn("Total", typeof(float)),
            };

            orderDetailTable.Columns.AddRange(cols);
            AddOrderDetail();
        }

        private void ShowChoice(int option)
        {
            gbTea.Visible = false;
            gbTopping.Visible = false;
            gbIce.Visible = false;
            gbSugar.Visible = false;
            gbDiscount.Visible = false;

            switch (option)
            {
                case 0: gbTea.Visible = true; break;
                case 1: gbTopping.Visible = true; break;
                case 2: gbIce.Visible = true; break;
                case 3: gbSugar.Visible = true; break;
                case 4: gbDiscount.Visible = true; break;
                default: break;
            }
        }

        private void AddOrderDetail()
        {
            DataRow row = orderDetailTable.NewRow();
            row["Tea"] = "-";
            row["Topping"] = "-";
            row["Ice"] = "-";
            row["Sugar"] = "-";
            row["Discount"] = "-";
            orderDetailTable.Rows.Add(row);
            selectedCell = orderDetailTable.Rows.Count - 1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateOrderDetail();
            orderGridView.DataSource = orderDetailTable;
            orderGridView.Columns["Price"].Visible = false;
            orderGridView.Columns["Total"].Visible = false;
            foreach (DataGridViewColumn column in orderGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            ShowChoice(0);
        }

        private void btnTopping_Click(object sender, EventArgs e)
        {
            ShowChoice(1);
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            ShowChoice(2);
        }

        private void btnSugar_Click(object sender, EventArgs e)
        {
            ShowChoice(3);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            ShowChoice(4);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrderDetail();
            ShowChoice(0);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows.RemoveAt(selectedCell--);
            if (selectedCell < 0)
            {
                AddOrderDetail();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orderDetailTable.Clear();
            AddOrderDetail();
            ShowChoice(5);
        }

        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < orderDetailTable.Rows.Count && e.RowIndex >= 0)
            {
                selectedCell = e.RowIndex;
                ShowChoice(e.ColumnIndex);
            }
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Milk Tea";
        }

        private void btnThaiTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Thai Tea";
        }

        private void btnMGTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Matcha Green Tea";
        }

        private void btnPeachTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Peach Tea";
        }

        private void btnPFTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Passion Fruit Tea";
        }

        private void btnLemonTea_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Tea"] = "Lemon Tea";
        }

        private void btnNoTopping_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "-";
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "Bubble";
        }

        private void btnPudding_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "Pudding";
        }

        private void btnPopPearl_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "Pop Pearl";
        }

        private void btnCoconutJelly_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "Coconut Jelly";
        }

        private void btnCreamCheese_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Topping"] = "Cream Cheese";
        }

        private void btnNoIce_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Ice"] = "-";
        }

        private void btnHaftIce_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Ice"] = "Haft Ice";
        }

        private void btnFullIce_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Ice"] = "Full Ice";
        }

        private void btnNoSugar_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Sugar"] = "-";
        }

        private void btn25Sugar_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Sugar"] = "25%";
        }

        private void btn50Sugar_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Sugar"] = "50%";
        }

        private void btn75Sugar_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Sugar"] = "75%";
        }

        private void btn100Sugar_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Sugar"] = "100%";
        }

        private void btnNoDiscount_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Discount"] = "-";
        }

        private void btn10Discount_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Discount"] = "10%";
        }

        private void btn30Discount_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Discount"] = "30%";
        }

        private void btn50Discount_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Discount"] = "50%";
        }

        private void btn100Discount_Click(object sender, EventArgs e)
        {
            orderDetailTable.Rows[selectedCell]["Discount"] = "100%";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmConfirm f = new frmConfirm();
            f.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            frmRecord f = new frmRecord();
            f.ShowDialog();
        }
    }
}
