using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO.GUI
{
    public partial class DialogLogin : Form
    {
        public DialogLogin()
        {
            InitializeComponent();
        }

        private void button_LoginBerhasil_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
