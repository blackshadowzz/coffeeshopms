namespace coffeeshopms
{
    partial class loginForm
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
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateUser.Location = new System.Drawing.Point(691, 554);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(165, 39);
            this.btnCreateUser.TabIndex = 11;
            this.btnCreateUser.Text = "Create Account";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 619);
            this.Controls.Add(this.btnCreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
    }
}