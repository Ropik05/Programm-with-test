namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonlogin.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Pbutton;
            this.buttonlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonlogin.FlatAppearance.BorderSize = 0;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonlogin.Location = new System.Drawing.Point(102, 460);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(208, 82);
            this.buttonlogin.TabIndex = 1;
            this.buttonlogin.Text = "Войти";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            this.buttonlogin.MouseEnter += new System.EventHandler(this.buttonlogin_MouseEnter);
            this.buttonlogin.MouseLeave += new System.EventHandler(this.buttonlogin_MouseLeave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(151, 211);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(256, 52);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(151, 287);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(256, 52);
            this.password.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(452, 587);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
    }
}