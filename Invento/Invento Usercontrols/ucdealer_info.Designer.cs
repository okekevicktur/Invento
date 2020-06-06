namespace Invento.Invento_Usercontrols
{
    partial class ucdealer_info
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucdealer_info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dealerList1 = new Invento.Invento_Usercontrols.dealerList();
            this.createDealer1 = new Invento.Invento_Usercontrols.createDealer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddDealer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btndealerList = new Bunifu.Framework.UI.BunifuTileButton();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.dealerList1);
            this.panel1.Controls.Add(this.createDealer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 659);
            this.panel1.TabIndex = 2;
            // 
            // dealerList1
            // 
            this.dealerList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealerList1.Location = new System.Drawing.Point(0, 74);
            this.dealerList1.Name = "dealerList1";
            this.dealerList1.Size = new System.Drawing.Size(1087, 585);
            this.dealerList1.TabIndex = 4;
            this.dealerList1.Visible = false;
            // 
            // createDealer1
            // 
            this.createDealer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createDealer1.Location = new System.Drawing.Point(0, 74);
            this.createDealer1.Name = "createDealer1";
            this.createDealer1.Size = new System.Drawing.Size(1087, 585);
            this.createDealer1.TabIndex = 3;
            this.createDealer1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.btnAddDealer);
            this.panel2.Controls.Add(this.btndealerList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 74);
            this.panel2.TabIndex = 2;
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDealer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddDealer.color = System.Drawing.Color.ForestGreen;
            this.btnAddDealer.colorActive = System.Drawing.Color.ForestGreen;
            this.btnAddDealer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDealer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAddDealer.ForeColor = System.Drawing.Color.White;
            this.btnAddDealer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDealer.Image")));
            this.btnAddDealer.ImagePosition = 7;
            this.btnAddDealer.ImageZoom = 5;
            this.btnAddDealer.LabelPosition = 30;
            this.btnAddDealer.LabelText = "Add Dealer";
            this.btnAddDealer.Location = new System.Drawing.Point(522, 0);
            this.btnAddDealer.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Size = new System.Drawing.Size(565, 74);
            this.btnAddDealer.TabIndex = 4;
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click_1);
            // 
            // btndealerList
            // 
            this.btndealerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndealerList.BackColor = System.Drawing.Color.ForestGreen;
            this.btndealerList.color = System.Drawing.Color.ForestGreen;
            this.btndealerList.colorActive = System.Drawing.Color.ForestGreen;
            this.btndealerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndealerList.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btndealerList.ForeColor = System.Drawing.Color.White;
            this.btndealerList.Image = ((System.Drawing.Image)(resources.GetObject("btndealerList.Image")));
            this.btndealerList.ImagePosition = 7;
            this.btndealerList.ImageZoom = 5;
            this.btndealerList.LabelPosition = 30;
            this.btndealerList.LabelText = "Dealers";
            this.btndealerList.Location = new System.Drawing.Point(0, 0);
            this.btndealerList.Margin = new System.Windows.Forms.Padding(5);
            this.btndealerList.Name = "btndealerList";
            this.btndealerList.Size = new System.Drawing.Size(521, 74);
            this.btndealerList.TabIndex = 3;
            this.btndealerList.Click += new System.EventHandler(this.btndealerList_Click_1);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.White;
            this.SearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchTxt.BackgroundImage")));
            this.SearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("SearchTxt.Icon")));
            this.SearchTxt.Location = new System.Drawing.Point(13, 213);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(215, 29);
            this.SearchTxt.TabIndex = 5;
            this.SearchTxt.text = "";
            // 
            // ucdealer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucdealer_info";
            this.Size = new System.Drawing.Size(1087, 659);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnAddDealer;
        private Bunifu.Framework.UI.BunifuTileButton btndealerList;
        private dealerList dealerList1;
        private createDealer createDealer1;
        private Bunifu.Framework.UI.BunifuTextbox SearchTxt;

    }
}
