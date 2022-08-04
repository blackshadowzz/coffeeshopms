namespace coffeeshopms
{
    partial class formDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnOrdering = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerBar = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelNavbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.panelNavbar.Controls.Add(this.btnOrdering);
            this.panelNavbar.Controls.Add(this.btnItem);
            this.panelNavbar.Controls.Add(this.btnLogOut);
            this.panelNavbar.Controls.Add(this.button1);
            this.panelNavbar.Controls.Add(this.btnUser);
            this.panelNavbar.Controls.Add(this.btnStaff);
            this.panelNavbar.Controls.Add(this.btnProduct);
            this.panelNavbar.Controls.Add(this.btnMenu);
            this.panelNavbar.Controls.Add(this.btnDashboard);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.MaximumSize = new System.Drawing.Size(229, 0);
            this.panelNavbar.MinimumSize = new System.Drawing.Size(71, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(82, 704);
            this.panelNavbar.TabIndex = 18;
            // 
            // btnOrdering
            // 
            this.btnOrdering.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdering.FlatAppearance.BorderSize = 0;
            this.btnOrdering.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrdering.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnOrdering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdering.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdering.ForeColor = System.Drawing.Color.White;
            this.btnOrdering.Image = global::coffeeshopms.Properties.Resources.icons8_order_40;
            this.btnOrdering.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdering.Location = new System.Drawing.Point(3, 160);
            this.btnOrdering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdering.Name = "btnOrdering";
            this.btnOrdering.Size = new System.Drawing.Size(226, 70);
            this.btnOrdering.TabIndex = 4;
            this.btnOrdering.Text = "          Ordering";
            this.btnOrdering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdering.UseVisualStyleBackColor = false;
            this.btnOrdering.Click += new System.EventHandler(this.btnOrdering_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.Transparent;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Image = global::coffeeshopms.Properties.Resources.icons8_new_item_35;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.Location = new System.Drawing.Point(6, 316);
            this.btnItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(223, 73);
            this.btnItem.TabIndex = 10;
            this.btnItem.Text = "          Item";
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::coffeeshopms.Properties.Resources.icons8_sign_out_40;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 666);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 38);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "          LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::coffeeshopms.Properties.Resources.icons8_menu_rounded_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "         MENU";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::coffeeshopms.Properties.Resources.icons8_male_user_42;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(6, 542);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(226, 70);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "          User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::coffeeshopms.Properties.Resources.icons8_staff_40;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(6, 470);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(226, 67);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "          Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::coffeeshopms.Properties.Resources.icons8_product_40;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(6, 234);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(223, 74);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "          Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::coffeeshopms.Properties.Resources.icons8_restaurant_menu_40;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(6, 393);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(226, 73);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "          Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::coffeeshopms.Properties.Resources.icons8_dashboard_35;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 80);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(226, 76);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnBackHome);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.lbUserType);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(82, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 41);
            this.panel1.TabIndex = 19;
            // 
            // btnBackHome
            // 
            this.btnBackHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackHome.BackColor = System.Drawing.Color.Transparent;
            this.btnBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHome.FlatAppearance.BorderSize = 0;
            this.btnBackHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBackHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Metal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Image = global::coffeeshopms.Properties.Resources.icons8_forward_35;
            this.btnBackHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackHome.Location = new System.Drawing.Point(1487, -1);
            this.btnBackHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(51, 38);
            this.btnBackHome.TabIndex = 21;
            this.btnBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::coffeeshopms.Properties.Resources.icons8_sign_out_40;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-270, -6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "          LOG OUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Turquoise;
            this.lbTimer.Location = new System.Drawing.Point(668, 7);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(71, 25);
            this.lbTimer.TabIndex = 6;
            this.lbTimer.Text = "TIME :";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.BackColor = System.Drawing.Color.Transparent;
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.Turquoise;
            this.lbUserType.Location = new System.Drawing.Point(351, 6);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(161, 26);
            this.lbUserType.TabIndex = 4;
            this.lbUserType.Text = "USER TYPE :";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Turquoise;
            this.lbUsername.Location = new System.Drawing.Point(20, 3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(160, 26);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "USERNAME :";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(82, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1542, 66);
            this.panel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AKbalthom Kbach", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(608, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "អរុណសួស្ដី​ កាហ្វេ";
            // 
            // timerBar
            // 
            this.timerBar.Interval = 10;
            this.timerBar.Tick += new System.EventHandler(this.timerBar_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(107, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 330);
            this.dataGridView1.TabIndex = 21;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1624, 704);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNavbar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDashboard_FormClosed);
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.Click += new System.EventHandler(this.formDashboard_Click);
            this.panelNavbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnOrdering;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerBar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}