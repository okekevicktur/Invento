using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invento
{
    public partial class Goods : UserControl
    {
        private static Goods _instance;
        public static Goods Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Goods();
                return _instance;
            }
        }
        public Goods()
        {
            InitializeComponent();
        }

       
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            itemList1.Visible = false;
            create_Item1.BringToFront();
            create_Item1.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            itemList1.Visible = true;
            itemList1.Dock = DockStyle.Fill;
            itemList1.BringToFront();
            
        }

        private void itemList1_Load(object sender, EventArgs e)
        {

        }
    }
}
