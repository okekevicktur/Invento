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
    public partial class ucHome : UserControl
    {
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHome();
                return _instance;
            }
        }
        public ucHome()
        {
            InitializeComponent();
            loadData();
        }
        private void ucHome_Load(object sender, EventArgs e)
        {
            loadData();
            dataGridViewItem4Sale.Focus();
        }
        public string itemNm;
        public string Description;
        public string NumberOfItems;
        public string Price;
        public string itemNumber;
        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");
        DataTable dtG = new DataTable();

        public void loadData()
        {
            dataGridViewItem4Sale.Rows.Clear();
            string insertQuery = "Select * from stock Order by id ";
            DBConnect.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewItem4Sale.Rows.Add();

                dataGridViewItem4Sale.Rows[n].Cells[0].Value = item["id"].ToString();
                dataGridViewItem4Sale.Rows[n].Cells[1].Value = (n+1).ToString();
                dataGridViewItem4Sale.Rows[n].Cells[2].Value = false;
                dataGridViewItem4Sale.Rows[n].Cells[3].Style.ForeColor = Color.ForestGreen;
                dataGridViewItem4Sale.Rows[n].Cells[3].Value = item["itemName"].ToString();
                dataGridViewItem4Sale.Rows[n].Cells[4].Value = item["itemDescription"].ToString();
                dataGridViewItem4Sale.Rows[n].Cells[5].Value = item["itemPrice"].ToString();
                dataGridViewItem4Sale.Rows[n].Cells[6].Value = item["noOfItem"].ToString();

            }

            DBConnect.Close();

        }
        void fillDataGridViw()
        {
            if (DBConnect.State == ConnectionState.Closed)
            {
                DBConnect.Open();
                MySqlDataAdapter Sda = new MySqlDataAdapter("Select id, itemDescription, itemName, itemPrice,noOfItem  from stock where itemName like '%" + SearchTxt.text + "%' order by id", DBConnect);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                dataGridViewItem4Sale.Rows.Clear();
                foreach (DataRow stock in dt.Rows)
                {
                    int n = dataGridViewItem4Sale.Rows.Add();

                    dataGridViewItem4Sale.Rows[n].Cells[0].Value = stock["id"].ToString();
                    dataGridViewItem4Sale.Rows[n].Cells[1].Value = (n +1).ToString();
                    dataGridViewItem4Sale.Rows[n].Cells[2].Value = false;
                    dataGridViewItem4Sale.Rows[n].Cells[3].Value = stock["itemName"].ToString();
                    dataGridViewItem4Sale.Rows[n].Cells[4].Value = stock["itemDescription"].ToString();
                    dataGridViewItem4Sale.Rows[n].Cells[5].Value = stock["itemPrice"].ToString();
                    dataGridViewItem4Sale.Rows[n].Cells[6].Value = stock["noOfItem"].ToString();

                }

                dataGridViewItem4Sale.ClearSelection();
              
                DBConnect.Close();
                //dataGridViewItem4Sale.Rows[0].Cells[0].Selected = false;
            }
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            groupBoxSoldItems.Visible = true;   
            for (int i = 0; i <= dataGridViewItem4Sale.Rows.Count - 1; i++)
            {
                
                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dataGridViewItem4Sale.Rows[i].Cells[2].Value;
                if (checkedCell != false)
                {
                    DataGridViewRow row = dataGridViewItem4Sale.Rows[i];
                    if (dataGridViewSoldItem.Rows.Count != 0)
                    {
                        for (int j = 0; j <= dataGridViewSoldItem.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dataGridViewSoldItem.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }
                        if (rowAlreadyExist == false)
                        {

                            dataGridViewSoldItem.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                        }
                        
                    }
                    else
                    {

                        dataGridViewSoldItem.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                    }
                    
                }
               
            }
            
            //dataGridViewSoldItem.Rows[0].Cells[0].Selected = false;
            cartCount.Text = dataGridViewSoldItem.Rows.Count.ToString();
            //dataGridViewSoldItem.ClearSelection();
        }
        private void SearchTxt_OnTextChange(object sender, EventArgs e)
        {
            fillDataGridViw();
        }
        private void dataGridViewItem4Sale_MouseClick(object sender, MouseEventArgs e)
        {
            groupBoxPaid.Visible = false;
            if ((bool)dataGridViewItem4Sale.SelectedRows[0].Cells[2].Value == false)
            {
                dataGridViewItem4Sale.SelectedRows[0].Cells[2].Value = true;
            }
            else
            {
                dataGridViewItem4Sale.SelectedRows[0].Cells[2].Value = false;

            }
        }
        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoldItem.Rows.Count != 0)
            {
                int selectedRow = dataGridViewSoldItem.CurrentCell.RowIndex;
                dataGridViewSoldItem.Rows.RemoveAt(selectedRow);
                cartCount.Text = dataGridViewSoldItem.Rows.Count.ToString();
            }

            if (dataGridViewSoldItem.Rows.Count == 0)
            {
                groupBoxSoldItems.Visible = false;
            }
        }
        private void btnItemsforSale_Click(object sender, EventArgs e)
        {
            SearchTxt.Focus();
        }
        private void btnSoldItem_Click(object sender, EventArgs e)
        {
            dataGridViewSoldItem.Focus();
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure you have crooss-checked the goods about to be Sold?", "Invento Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    dataGridViewSoldItem.Rows[0].Cells[2].Selected = false;
                    for (int i = 0; i < dataGridViewSoldItem.Rows.Count; i++)
                    {
                        dataGridViewSoldItem.EndEdit();
                        //Gets the cell values of each row
                        DataGridViewRow row1 = dataGridViewSoldItem.Rows[i];

                        if (String.IsNullOrEmpty(row1.Cells[5].Value as String))
                        {
                            MessageBox.Show("Cell is Empty");
                            return;
                        }
                        else
                        {
                            string itemId = row1.Cells[0].Value.ToString();
                            string itemNam = row1.Cells[2].Value.ToString();
                            string itemDesc = row1.Cells[3].Value.ToString();
                            double itemPri = double.Parse(row1.Cells[4].Value.ToString());
                            int itemQty = Convert.ToInt32(row1.Cells[5].Value);//.ToString();
                            double Amt = Convert.ToDouble(dataGridViewSoldItem.Rows[i].Cells["Column8"].Value);
                            Amt = (itemQty * itemPri);

                            // Update the stock Records
                            int stock = 0;
                            string selectQuery = "Select * from stock Order by id ";
                            if (DBConnect.State == ConnectionState.Open)
                            {
                                DBConnect.Close();
                            }

                            DBConnect.Open();
                            MySqlDataAdapter sda = new MySqlDataAdapter(selectQuery, DBConnect);
                            DataTable dt1 = new DataTable();
                            sda.Fill(dt1);
                            foreach (DataRow dr1 in dt1.Rows)
                            {
                                if (dr1["Id"].ToString() == itemId)
                                {
                                    stock = Convert.ToInt32(dr1["noOfItem"].ToString());
                                    //MessageBox.Show(stock.ToString());
                                    //MessageBox.Show(itemQty.ToString());
                                    if (itemQty > stock)
                                    {
                                        MessageBox.Show(itemNam + " STock is less than the Quantity you Input", "Out of Stock!");
                                        return;
                                    }

                                    else
                                    {
                                        string insertQuery = "INSERT  INTO solditemsrecords(itemId,itemName,itemDescrip,qty,price,totalAmount) VALUES ('" + itemId + "','" + itemNam + "','" + itemDesc + "','" + itemQty + "','" + itemPri + "' ,'" + Amt + "')";
                                        //  DBConnect.Open();    
                                        MySqlCommand command = new MySqlCommand(insertQuery, DBConnect);
                                        if (command.ExecuteNonQuery() == 1)
                                        {
                                            MySqlCommand cmd1 = DBConnect.CreateCommand();
                                            cmd1.CommandType = CommandType.Text;
                                            cmd1.CommandText = "UPDATE stock set noOfItem = noOfItem - " + itemQty + " where itemDescription='" + itemDesc + "'";
                                            cmd1.ExecuteNonQuery();
                                            //MessageBox.Show("Item Sold");
                                            //dataGridViewSoldItem.Rows.Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Seems your data is incomplete");
                                        }
                                    }
                                    DBConnect.Close();
                                }
                            }

                            DBConnect.Close();
                        }
                    }
                    totalPrice.Text = "0.0";
                    dataGridViewSoldItem.Rows.Clear();
                    groupBoxSoldItems.Visible = false;
                    cartCount.Text = dataGridViewSoldItem.Rows.Count.ToString();
                    //MessageBox.Show("Items Sold", "Invento");
                    loadData();
                    groupBoxPaid.Visible = true;
                    groupBoxPaid.BringToFront();
                }
                else
                {
                    MessageBox.Show("Goods not Sold", "Invento Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewSoldItem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //update the Amount  column and Total price label whenever rows are deleted
           UpdatePrice();
           
        }

        private void dataGridViewSoldItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePrice();
        }

        public void UpdatePrice()
        {

            double prixe = 0;
            int qtty = 0;
            double totPrice = 0;
            foreach (DataGridViewRow row in dataGridViewSoldItem.Rows)
            {

                if (row.Cells["columnPrice"].Value != null)
                {
                    if (row.Cells["columnPrice"].Value.ToString().Length != 0)
                    {
                        try
                        {

                            prixe = double.Parse(row.Cells["columnPrice"].Value.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }

                if (row.Cells["Column7"].Value != null)
                {
                    //Verify that the cell value is not an empty string
                    if (row.Cells["Column7"].Value.ToString().Length != 0)
                    {
                        qtty = int.Parse(row.Cells["Column7"].Value.ToString());
                    }
                    row.Cells["Column8"].Value = (qtty * prixe).ToString();


                }

                totPrice = totPrice + Convert.ToDouble(row.Cells["Column8"].Value);
                totalPrice.Text = totPrice.ToString();
            }
        }

        private void dataGridViewSoldItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewSoldItem.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            else
            {
                // UpdatePrice();
            }
            
        }

      

      

   
     }   
}
