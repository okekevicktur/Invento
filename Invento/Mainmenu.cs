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
using Bunifu.Framework.UI;
using Invento.Invento_Usercontrols;


namespace Invento
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
            if (!panelMain.Controls.Contains(ucHome.Instance))
            {
                panelMain.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
           
        }

        public string itemNm;
        public string Description;
        public string NumberOfItems;
        public string Price;
        public string itemNumber;

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");
      

        //public void loadData()
        //{
        //    string insertQuery = "Select * from items Order by id ";
        //    DBConnect.Open();
        //    MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        int n = dataGridViewItem4Sale.Rows.Add();
                
        //        dataGridViewItem4Sale.Rows[n].Cells[0].Value = item["id"].ToString();
        //        dataGridViewItem4Sale.Rows[n].Cells[1].Value = false;
        //        dataGridViewItem4Sale.Rows[n].Cells[2].Style.ForeColor = Color.ForestGreen;
        //        dataGridViewItem4Sale.Rows[n].Cells[2].Value = item["itemName"].ToString();
        //        dataGridViewItem4Sale.Rows[n].Cells[3].Value = item["itemDescription"].ToString();
        //        dataGridViewItem4Sale.Rows[n].Cells[4].Value = item["itemPrice"].ToString();
        //        dataGridViewItem4Sale.Rows[n].Cells[5].Value = item["noOfItem"].ToString();
               
        //    }

        //    DBConnect.Close();
         
        //}
        //void HomeScreenShow()
        //{
            
        //}
        private void BtnMainmenu_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucHome.Instance))
            {
                panelMain.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            ucHome.Instance.BringToFront();           
        }
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
           string select= bunifuDropdown1.selectedValue.ToString();
           bunifuCustomLabel3.Text = select;
        }
        //void hideMain()
        //{
        //    SearchTxt.Visible = false;
        //    btnSell.Visible = false;
        //    dataGridViewItem4Sale.Visible = false;
        //    btnDelet.Visible = false;
        //    btnClear.Visible = false;
        //    dataGridViewSoldItem.Visible = false;
        //    panelTopItems.Visible = false;
        //}
        private void BtnGoods_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(Goods.Instance))
            {

                panelMain.Controls.Add(Goods.Instance);
                Goods.Instance.Dock = DockStyle.Fill;
                Goods.Instance.BringToFront();
            }
            else

                Goods.Instance.BringToFront();           
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            // itemListPanel.Controls.Clear();
            //loadData();
            //  ucMainmenu1.Visible = true;
        }

        public GroupBox grpBox { get; set; }

        public CheckBox bunCheck { get; set; }
        public Label labname { get; set; }

        private void btnItemsforSale_Click(object sender, EventArgs e)
        {

            //itemsForSale1.Show();
            //itemsForSale1.BringToFront();
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDealer_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucdealer_info.Instance))
            {
                panelMain.Controls.Add(ucdealer_info.Instance);
                ucdealer_info.Instance.Dock = DockStyle.Fill;
                ucdealer_info.Instance.BringToFront();
            }
            ucdealer_info.Instance.BringToFront();   
        }

      
        

        //private void btnSell_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i <= dataGridViewItem4Sale.Rows.Count-1; i++)
        //    {
                
        //        bool rowAlreadyExist = false;
        //        bool checkedCell = (bool)dataGridViewItem4Sale.Rows[i].Cells[1].Value;
        //        if (checkedCell == true)
        //        {
        //            DataGridViewRow row = dataGridViewItem4Sale.Rows[i];
        //         if (dataGridViewSoldItem.Rows.Count != 0)
        //            {
        //                for (int j = 0; j <= dataGridViewSoldItem.Rows.Count-1; j++)
        //                {
        //                    if (row.Cells[0].Value.ToString() == dataGridViewSoldItem.Rows[j].Cells[0].Value.ToString())
        //                    {
        //                        rowAlreadyExist = true;
        //                        break;
        //                    }
        //                }
        //                if (rowAlreadyExist == false)
        //                {
        //                    dataGridViewSoldItem.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
        //                }
        //            }
        //            else
        //            {
        //                dataGridViewSoldItem.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
        //            }                 
        //       }
        //  }
       // }

        //void fillDataGridViw()
        //{
        ////    if (DBConnect.State == ConnectionState.Closed)
        ////    {
        ////        DBConnect.Open();
        ////        MySqlDataAdapter Sda = new MySqlDataAdapter("Select id, itemDescription, itemName, itemPrice,noOfItem  from items where itemName like '" + SearchTxt.text + "%' order by id", DBConnect);
        ////        DataTable dt = new DataTable();
        ////        Sda.Fill(dt);
        ////        dataGridViewItem4Sale.Rows.Clear();
        ////        foreach (DataRow item in dt.Rows)
        ////        {
        ////            int n = dataGridViewItem4Sale.Rows.Add();

        ////            dataGridViewItem4Sale.Rows[n].Cells[0].Value = item["id"].ToString();
        ////            dataGridViewItem4Sale.Rows[n].Cells[1].Value = false;
        ////            dataGridViewItem4Sale.Rows[n].Cells[2].Value = item["itemName"].ToString();
        ////            dataGridViewItem4Sale.Rows[n].Cells[3].Value = item["itemDescription"].ToString();
        ////            dataGridViewItem4Sale.Rows[n].Cells[4].Value = item["itemPrice"].ToString();
        ////            dataGridViewItem4Sale.Rows[n].Cells[5].Value = item["noOfItem"].ToString();

        ////        }
        ////        DBConnect.Close();     
        ////    }
        //}

        //private void dataGridViewItem4Sale_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if ((bool)dataGridViewItem4Sale.SelectedRows[0].Cells[1].Value == false)
        //    {
        //        dataGridViewItem4Sale.SelectedRows[0].Cells[1].Value = true;
        //    }
        //    else
        //    {
        //        dataGridViewItem4Sale.SelectedRows[0].Cells[1].Value = false;

        //    }
        //}

        //private void SearchTxt_OnTextChange(object sender, EventArgs e)
        //{
        //    fillDataGridViw();
        //}

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    dataGridViewSoldItem.Rows.Clear();
        //}


        //private void btnDelet_Click(object sender, EventArgs e)
        //{
        //    int   selectedRow = dataGridViewSoldItem.CurrentCell.RowIndex;
        //    dataGridViewSoldItem.Rows.RemoveAt(selectedRow);
        //}

       //public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
       // {
       //     ComboBox combo = sender as ComboBox;
       //     MessageBox.Show(combo.SelectedItem.ToString());
       // }

       //private void dataGridViewSoldItem_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
       //{
       //    // here you need to attach the on key press event to handle validation
       //    DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
       //    tb.KeyPress += new KeyPressEventHandler(dataGridViewSoldItem_KeyPress);

       //    e.Control.KeyPress += new KeyPressEventHandler(dataGridViewSoldItem_KeyPress);
          
       //}

       //private void dataGridViewSoldItem_KeyPress(object sender, KeyPressEventArgs e)
       //{
       //    // when user did not entered a number
       //    if (!Char.IsNumber(e.KeyChar)
       //          && (Keys)e.KeyChar != Keys.Back)  // check if backspace is pressed
       //    {
       //        // set handled to cancel the event to be proceed by the system
       //        e.Handled = true;
       //        // optionally indicate user that characters other than numbers are not allowed
       //         MessageBox.Show("Only numbers are allowed");
       //    }
       //}
   
    }
}
