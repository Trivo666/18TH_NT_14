
namespace DemoLogin
{
    partial class Form1
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
            this.lbluser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(186, 62);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(57, 13);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "UserName";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(262, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(186, 104);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(49, 14);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(262, 104);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(145, 20);
            this.txtPass.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 297);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lbluser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
    }
}

