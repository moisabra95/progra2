using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using Proyecto.Users;

namespace Proyecto
{
    public partial class Container : MetroForm
    {
        frmUsers fu;
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            fu = new frmUsers();
            fu.MdiParent = this;
        }


        private void Container_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuUsers_Click(object sender, EventArgs e)
        {
            //this.metroContextMenu1.Show(btnMenuUsers, 0, btnMenuUsers.Height);
            fu.Theme = this.Theme;
            fu.Style = this.Style;
            fu.Show();
        }
    }
}
