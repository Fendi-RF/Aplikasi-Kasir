namespace TOKO.GUI
{
    partial class FormTambahAkun
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
            this.button_TambahAkun = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Kelas = new System.Windows.Forms.ComboBox();
            this.textBox_KonfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_TambahAkun
            // 
            this.button_TambahAkun.Location = new System.Drawing.Point(90, 210);
            this.button_TambahAkun.Name = "button_TambahAkun";
            this.button_TambahAkun.Size = new System.Drawing.Size(92, 23);
            this.button_TambahAkun.TabIndex = 9;
            this.button_TambahAkun.Text = "Tambah Akun";
            this.button_TambahAkun.UseVisualStyleBackColor = true;
            this.button_TambahAkun.Click += new System.EventHandler(this.button_TambahAkun_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(134, 74);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(141, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(134, 26);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(141, 20);
            this.textBox_User.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kata sandi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Pengguna :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kelas :";
            // 
            // comboBox_Kelas
            // 
            this.comboBox_Kelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kelas.FormattingEnabled = true;
            this.comboBox_Kelas.Items.AddRange(new object[] {
            "Admin",
            "Kasir"});
            this.comboBox_Kelas.Location = new System.Drawing.Point(134, 168);
            this.comboBox_Kelas.Name = "comboBox_Kelas";
            this.comboBox_Kelas.Size = new System.Drawing.Size(97, 21);
            this.comboBox_Kelas.TabIndex = 11;
            // 
            // textBox_KonfPassword
            // 
            this.textBox_KonfPassword.Location = new System.Drawing.Point(134, 124);
            this.textBox_KonfPassword.Name = "textBox_KonfPassword";
            this.textBox_KonfPassword.PasswordChar = '*';
            this.textBox_KonfPassword.Size = new System.Drawing.Size(141, 20);
            this.textBox_KonfPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kata sandi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Konfirmasi";
            // 
            // FormTambahAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_KonfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Kelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_TambahAkun);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahAkun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahAkun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_TambahAkun;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Kelas;
        private System.Windows.Forms.TextBox textBox_KonfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}