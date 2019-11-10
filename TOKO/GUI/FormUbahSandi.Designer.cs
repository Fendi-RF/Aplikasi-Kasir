namespace TOKO.GUI
{
    partial class FormUbahSandi
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
            this.textBox_PasswordBaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_UbahPassword = new System.Windows.Forms.Button();
            this.textBox_PasswordLama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_KonfPasswordBaru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_PasswordBaru
            // 
            this.textBox_PasswordBaru.Location = new System.Drawing.Point(139, 76);
            this.textBox_PasswordBaru.Name = "textBox_PasswordBaru";
            this.textBox_PasswordBaru.PasswordChar = '*';
            this.textBox_PasswordBaru.Size = new System.Drawing.Size(141, 20);
            this.textBox_PasswordBaru.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kata sandi baru :";
            // 
            // button_UbahPassword
            // 
            this.button_UbahPassword.Location = new System.Drawing.Point(109, 180);
            this.button_UbahPassword.Name = "button_UbahPassword";
            this.button_UbahPassword.Size = new System.Drawing.Size(67, 23);
            this.button_UbahPassword.TabIndex = 19;
            this.button_UbahPassword.Text = "Ubah";
            this.button_UbahPassword.UseVisualStyleBackColor = true;
            this.button_UbahPassword.Click += new System.EventHandler(this.button_UbahPassword_Click);
            // 
            // textBox_PasswordLama
            // 
            this.textBox_PasswordLama.Location = new System.Drawing.Point(139, 25);
            this.textBox_PasswordLama.Name = "textBox_PasswordLama";
            this.textBox_PasswordLama.PasswordChar = '*';
            this.textBox_PasswordLama.Size = new System.Drawing.Size(141, 20);
            this.textBox_PasswordLama.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = " Kata sandi lama :";
            // 
            // textBox_KonfPasswordBaru
            // 
            this.textBox_KonfPasswordBaru.Location = new System.Drawing.Point(139, 133);
            this.textBox_KonfPasswordBaru.Name = "textBox_KonfPasswordBaru";
            this.textBox_KonfPasswordBaru.PasswordChar = '*';
            this.textBox_KonfPasswordBaru.Size = new System.Drawing.Size(141, 20);
            this.textBox_KonfPasswordBaru.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "kata sandi baru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = " Konfirmasi";
            // 
            // FormUbahSandi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_KonfPasswordBaru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PasswordBaru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_UbahPassword);
            this.Controls.Add(this.textBox_PasswordLama);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUbahSandi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUbahSandi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_PasswordBaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_UbahPassword;
        private System.Windows.Forms.TextBox textBox_PasswordLama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KonfPasswordBaru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}