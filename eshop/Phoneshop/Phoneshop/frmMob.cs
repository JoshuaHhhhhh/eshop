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
    public partial class frmMob : Form
    {
        public frmMob()
        {
            InitializeComponent();
        }

        private void mobilesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mobilesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsEshop);

        }

        private void frmMob_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dsEshop.Mobiles”中。您可以根据需要移动或删除它。
            this.mobilesTableAdapter.Fill(this.dsEshop.Mobiles);

        }
    }
}
