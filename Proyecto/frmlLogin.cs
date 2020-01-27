using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Proyecto
{
    public partial class frmlLogin : MetroForm
    {
        public frmlLogin()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Container c = new Container();
            c.Show();
            this.Hide();

        }

        private void frmlLogin_Load(object sender, EventArgs e)
        { 
        }
    }
}
