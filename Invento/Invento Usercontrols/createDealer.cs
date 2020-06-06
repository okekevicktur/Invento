using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Invento.Invento_Usercontrols
{
    public partial class createDealer : UserControl
    {
        public createDealer()
        {
            InitializeComponent();
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");

        void clear()
        {
            txtDealerName.Text = "";
            txtContact.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
        }
        void loaDData()
        {
            dealerList dealer = new dealerList();
            dealer.loadData();
        }
        private void btnAddDealer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure the details of this Dealer is Correct ?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtDealerName.Text != "" && txtContact.Text != "" || txtCompanyName.Text != "")
                {
                    string insertQuery = "INSERT INTO dealer_info (dealer_name,contact,dealer_company_name,address) VALUES ('" + txtDealerName.Text + "','" + txtContact.Text + "','" + txtCompanyName.Text + "','" + txtAddress.Text + "')";
                    DBConnect.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, DBConnect);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Dealer Succesfully Created");
                        loaDData();
                    }
                    else
                    {
                        MessageBox.Show("Seems your data is incomplete");

                    }
                    DBConnect.Close();
                    clear();
                    txtDealerName.Focus();
                }
                else
                {

                    MessageBox.Show("Incomplete details", "Invento Alert!");
                    txtDealerName.Select();
                }
            }
            else
            {
                MessageBox.Show("Dealer not Created", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
