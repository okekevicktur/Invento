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
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
            loadData();
        }
        public string itemNm;
        public string Description;
        public string NumberOfItems;
        public string Price;

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");
       
        public void loadData()
        {
            dataGridViewProducts.Rows.Clear();
            string insertQuery = "Select * from stock Order by id ";
            DBConnect.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewProducts.Rows.Add();

                dataGridViewProducts.Rows[n].Cells[0].Value = item["id"].ToString();
                dataGridViewProducts.Rows[n].Cells[1].Value = (n+1).ToString();
                dataGridViewProducts.Rows[n].Cells[2].Style.ForeColor = Color.ForestGreen;
                dataGridViewProducts.Rows[n].Cells[2].Value = item["itemName"].ToString();
                dataGridViewProducts.Rows[n].Cells[3].Value = item["itemDescription"].ToString();
                dataGridViewProducts.Rows[n].Cells[4].Value = item["itemPrice"].ToString();
                dataGridViewProducts.Rows[n].Cells[5].Value = item["noOfItem"].ToString();

            }

            DBConnect.Close();
        }
        void clear()
        {
            
            txtId.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }
        void fillDataGridViw()
        {
            if (DBConnect.State == ConnectionState.Closed)
            {
                DBConnect.Open();
                MySqlDataAdapter Sda = new MySqlDataAdapter("Select id, itemDescription, itemName, itemPrice,noOfItem  from stock where itemName like '%" + SearchTxt.text + "%' order by id", DBConnect);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                dataGridViewProducts.Rows.Clear();
                foreach (DataRow stock in dt.Rows)
                {
                    int n = dataGridViewProducts.Rows.Add();

                    dataGridViewProducts.Rows[n].Cells[1].Value = (n + 1).ToString();
                    dataGridViewProducts.Rows[n].Cells[2].Value = stock["itemName"].ToString();
                    dataGridViewProducts.Rows[n].Cells[3].Value = stock["itemDescription"].ToString();
                    dataGridViewProducts.Rows[n].Cells[4].Value = stock["itemPrice"].ToString();
                    dataGridViewProducts.Rows[n].Cells[5].Value = stock["noOfItem"].ToString();

                }

                dataGridViewProducts.ClearSelection();

                DBConnect.Close();
                //dataGridViewItem4Sale.Rows[0].Cells[0].Selected = false;
            }
        }
        private void ItemList_Load(object sender, EventArgs e)
        {
            loadData();
        }             

        private void SearchTxt_OnTextChange(object sender, EventArgs e)
        {
            fillDataGridViw();       
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {              
                clear();
               if(e.RowIndex >= 0)
                 {
                    txtId.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtName.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDescription.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtPrice.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtQuantity.Text = dataGridViewProducts.Rows[e.RowIndex].Cells[5].Value.ToString();        
                 }
                else
                {
                    MessageBox.Show("No Products Exist ", "Invento Alert!");
                }
                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to update the details of this product?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtName.Text != "" && txtPrice.Text != "")
                {
                    string UpdateQuery = "Update stock set itemName='" + txtName.Text + "' ,itemDescription ='" + txtDescription.Text + "',noOfItem='" + txtQuantity.Text + "',itemPrice='" + txtPrice.Text + "' Where  id='" + txtId.Text + "' ";
                    DBConnect.Open();
                    MySqlCommand command = new MySqlCommand(UpdateQuery, DBConnect);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Item Updated Succesfully", "Invento Update");
                    }
                    else
                    {
                        MessageBox.Show("Seems your data is Corrupted");
                    }
                    DBConnect.Close();
                    groupBox1.Enabled = false;
                    clear();

                    loadData();
                }
                else
                {

                    MessageBox.Show("Incomplete details", "Invento Alert!");
                    txtName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Product not Updated", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to delete this product?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtName.Text != "" && txtPrice.Text != "")
                {
                    DBConnect.Open();
                    string deleteQuery = "DELETE FROM stock where id='" + txtId.Text + "'";

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
