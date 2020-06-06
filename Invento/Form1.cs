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
namespace Invento
{
    public partial class Form1 : Form
    {

       MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void DBConnection()
        {
            string ConnectString = "datasource =localhost; username = root; password =; database = invento";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);
            try
            {
                DBConnect.Open();
                MessageBox.Show("You are connected");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            DBConnection();
            //this.Hide();
            //Mainmenu Main = new Mainmenu();
            //Main.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool MousePointerNotOnTaskBAr = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "invento has been minimized to sytem tray";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
           

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string passwordInit = txtPassword.Text;
            string passwordConf = txtPassordConf.Text;
            if (txtPassword.Text == txtPassordConf.Text)
            {
                string insertQuery = "INSERT INTO login(emailaddress,password) VALUES ('" + txtEmail.Text + "','" + txtPassordConf.Text + "')";
                DBConnect.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, DBConnect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }
                DBConnect.Close();
            }
            else
            {
                MessageBox.Show("password does not match");
            }
            
        }

        private void labelSignin_Click(object sender, EventArgs e)
        {
            panelSigin.Show();         
        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            panelSigin.Hide();
            panelSIgup.Show();
           // panelSIgup.BringToFront();        
        }

        private void BtnSigin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainmenu menu = new Mainmenu();
            menu.Show();


            //if (txtEmail.Text != "" || txtPassSigin.Text != "")
            //{
            //    string insertQuery = "INSERT INTO login(emailaddress,password) VALUES ('" + txtEmail.Text + "','" + txtPassordConf.Text + "')";
            //    DBConnect.Open();
            //    MySqlCommand command = new MySqlCommand(insertQuery, DBConnect);
            //    if (command.ExecuteNonQuery() == 1)
            //    {
            //        MessageBox.Show("Data Inserted");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data not Inserted");
            //    }
            //    DBConnect.Close();
            //}
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            //else if (WindowState == FormWindowState.Maximized)
            //{
            //    WindowState = FormWindowState.Normal;

            //}
        }

     

      
     

       

        

       

        
    }
}
