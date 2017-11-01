using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phoneshop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmmain_Resize(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 供应商数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSup f = new frmSup();
            f.MdiParent = this;
            f.Show();
        }

        private void 手机产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMob f = new frmMob();
            f.MdiParent = this;
            f.Show();
        }
    }
}
