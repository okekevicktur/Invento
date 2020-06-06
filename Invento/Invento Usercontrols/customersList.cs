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
    public partial class customersList : UserControl
    {
        public customersList()
        {
            InitializeComponent();
            loadData();
        }


        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");

        void clear()
        {
            txtCustomerName.Text = "";
            txtContact.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
        }
        public void loadData()
        {
            dataGridViewCustomer_Info.Rows.Clear();
            string insertQuery = "SELECT * FROM customer_info Order by id ";
            DBConnect.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewCustomer_Info.Rows.Add();

                dataGridViewCustomer_Info.Rows[n].Cells[0].Value = item["id"].ToString();
                dataGridViewCustomer_Info.Rows[n].Cells[1].Value = (n + 1).ToString();
                dataGridViewCustomer_Info.Rows[n].Cells[2].Style.ForeColor = Color.ForestGreen;
                dataGridViewCustomer_Info.Rows[n].Cells[2].Value = item["customer_name"].ToString();
                dataGridViewCustomer_Info.Rows[n].Cells[3].Value = item["customer_company_name"].ToString();
                dataGridViewCustomer_Info.Rows[n].Cells[4].Value = item["contact"].ToString();
                dataGridViewCustomer_Info.Rows[n].Cells[5].Value = item["address"].ToString();

            }

            DBConnect.Close();

        }
        void fillDataGridViw()
        {
            if (DBConnect.State == ConnectionState.Closed)
            {
                DBConnect.Open();
                MySqlDataAdapter Sda = new MySqlDataAdapter("Select  id,customer_name,customer_company_name,contact,address  FROM customer_info where customer_name like '%" + SearchTxt.text + "%' order by customer_name", DBConnect);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                dataGridViewCustomer_Info.Rows.Clear();
                foreach (DataRow stock in dt.Rows)
                {
                    int n = dataGridViewCustomer_Info.Rows.Add();

                    dataGridViewCustomer_Info.Rows[n].Cells[0].Value = stock["id"].ToString();
                    dataGridViewCustomer_Info.Rows[n].Cells[1].Value = (n + 1).ToString();
                    dataGridViewCustomer_Info.Rows[n].Cells[2].Value = stock["customer_name"].ToString();
                    dataGridViewCustomer_Info.Rows[n].Cells[3].Value = stock["customer_company_name"].ToString();
                    dataGridViewCustomer_Info.Rows[n].Cells[4].Value = stock["contact"].ToString();
                    dataGridViewCustomer_Info.Rows[n].Cells[5].Value = stock["address"].ToString();

                }

                dataGridViewCustomer_Info.ClearSelection();

                DBConnect.Close();
                //dataGridViewItem4Sale.Rows[0].Cells[0].Selected = false;
            }
        }

        private void SearchTxt_OnTextChange(object sender, EventArgs e)
        {
            fillDataGridViw();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer_Info.Rows.Count != 0)
            {

                if (MessageBox.Show("Are you Sure you want to update the details of this Dealer?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtCustomerName.Text != "" && txtContact.Text != "" || txtCompanyName.Text != "" || txtAddress.Text != "")
                    {

                        string UpdateQuery = "UPDATE dealer_info SET dealer_name='" + txtCustomerName.Text + "' ,contact ='" + txtContact.Text + "',dealer_company_name='" + txtCompanyName.Text + "',address='" + txtAddress.Text + "' Where  id='" + txtId.Text + "' ";
                        DBConnect.Open();
                        MySqlCommand command = new MySqlCommand(UpdateQuery, DBConnect);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Customer Information Updated Succesfully", "Invento Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seems your data is Corrupted");
                        }
                        DBConnect.Close();
                        groupBox1.Enabled = false;
                        clear();

                        loadData();
                        DBConnect.Close();
                    }
                    else
                    {

                        MessageBox.Show("Incomplete details", "Invento Alert!");
                        txtCustomerName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Dealer Information not Updated", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("You can Add Customers Here!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to delete this product?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtCustomerName.Text != "" && txtContact.Text != "" || txtCompanyName.Text != "" || txtAddress.Text != "")
                {
                    DBConnect.Open();
                    string deleteQuery = "DELETE FROM customer_info where id='" + txtId.Text + "'";

                    MySqlCommand command = new MySqlCommand(deleteQuery, DBConnect);
                    DataTable dt = new DataTable();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Item Deleted Succesfully ", "Invento Alert");
                    }
                    else
                    {
                        MessageBox.Show("Data is  Corrupted", "Invento Alert");
                    }
                    DBConnect.Close();
                    groupBox1.Enabled = false;
                    clear();
                    loadData();
                }

                else
                {
                    MessageBox.Show("Incomplete Data Entry", "Invento Alert");
                }
            }
            else
            {
                MessageBox.Show("Product not Deleted", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }


    }

}
