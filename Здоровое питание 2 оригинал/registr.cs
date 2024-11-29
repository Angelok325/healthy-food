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
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoin;
        private void registr_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void registr_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void userSurnamefield_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
                userNameField.Text = "";
            userNameField.ForeColor = Color.Black;
        }

        private void userSurnamefield_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void buttonregester_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя") {


                MessageBox.Show("Введите имя");
                return;
            }


            if (userSurnamefield.Text == "")
            {

                MessageBox.Show("Введите фамилию");
                return;
            }

            if (isuserExists())
                return;

            BD bd = new BD();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);" ,bd.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginfield.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passfield.Text;
            command.Parameters.Add("@namen", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userSurnamefield.Text;


            bd.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            bd.closeConnection();
        }


        public Boolean isuserExists() {
           
            BD db = new BD();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @ul ", db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginfield.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0) 
            { 
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
           
            } 
            
            else
               return false;

        }
        

    }
}
