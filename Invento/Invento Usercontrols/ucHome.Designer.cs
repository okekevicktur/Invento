namespace Invento.Invento_Usercontrols
{
    partial class ucHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBoxSoldItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewSoldItem = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnDelet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cartCount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewItem4Sale = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPaid = new System.Windows.Forms.GroupBox();
            this.panelTopItems = new System.Windows.Forms.Panel();
            this.btnSoldItem = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnItemsforSale = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel.SuspendLayout();
            this.groupBoxSoldItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem4Sale)).BeginInit();
            this.panelTopItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.groupBoxSoldItems);
            this.panel.Controls.Add(this.cartCount);
            this.panel.Controls.Add(this.SearchTxt);
            this.panel.Controls.Add(this.btnCart);
            this.panel.Controls.Add(this.dataGridViewItem4Sale);
            this.panel.Controls.Add(this.groupBoxPaid);
            this.panel.Controls.Add(this.panelTopItems);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1087, 659);
            this.panel.TabIndex = 18;
            // 
            // groupBoxSoldItems
            // 
            this.groupBoxSoldItems.Controls.Add(this.dataGridViewSoldItem);
            this.groupBoxSoldItems.Controls.Add(this.totalPrice);
            this.groupBoxSoldItems.Controls.Add(this.label);
            this.groupBoxSoldItems.Controls.Add(this.btnDelet);
            this.groupBoxSoldItems.Controls.Add(this.btnSell);
            this.groupBoxSoldItems.Location = new System.Drawing.Point(28, 315);
            this.groupBoxSoldItems.Name = "groupBoxSoldItems";
            this.groupBoxSoldItems.Size = new System.Drawing.Size(1007, 320);
            this.groupBoxSoldItems.TabIndex = 12;
            this.groupBoxSoldItems.TabStop = false;
            this.groupBoxSoldItems.Visible = false;
            // 
            // dataGridViewSoldItem
            // 
            this.dataGridViewSoldItem.AllowUserToAddRows = false;
            this.dataGridViewSoldItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewSoldItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSoldItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSoldItem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSoldItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSoldItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoldItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.columnPrice,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSoldItem.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSoldItem.GridColor = System.Drawing.Color.Green;
            this.dataGridViewSoldItem.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewSoldItem.Name = "dataGridViewSoldItem";
            this.dataGridViewSoldItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSoldItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewSoldItem.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSoldItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSoldItem.Size = new System.Drawing.Size(816, 246);
            this.dataGridViewSoldItem.TabIndex = 2;

            this.dataGridViewSoldItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSoldItem_CellEndEdit);
            this.dataGridViewSoldItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewSoldItem_EditingControlShowing);
            this.dataGridViewSoldItem.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewSoldItem_RowsRemoved);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "S/N";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Item Number";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            this.columnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            this.Column7.ToolTipText = "Quantity Purchased";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(908, 127);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(16, 17);
            this.totalPrice.TabIndex = 11;
            this.totalPrice.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.ForestGreen;
            this.label.Location = new System.Drawing.Point(824, 127);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Total Price :";
            // 
            // btnDelet
            // 
            this.btnDelet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelet.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelet.BorderRadius = 3;
            this.btnDelet.ButtonText = "Delete";
            this.btnDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelet.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelet.ForeColor = System.Drawing.Color.Black;
            this.btnDelet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelet.Iconimage = null;
            this.btnDelet.Iconimage_right = null;
            this.btnDelet.Iconimage_right_Selected = null;
            this.btnDelet.Iconimage_Selected = null;
            this.btnDelet.IconMarginLeft = 0;
            this.btnDelet.IconMarginRight = 0;
            this.btnDelet.IconRightVisible = true;
            this.btnDelet.IconRightZoom = 0D;
            this.btnDelet.IconVisible = true;
            this.btnDelet.IconZoom = 60D;
            this.btnDelet.IsTab = false;
            this.btnDelet.Location = new System.Drawing.Point(740, 12);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnDelet.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnDelet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelet.selected = false;
            this.btnDelet.Size = new System.Drawing.Size(78, 33);
            this.btnDelet.TabIndex = 6;
            this.btnDelet.Text = "Delete";
            this.btnDelet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelet.Textcolor = System.Drawing.Color.Red;
            this.btnDelet.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnSell
            // 
            this.btnSell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSell.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSell.BorderRadius = 7;
            this.btnSell.ButtonText = "Sell";
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.DisabledColor = System.Drawing.Color.Gray;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSell.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSell.Iconimage")));
            this.btnSell.Iconimage_right = null;
            this.btnSell.Iconimage_right_Selected = null;
            this.btnSell.Iconimage_Selected = null;
            this.btnSell.IconMarginLeft = 0;
            this.btnSell.IconMarginRight = 0;
            this.btnSell.IconRightVisible = true;
            this.btnSell.IconRightZoom = 0D;
            this.btnSell.IconVisible = true;
            this.btnSell.IconZoom = 49D;
            this.btnSell.IsTab = false;
            this.btnSell.Location = new System.Drawing.Point(834, 177);
            this.btnSell.Name = "btnSell";
            this.btnSell.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSell.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSell.selected = false;
            this.btnSell.Size = new System.Drawing.Size(90, 42);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSell.Textcolor = System.Drawing.Color.White;
            this.btnSell.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // cartCount
            // 
            this.cartCount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cartCount.BackColor = System.Drawing.Color.Green;
            this.cartCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartCount.BorderRadius = 7;
            this.cartCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartCount.ButtonText = "0";
            this.cartCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartCount.DisabledColor = System.Drawing.Color.Gray;
            this.cartCount.Iconcolor = System.Drawing.Color.Transparent;
            this.cartCount.Iconimage = null;
            this.cartCount.Iconimage_right = null;
            this.cartCount.Iconimage_right_Selected = null;
            this.cartCount.Iconimage_Selected = null;
            this.cartCount.IconMarginLeft = 0;
            this.cartCount.IconMarginRight = 0;
            this.cartCount.IconRightVisible = true;
            this.cartCount.IconRightZoom = 0D;
            this.cartCount.IconVisible = true;
            this.cartCount.IconZoom = 90D;
            this.cartCount.IsTab = false;
            this.cartCount.Location = new System.Drawing.Point(1023, 77);
            this.cartCount.Name = "cartCount";
            this.cartCount.Normalcolor = System.Drawing.Color.Green;
            this.cartCount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cartCount.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.cartCount.selected = false;
            this.cartCount.Size = new System.Drawing.Size(31, 27);
            this.cartCount.TabIndex = 9;
            this.cartCount.Text = "0";
            this.cartCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cartCount.Textcolor = System.Drawing.Color.Snow;
            this.cartCount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.White;
            this.SearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchTxt.BackgroundImage")));
            this.SearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("SearchTxt.Icon")));
            this.SearchTxt.Location = new System.Drawing.Point(77, 82);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(204, 29);
            this.SearchTxt.TabIndex = 4;
            this.SearchTxt.text = "";
            this.SearchTxt.OnTextChange += new System.EventHandler(this.SearchTxt_OnTextChange);
            // 
            // btnCart
            // 
            this.btnCart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.BorderRadius = 7;
            this.btnCart.ButtonText = "Add to Cart";
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.DisabledColor = System.Drawing.Color.Gray;
            this.btnCart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCart.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCart.Iconimage")));
            this.btnCart.Iconimage_right = null;
            this.btnCart.Iconimage_right_Selected = null;
            this.btnCart.Iconimage_Selected = null;
            this.btnCart.IconMarginLeft = 0;
            this.btnCart.IconMarginRight = 0;
            this.btnCart.IconRightVisible = true;
            this.btnCart.IconRightZoom = 0D;
            this.btnCart.IconVisible = true;
            this.btnCart.IconZoom = 40D;
            this.btnCart.IsTab = false;
            this.btnCart.Location = new System.Drawing.Point(897, 88);
            this.btnCart.Name = "btnCart";
            this.btnCart.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnCart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCart.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCart.selected = false;
            this.btnCart.Size = new System.Drawing.Size(138, 32);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.Textcolor = System.Drawing.Color.White;
            this.btnCart.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // dataGridViewItem4Sale
            // 
            this.dataGridViewItem4Sale.AllowUserToAddRows = false;
            this.dataGridViewItem4Sale.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItem4Sale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItem4Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewItem4Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem4Sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItem4Sale.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewItem4Sale.GridColor = System.Drawing.Color.Green;
            this.dataGridViewItem4Sale.Location = new System.Drawing.Point(35, 118);
            this.dataGridViewItem4Sale.Name = "dataGridViewItem4Sale";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItem4Sale.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewItem4Sale.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewItem4Sale.RowTemplate.Height = 25;
            this.dataGridViewItem4Sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItem4Sale.Size = new System.Drawing.Size(815, 191);
            this.dataGridViewItem4Sale.TabIndex = 1;
            this.dataGridViewItem4Sale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewItem4Sale_MouseClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S/N";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Select";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Item Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Item Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 50;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Remaining";
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBoxPaid
            // 
            this.groupBoxPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPaid.BackgroundImage")));
            this.groupBoxPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPaid.Location = new System.Drawing.Point(265, 376);
            this.groupBoxPaid.Name = "groupBoxPaid";
            this.groupBoxPaid.Size = new System.Drawing.Size(368, 222);
            this.groupBoxPaid.TabIndex = 13;
            this.groupBoxPaid.TabStop = false;
            this.groupBoxPaid.Visible = false;
            // 
            // panelTopItems
            // 
            this.panelTopItems.BackColor = System.Drawing.Color.ForestGreen;
            this.panelTopItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopItems.Controls.Add(this.btnSoldItem);
            this.panelTopItems.Controls.Add(this.btnItemsforSale);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopItems.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTopItems.Location = new System.Drawing.Point(0, 0);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Size = new System.Drawing.Size(1087, 76);
            this.panelTopItems.TabIndex = 0;
            // 
            // btnSoldItem
            // 
            this.btnSoldItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSoldItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSoldItem.color = System.Drawing.Color.ForestGreen;
            this.btnSoldItem.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSoldItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSoldItem.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSoldItem.ForeColor = System.Drawing.Color.White;
            this.btnSoldItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSoldItem.Image")));
            this.btnSoldItem.ImagePosition = 5;
            this.btnSoldItem.ImageZoom = 7;
            this.btnSoldItem.LabelPosition = 30;
            this.btnSoldItem.LabelText = "Sold Items";
            this.btnSoldItem.Location = new System.Drawing.Point(547, 0);
            this.btnSoldItem.Margin = new System.Windows.Forms.Padding(6);
            this.btnSoldItem.Name = "btnSoldItem";
            this.btnSoldItem.Size = new System.Drawing.Size(538, 74);
            this.btnSoldItem.TabIndex = 4;
            this.btnSoldItem.Click += new System.EventHandler(this.btnSoldItem_Click);
            // 
            // btnItemsforSale
            // 
            this.btnItemsforSale.BackColor = System.Drawing.Color.ForestGreen;
            this.btnItemsforSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnItemsforSale.color = System.Drawing.Color.ForestGreen;
            this.btnItemsforSale.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnItemsforSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemsforSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnItemsforSale.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnItemsforSale.ForeColor = System.Drawing.Color.White;
            this.btnItemsforSale.Image = ((System.Drawing.Image)(resources.GetObject("btnItemsforSale.Image")));
            this.btnItemsforSale.ImagePosition = 5;
            this.btnItemsforSale.ImageZoom = 7;
            this.btnItemsforSale.LabelPosition = 30;
            this.btnItemsforSale.LabelText = "Items For Sale";
            this.btnItemsforSale.Location = new System.Drawing.Point(0, 0);
            this.btnItemsforSale.Margin = new System.Windows.Forms.Padding(6);
            this.btnItemsforSale.Name = "btnItemsforSale";
            this.btnItemsforSale.Size = new System.Drawing.Size(623, 74);
            this.btnItemsforSale.TabIndex = 3;
            this.btnItemsforSale.Click += new System.EventHandler(this.btnItemsforSale_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1087, 659);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.panel.ResumeLayout(false);
            this.groupBoxSoldItems.ResumeLayout(false);
            this.groupBoxSoldItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem4Sale)).EndInit();
            this.panelTopItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuTextbox SearchTxt;
        private System.Windows.Forms.DataGridView dataGridViewItem4Sale;
        private System.Windows.Forms.Panel panelTopItems;
        private Bunifu.Framework.UI.BunifuTileButton btnSoldItem;
        private Bunifu.Framework.UI.BunifuTileButton btnItemsforSale;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label;
        private Bunifu.Framework.UI.BunifuFlatButton btnSell;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelet;
        private System.Windows.Forms.DataGridView dataGridViewSoldItem;
        private System.Windows.Forms.GroupBox groupBoxSoldItems;
        private Bunifu.Framework.UI.BunifuFlatButton cartCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnCart;
        private System.Windows.Forms.GroupBox groupBoxPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    }
}
