using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Invento.Invento_Usercontrols
{
    public partial class ucdealer_info : UserControl
    {
        private static ucdealer_info _instance;
        public static ucdealer_info Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucdealer_info();
                return _instance;
            }
        }
        public ucdealer_info()
        {
            InitializeComponent();
            dealerList1.loadData();
            createDealer1.Visible = false;
            dealerList1.Visible = true;
            dealerList1.Dock = DockStyle.Fill;
            dealerList1.BringToFront();         
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");

        private void btndealerList_Click_1(object sender, EventArgs e)
        {
            createDealer1.Visible = false;
            dealerList1.Visible = true;
            dealerList1.loadData();
            dealerList1.Dock = DockStyle.Fill;
            dealerList1.BringToFront();
        }

        private void btnAddDealer_Click_1(object sender, EventArgs e)
        {
            dealerList1.Visible = false;
            createDealer1.Visible = true;
            createDealer1.Dock = DockStyle.Fill;
            createDealer1.BringToFront();
        }

        private void dealerList1_Load(object sender, EventArgs e)
        {

        }

             

    }
}
