namespace coffeeshopms
{
    partial class createUser
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnBackTologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateUser.Location = new System.Drawing.Point(576, 371);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(165, 39);
            this.btnCreateUser.TabIndex = 11;
            this.btnCreateUser.Text = "Create Account";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // btnBackTologin
            // 
            this.btnBackTologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackTologin.FlatAppearance.BorderSize = 0;
            this.btnBackTologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackTologin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTologin.ForeColor = System.Drawing.Color.Black;
            this.btnBackTologin.Location = new System.Drawing.Point(995, 581);
            this.btnBackTologin.Name = "btnBackTologin";
            this.btnBackTologin.Size = new System.Drawing.Size(80, 39);
            this.btnBackTologin.TabIndex = 12;
            this.btnBackTologin.Text = "Back";
            this.btnBackTologin.UseVisualStyleBackColor = true;
            this.btnBackTologin.Click += new System.EventHandler(this.btnBackTologin_Click);
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 632);
            this.Controls.Add(this.btnBackTologin);
            this.Controls.Add(this.btnCreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "createUser";
            this.Text = "createUser";
            this.Load += new System.EventHandler(this.createUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnBackTologin;
    }
}