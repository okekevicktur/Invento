namespace Invento
{
    partial class Goods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.itemList1 = new Invento.Invento_Usercontrols.ItemList();
            this.create_Item1 = new Invento.Invento_Usercontrols.Create_Item();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 75);
            this.panel1.TabIndex = 1;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTileButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton1.color = System.Drawing.Color.ForestGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 7;
            this.bunifuTileButton1.ImageZoom = 5;
            this.bunifuTileButton1.LabelPosition = 30;
            this.bunifuTileButton1.LabelText = "My Stock";
            this.bunifuTileButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(579, 75);
            this.bunifuTileButton1.TabIndex = 5;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTileButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton2.color = System.Drawing.Color.ForestGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 7;
            this.bunifuTileButton2.ImageZoom = 5;
            this.bunifuTileButton2.LabelPosition = 30;
            this.bunifuTileButton2.LabelText = "Create Items";
            this.bunifuTileButton2.Location = new System.Drawing.Point(580, 0);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(581, 75);
            this.bunifuTileButton2.TabIndex = 6;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // itemList1
            // 
            this.itemList1.AutoScroll = true;
            this.itemList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemList1.Location = new System.Drawing.Point(0, 75);
            this.itemList1.Name = "itemList1";
            this.itemList1.Size = new System.Drawing.Size(1161, 517);
            this.itemList1.TabIndex = 3;
            this.itemList1.Load += new System.EventHandler(this.itemList1_Load);
            // 
            // create_Item1
            // 
            this.create_Item1.Location = new System.Drawing.Point(161, 106);
            this.create_Item1.Name = "create_Item1";
            this.create_Item1.Size = new System.Drawing.Size(821, 461);
            this.create_Item1.TabIndex = 2;
            this.create_Item1.Visible = false;
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemList1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_Item1);
            this.Name = "Goods";
            this.Size = new System.Drawing.Size(1161, 592);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Invento_Usercontrols.Create_Item create_Item1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Invento_Usercontrols.ItemList itemList1;

    }
}
