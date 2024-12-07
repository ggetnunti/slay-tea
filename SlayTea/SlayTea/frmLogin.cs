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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string con = "Server=np341.database.windows.net;Database=SlayTea_db;User Id=np341;Password=iGetty99;";
        DataSet ds = new DataSet();
        string pin = "";
        public static string username;

        private void CheckPIN()
        {
                switch (pin.Length)
                {
                    case 0: lblPin.Text = "◯  ◯  ◯  ◯  ◯  ◯"; break;
                    case 1: lblPin.Text = "⚫  ◯  ◯  ◯  ◯  ◯"; break;
                    case 2: lblPin.Text = "⚫  ⚫  ◯  ◯  ◯  ◯"; break;
                    case 3: lblPin.Text = "⚫  ⚫  ⚫  ◯  ◯  ◯"; break;
                    case 4: lblPin.Text = "⚫  ⚫  ⚫  ⚫  ◯  ◯"; break;
                    case 5: lblPin.Text = "⚫  ⚫  ⚫  ⚫  ⚫  ◯"; break;
                    case 6: lblPin.Text = "⚫  ⚫  ⚫  ⚫  ⚫  ⚫"; Login(); break;
                    default: ClearPIN(); break;
                }
        }

        private void ClearPIN()
        {
            pin = "";
            CheckPIN();
        }

        private void Login()
        {
            username = cbbUser.Text.Trim();
            string sql = string.Format("SELECT * FROM tb_userLogin WHERE username = '{0}' AND pin ='{1}' ", username, pin);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                frmMain f = new frmMain();
                f.ShowDialog();
                ClearPIN();
            }
            else
            {
                MessageBox.Show("Invalid PIN!");
                ClearPIN();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb_userLogin";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "dtUserLogin");
            cbbUser.DisplayMember = "username";
            cbbUser.DataSource = ds.Tables["dtUserLogin"];
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pin += "0";
            CheckPIN();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pin += "1";
            CheckPIN();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pin += "2";
            CheckPIN();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pin += "3";
            CheckPIN();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pin += "4";
            CheckPIN();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pin += "5";
            CheckPIN();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pin += "6";
            CheckPIN();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pin += "7";
            CheckPIN();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pin += "8";
            CheckPIN();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pin += "9";
            CheckPIN();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (pin.Length > 0)
            {
                pin = pin.Remove(pin.Length - 1, 1);
                CheckPIN();
            }
        }
    }
}
