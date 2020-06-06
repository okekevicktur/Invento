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
    public partial class itemsForSale : UserControl
    {
         public string name {get; set; }
        public string desc {get; set; }
        public string prodNo {get; set; }
        public itemsForSale()
        {
            InitializeComponent();
            loadData();
        }

        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");


        public void loadData()
        {
            string insertQuery = "Select * from items Order by id";
            DBConnect.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(insertQuery, DBConnect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
               // dataGridView1.Rows[n].Cells[1].Style.BackColor = Color.LightPink;
                dataGridView1.Rows[n].Cells[0].Value = item["id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["itemName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["itemDescription"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["noOfItem"].ToString();
               

            }
            DBConnect.Close();
        }

        private void itemsForSale_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               // DataGridViewCheckBoxCell chk = row.Cells[4] as DataGridViewCheckBoxCell;
                
                //if (Convert.ToBoolean(chk.Value) == true)
                //{
                //    listBox1.Items.Add(row.Cells[3].Value.ToString());
                //}
                bool isSelected = Convert.ToBoolean(row.Cells["Column4"].Value);
                if (isSelected)
                {
                    //message += Environment.NewLine;
                    name = row.Cells["Column1"].Value.ToString();
                    desc= row.Cells["Column2"].Value.ToString();
                    prodNo = row.Cells["Column3"].Value.ToString();


                   MessageBox.Show("Value" + " " + name + " " + desc + " " + prodNo);
                }
               
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    DataGridViewCheckBoxCell select = (DataGridViewCheckBoxCell)dataGridView1.CurrentCell;
        //    bool ischecked = (bool)select.EditedFormattedValue;

        }


    }
}
