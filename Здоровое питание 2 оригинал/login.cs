using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Здоровое_питание_2_оригинал
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.passfield.AutoSize = false;
            this.passfield.Size = new Size(this.passfield.Size.Width, 78);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Gray;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Wheat;
        }

        Point lastPoin;
        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginfield.Text;
            String passUser = passfield.Text;


            BD db = new BD();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @ul AND  'pass' = @up", db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");

        }

        private void registrlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registr registrForm = new registr();
            registrForm.Show();
        }
    }
}
