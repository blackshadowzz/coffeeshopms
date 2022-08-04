namespace coffeeshopms
{
    partial class formProductIsDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRestoreOne = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMorningCoffee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(8, 58);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(158, 25);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search by Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1026, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(880, 30);
            this.txtSearch.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.btnRestoreAll);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnRestoreOne);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 570);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 33);
            this.panel3.TabIndex = 21;
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRestoreAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreAll.FlatAppearance.BorderSize = 0;
            this.btnRestoreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.White;
            this.btnRestoreAll.Location = new System.Drawing.Point(876, 0);
            this.btnRestoreAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(130, 33);
            this.btnRestoreAll.TabIndex = 10;
            this.btnRestoreAll.Text = "Restore All";
            this.btnRestoreAll.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::coffeeshopms.Properties.Resources.icons8_back_35;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 33);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRestoreOne
            // 
            this.btnRestoreOne.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRestoreOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreOne.FlatAppearance.BorderSize = 0;
            this.btnRestoreOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreOne.ForeColor = System.Drawing.Color.White;
            this.btnRestoreOne.Location = new System.Drawing.Point(1010, 2);
            this.btnRestoreOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreOne.Name = "btnRestoreOne";
            this.btnRestoreOne.Size = new System.Drawing.Size(105, 31);
            this.btnRestoreOne.TabIndex = 8;
            this.btnRestoreOne.Text = "Restore";
            this.btnRestoreOne.UseVisualStyleBackColor = false;
            this.btnRestoreOne.Click += new System.EventHandler(this.btnRestoreOne_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lbMorningCoffee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 36);
            this.panel1.TabIndex = 20;
            // 
            // lbMorningCoffee
            // 
            this.lbMorningCoffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMorningCoffee.AutoSize = true;
            this.lbMorningCoffee.Font = new System.Drawing.Font("AKbalthom Kbach", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMorningCoffee.ForeColor = System.Drawing.Color.White;
            this.lbMorningCoffee.Location = new System.Drawing.Point(467, -2);
            this.lbMorningCoffee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMorningCoffee.Name = "lbMorningCoffee";
            this.lbMorningCoffee.Size = new System.Drawing.Size(273, 55);
            this.lbMorningCoffee.TabIndex = 1;
            this.lbMorningCoffee.Text = "Product Restore";
            // 
            // formProductIsDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formProductIsDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProductIsDelete";
            this.Load += new System.EventHandler(this.formProductIsDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRestoreOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMorningCoffee;
    }
}