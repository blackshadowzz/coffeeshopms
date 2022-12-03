namespace coffeeshopms
{
    partial class formViewOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbUnitPayRiel = new System.Windows.Forms.Label();
            this.lbPayTotalRiel = new System.Windows.Forms.Label();
            this.lbUnitPayDollar = new System.Windows.Forms.Label();
            this.lbPayTotalDollar = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.btnAllPrice = new System.Windows.Forms.Button();
            this.btnUnitPrice = new System.Windows.Forms.Button();
            this.lbPayment = new System.Windows.Forms.Label();
            this.txtDiscountUnit = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbRemark = new System.Windows.Forms.RichTextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picOrdering = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdering)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colMenuID,
            this.colQty,
            this.colPrice,
            this.colTotal,
            this.colImage});
            this.dataGridView1.Location = new System.Drawing.Point(6, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 562);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID.FillWeight = 70F;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 70;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.FillWeight = 76.98829F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 140;
            // 
            // colMenuID
            // 
            this.colMenuID.FillWeight = 4.966988F;
            this.colMenuID.HeaderText = "MenuID";
            this.colMenuID.MinimumWidth = 6;
            this.colMenuID.Name = "colMenuID";
            this.colMenuID.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 4.966988F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 4.966988F;
            this.colTotal.HeaderText = "Total Price";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colImage.FillWeight = 160F;
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 140;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lbUnitPayRiel);
            this.panel4.Controls.Add(this.lbPayTotalRiel);
            this.panel4.Controls.Add(this.lbUnitPayDollar);
            this.panel4.Controls.Add(this.lbPayTotalDollar);
            this.panel4.Controls.Add(this.lbUnitPrice);
            this.panel4.Controls.Add(this.btnAllPrice);
            this.panel4.Controls.Add(this.btnUnitPrice);
            this.panel4.Controls.Add(this.lbPayment);
            this.panel4.Controls.Add(this.txtDiscountUnit);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtTotalDiscount);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(747, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 252);
            this.panel4.TabIndex = 15;
            // 
            // lbUnitPayRiel
            // 
            this.lbUnitPayRiel.AutoSize = true;
            this.lbUnitPayRiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPayRiel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUnitPayRiel.Location = new System.Drawing.Point(438, 203);
            this.lbUnitPayRiel.Name = "lbUnitPayRiel";
            this.lbUnitPayRiel.Size = new System.Drawing.Size(123, 29);
            this.lbUnitPayRiel.TabIndex = 37;
            this.lbUnitPayRiel.Text = "Unit Price";
            // 
            // lbPayTotalRiel
            // 
            this.lbPayTotalRiel.AutoSize = true;
            this.lbPayTotalRiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayTotalRiel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPayTotalRiel.Location = new System.Drawing.Point(219, 203);
            this.lbPayTotalRiel.Name = "lbPayTotalRiel";
            this.lbPayTotalRiel.Size = new System.Drawing.Size(134, 29);
            this.lbPayTotalRiel.TabIndex = 36;
            this.lbPayTotalRiel.Text = "Total Price";
            // 
            // lbUnitPayDollar
            // 
            this.lbUnitPayDollar.AutoSize = true;
            this.lbUnitPayDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPayDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUnitPayDollar.Location = new System.Drawing.Point(437, 165);
            this.lbUnitPayDollar.Name = "lbUnitPayDollar";
            this.lbUnitPayDollar.Size = new System.Drawing.Size(123, 29);
            this.lbUnitPayDollar.TabIndex = 35;
            this.lbUnitPayDollar.Text = "Unit Price";
            // 
            // lbPayTotalDollar
            // 
            this.lbPayTotalDollar.AutoSize = true;
            this.lbPayTotalDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayTotalDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPayTotalDollar.Location = new System.Drawing.Point(218, 165);
            this.lbPayTotalDollar.Name = "lbPayTotalDollar";
            this.lbPayTotalDollar.Size = new System.Drawing.Size(134, 29);
            this.lbPayTotalDollar.TabIndex = 34;
            this.lbPayTotalDollar.Text = "Total Price";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUnitPrice.Location = new System.Drawing.Point(426, 16);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(123, 29);
            this.lbUnitPrice.TabIndex = 32;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // btnAllPrice
            // 
            this.btnAllPrice.BackColor = System.Drawing.Color.Turquoise;
            this.btnAllPrice.FlatAppearance.BorderSize = 0;
            this.btnAllPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPrice.ForeColor = System.Drawing.Color.Black;
            this.btnAllPrice.Location = new System.Drawing.Point(212, 99);
            this.btnAllPrice.Name = "btnAllPrice";
            this.btnAllPrice.Size = new System.Drawing.Size(188, 40);
            this.btnAllPrice.TabIndex = 33;
            this.btnAllPrice.Text = "Calculate";
            this.btnAllPrice.UseVisualStyleBackColor = false;
            this.btnAllPrice.Click += new System.EventHandler(this.btnAllPrice_Click);
            // 
            // btnUnitPrice
            // 
            this.btnUnitPrice.BackColor = System.Drawing.Color.Turquoise;
            this.btnUnitPrice.FlatAppearance.BorderSize = 0;
            this.btnUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.btnUnitPrice.Location = new System.Drawing.Point(427, 98);
            this.btnUnitPrice.Name = "btnUnitPrice";
            this.btnUnitPrice.Size = new System.Drawing.Size(172, 40);
            this.btnUnitPrice.TabIndex = 32;
            this.btnUnitPrice.Text = "Calculate";
            this.btnUnitPrice.UseVisualStyleBackColor = false;
            this.btnUnitPrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPayment.Location = new System.Drawing.Point(207, 16);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(134, 29);
            this.lbPayment.TabIndex = 17;
            this.lbPayment.Text = "Total Price";
            // 
            // txtDiscountUnit
            // 
            this.txtDiscountUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountUnit.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountUnit.Location = new System.Drawing.Point(427, 63);
            this.txtDiscountUnit.Name = "txtDiscountUnit";
            this.txtDiscountUnit.Size = new System.Drawing.Size(172, 30);
            this.txtDiscountUnit.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(29, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 3);
            this.panel5.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Discount (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Payment (Riel)";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalDiscount.Location = new System.Drawing.Point(212, 63);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.Size = new System.Drawing.Size(188, 30);
            this.txtTotalDiscount.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Payment (Dollar)";
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Location = new System.Drawing.Point(1205, 571);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(158, 40);
            this.btnSaveRecord.TabIndex = 29;
            this.btnSaveRecord.Text = "Save Record";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(749, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Remark";
            // 
            // rbRemark
            // 
            this.rbRemark.Location = new System.Drawing.Point(896, 212);
            this.rbRemark.Name = "rbRemark";
            this.rbRemark.Size = new System.Drawing.Size(204, 82);
            this.rbRemark.TabIndex = 27;
            this.rbRemark.Text = "";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(896, 170);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(204, 30);
            this.txtQty.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(749, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(896, 128);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(204, 30);
            this.txtUnitPrice.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(749, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Unit Price";
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(896, 86);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(204, 30);
            this.txtItemName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(749, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(896, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 30);
            this.txtID.TabIndex = 18;
            // 
            // picOrdering
            // 
            this.picOrdering.BackgroundImage = global::coffeeshopms.Properties.Resources.image_not_found_1_scaled_1150x647;
            this.picOrdering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOrdering.Location = new System.Drawing.Point(1121, 4);
            this.picOrdering.Name = "picOrdering";
            this.picOrdering.Size = new System.Drawing.Size(242, 241);
            this.picOrdering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrdering.TabIndex = 17;
            this.picOrdering.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(749, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(749, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Order By";
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Location = new System.Drawing.Point(896, 45);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(204, 33);
            this.cbOrderBy.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 571);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 40);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back To Order";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(1052, 571);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(126, 40);
            this.btnPrintInvoice.TabIndex = 33;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // formViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1374, 615);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbRemark);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.picOrdering);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formViewOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnUnitTotalPrice_FormClosing);
            this.Load += new System.EventHandler(this.formViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdering)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rbRemark;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picOrdering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Button btnUnitPrice;
        private System.Windows.Forms.TextBox txtDiscountUnit;
        private System.Windows.Forms.Button btnAllPrice;
        private System.Windows.Forms.Label lbUnitPayRiel;
        private System.Windows.Forms.Label lbPayTotalRiel;
        private System.Windows.Forms.Label lbUnitPayDollar;
        private System.Windows.Forms.Label lbPayTotalDollar;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}