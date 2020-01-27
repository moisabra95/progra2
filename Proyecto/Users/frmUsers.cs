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
using Proyecto.Tools;

namespace Proyecto.Users
{
    public partial class frmUsers : MetroForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.setTeme();
        }

        private void setTeme()
        {
            MyTools.labelSetTheme(lblPassword, this);
            MyTools.labelSetTheme(lblUser, this);
            MyTools.labelSetTheme(lblName, this);
            MyTools.labelSetTheme(lblLastName, this);
            MyTools.btnSetTheme(btnDelete, this);
            MyTools.btnSetTheme(btnSave, this);
            MyTools.textSetTheme(txtFind, this);
            MyTools.textSetTheme(txtPassword, this);
            MyTools.textSetTheme(txtUser, this);
            MyTools.textSetTheme(txtName, this);
            MyTools.textSetTheme(txtLastName, this);
            MyTools.gridSetTheme(gridUsers, this);

        }


    }
}
