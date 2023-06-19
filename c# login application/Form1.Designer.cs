namespace c__login_application
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonsignin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(236, 125);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(302, 47);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(232, 101);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(94, 21);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(232, 190);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(90, 21);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(236, 214);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(302, 47);
            this.txtpassword.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Maroon;
            this.buttonexit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Location = new System.Drawing.Point(251, 267);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(93, 36);
            this.buttonexit.TabIndex = 4;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            // 
            // buttonsignin
            // 
            this.buttonsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonsignin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignin.ForeColor = System.Drawing.Color.White;
            this.buttonsignin.Location = new System.Drawing.Point(409, 267);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(93, 36);
            this.buttonsignin.TabIndex = 5;
            this.buttonsignin.Text = "Sign in";
            this.buttonsignin.UseVisualStyleBackColor = false;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsignin);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.txtusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonsignin;
    }
}

