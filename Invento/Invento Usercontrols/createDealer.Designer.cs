namespace Invento.Invento_Usercontrols
{
    partial class createDealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createDealer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDealer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDealerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCompanyName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDealer);
            this.groupBox1.Controls.Add(this.txtDealerName);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 415);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer";
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddDealer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDealer.BorderRadius = 7;
            this.btnAddDealer.ButtonText = "Add Dealer";
            this.btnAddDealer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDealer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDealer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDealer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddDealer.Iconimage")));
            this.btnAddDealer.Iconimage_right = null;
            this.btnAddDealer.Iconimage_right_Selected = null;
            this.btnAddDealer.Iconimage_Selected = null;
            this.btnAddDealer.IconMarginLeft = 0;
            this.btnAddDealer.IconMarginRight = 0;
            this.btnAddDealer.IconRightVisible = true;
            this.btnAddDealer.IconRightZoom = 0D;
            this.btnAddDealer.IconVisible = true;
            this.btnAddDealer.IconZoom = 50D;
            this.btnAddDealer.IsTab = false;
            this.btnAddDealer.Location = new System.Drawing.Point(328, 334);
            this.btnAddDealer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnAddDealer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddDealer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDealer.selected = false;
            this.btnAddDealer.Size = new System.Drawing.Size(129, 40);
            this.btnAddDealer.TabIndex = 20;
            this.btnAddDealer.Text = "Add Dealer";
            this.btnAddDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDealer.Textcolor = System.Drawing.Color.White;
            this.btnAddDealer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click);
            // 
            // txtDealerName
            // 
            this.txtDealerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDealerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDealerName.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.ForeColor = System.Drawing.Color.Black;
            this.txtDealerName.HintForeColor = System.Drawing.Color.Gray;
            this.txtDealerName.HintText = "Dealer Name";
            this.txtDealerName.isPassword = false;
            this.txtDealerName.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.txtDealerName.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtDealerName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDealerName.LineThickness = 2;
            this.txtDealerName.Location = new System.Drawing.Point(265, 30);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(310, 41);
            this.txtDealerName.TabIndex = 12;
            this.txtDealerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(132, 42);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(101, 21);
            this.bunifuCustomLabel6.TabIndex = 10;
            this.bunifuCustomLabel6.Text = "Dealer Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(132, 120);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(123, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Company Name";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HintForeColor = System.Drawing.Color.Gray;
            this.txtAddress.HintText = "Dealer Address";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.txtAddress.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAddress.LineThickness = 2;
            this.txtAddress.Location = new System.Drawing.Point(265, 253);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 41);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(132, 273);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(70, 21);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = " Address";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.HintForeColor = System.Drawing.Color.Gray;
            this.txtContact.HintText = "Dealer Contact";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.txtContact.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtContact.LineThickness = 2;
            this.txtContact.Location = new System.Drawing.Point(265, 171);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(310, 41);
            this.txtContact.TabIndex = 9;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(132, 191);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(63, 21);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Contact";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.HintForeColor = System.Drawing.Color.Gray;
            this.txtCompanyName.HintText = "Dealer Company Name";
            this.txtCompanyName.isPassword = false;
            this.txtCompanyName.LineFocusedColor = System.Drawing.Color.ForestGreen;
            this.txtCompanyName.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtCompanyName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCompanyName.LineThickness = 2;
            this.txtCompanyName.Location = new System.Drawing.Point(265, 100);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(310, 41);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "createDealer";
            this.Size = new System.Drawing.Size(825, 508);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDealerName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCompanyName;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDealer;
    }
}
