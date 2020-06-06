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
    public partial class dealerList : UserControl
    {
        public dealerList()
        {
            InitializeComponent();
            loadData();
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");

        void clear()
        {
            txtDealerName.Text = "";
            txtContact.Text = "";
            txtCompanyName.Text = "";
            txtAddress.Text = "";
        }
        public void loadData()
        {
            dataGridViewDealer_Info.Rows.Clear();
            string insertQuery = "SELECT * FROM dealer_info Order by id ";
            DBConnect.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewDealer_Info.Rows.Add();
               
                dataGridViewDealer_Info.Rows[n].Cells[0].Value = item["id"].ToString();
                dataGridViewDealer_Info.Rows[n].Cells[1].Value = (n + 1).ToString();
                dataGridViewDealer_Info.Rows[n].Cells[2].Style.ForeColor = Color.ForestGreen;
                dataGridViewDealer_Info.Rows[n].Cells[2].Value = item["dealer_name"].ToString();
                dataGridViewDealer_Info.Rows[n].Cells[3].Value = item["dealer_company_name"].ToString();
                dataGridViewDealer_Info.Rows[n].Cells[4].Value = item["contact"].ToString();
                dataGridViewDealer_Info.Rows[n].Cells[5].Value = item["address"].ToString();

            }

            DBConnect.Close();

        }
        void fillDataGridViw()
        {
            if (DBConnect.State == ConnectionState.Closed)
            {
                DBConnect.Open();
                MySqlDataAdapter Sda = new MySqlDataAdapter("Select  id,dealer_name,dealer_company_name,contact,address  FROM dealer_info where dealer_name like '%" + SearchTxt.text + "%' order by dealer_name", DBConnect);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                dataGridViewDealer_Info.Rows.Clear();
                foreach (DataRow stock in dt.Rows)
                {
                    int n = dataGridViewDealer_Info.Rows.Add();

                    dataGridViewDealer_Info.Rows[n].Cells[0].Value = stock["id"].ToString();
                    dataGridViewDealer_Info.Rows[n].Cells[1].Value = (n+1).ToString();
                    dataGridViewDealer_Info.Rows[n].Cells[2].Value = stock["dealer_name"].ToString();
                    dataGridViewDealer_Info.Rows[n].Cells[3].Value = stock["dealer_company_name"].ToString();
                    dataGridViewDealer_Info.Rows[n].Cells[4].Value = stock["contact"].ToString();
                    dataGridViewDealer_Info.Rows[n].Cells[5].Value = stock["address"].ToString();

                }

                dataGridViewDealer_Info.ClearSelection();

                DBConnect.Close();
                //dataGridViewItem4Sale.Rows[0].Cells[0].Selected = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridViewDealer_Info.Rows.Count != 0)
            {

                if (MessageBox.Show("Are you Sure you want to update the details of this Dealer?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtDealerName.Text != "" && txtContact.Text != "" || txtCompanyName.Text != "" || txtAddress.Text != "")
                    {
                        
                        string UpdateQuery = "UPDATE dealer_info SET dealer_name='" + txtDealerName.Text + "' ,contact ='" + txtContact.Text + "',dealer_company_name='" + txtCompanyName.Text + "',address='" + txtAddress.Text + "' Where  id='" +txtId.Text + "' ";
                        DBConnect.Open();
                        MySqlCommand command = new MySqlCommand(UpdateQuery, DBConnect);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Dealer Information Updated Succesfully", "Invento Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        txtDealerName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Dealer Information not Updated", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("You can Add Dealers Here!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to delete this product?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtDealerName.Text != "" && txtContact.Text != "" || txtCompanyName.Text != "" || txtAddress.Text != "")
                {
                    DBConnect.Open();
                    string deleteQuery = "DELETE FROM dealer_info where id='" + txtId.Text + "'";

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

        private void dataGridViewDealer_Info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            clear();
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridViewDealer_Info.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDealerName.Text = dataGridViewDealer_Info.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCompanyName.Text = dataGridViewDealer_Info.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddress.Text = dataGridViewDealer_Info.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtContact.Text = dataGridViewDealer_Info.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("No Dealer Exist ", "Invento Alert!");
            }
        }

        private void SearchTxt_OnTextChange(object sender, EventArgs e)
        {
           fillDataGridViw();
        }

      
        private void txtDealerName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDealer_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}
