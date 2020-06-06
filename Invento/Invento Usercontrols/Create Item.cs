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
   
    public partial class Create_Item : UserControl
    {
             
        public Create_Item()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            TxtItemName.Text = "";
            txtItemDesc.Text = " ";
            txtNoItems.Text = "";
            txtItemprice.Text = "";
        }
        MySqlConnection DBConnect = new MySqlConnection("datasource =localhost; username = root; password =; database = invento");
 
        private void TxtItemName_TextChanged(object sender, EventArgs e)
        {
            char[] c = TxtItemName.Text.ToCharArray();
            int j;
            for (j = 0; j < TxtItemName.Text.Length; j++)
            {
                if (j == 0)
                {
                    c[j] = c[j].ToString().ToUpper()[0];
                }
                else c[j] = c[j].ToString().ToLower()[0];
            }
            TxtItemName.Text = new string(c);
            TxtItemName.Select(TxtItemName.Text.Length, 1);
        }

        private void txtItemDesc_TextChanged(object sender, EventArgs e)
        {           
            // Capitalize every first letter 
            char[] c = txtItemDesc.Text.ToCharArray();
            int j;
            for (j = 0; j < txtItemDesc.Text.Length; j++)
            {
                if (j == 0)
                {
                    c[j] = c[j].ToString().ToUpper()[0];
                }
                else c[j] = c[j].ToString().ToLower()[0];
            }
            txtItemDesc.Text = new string(c);
            txtItemDesc.Select(txtItemDesc.Text.Length, 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TxtItemName.Text != "" || txtNoItems.Text != "" || txtItemprice.Text != "")
            {
                string insertQuery = "INSERT INTO stock (itemName,itemDescription,noOfItem,itemPrice) VALUES ('" + TxtItemName.Text + "','" + txtItemDesc.Text + "','" + txtNoItems.Text + "','" + txtItemprice.Text + "')";
                DBConnect.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, DBConnect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Item Succesfully Created");

                }
                else
                {
                    MessageBox.Show("Seems your data is incomplete");

                }
                DBConnect.Close();
                Clear();
            }
        }     
         
    }
}
