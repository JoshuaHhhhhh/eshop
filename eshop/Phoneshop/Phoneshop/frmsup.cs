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
    public partial class frmSup : Form
    {
        public frmSup()
        {
            InitializeComponent();
        }

        private void frmsup_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dsEshop.Suppliers”中。您可以根据需要移动或删除它。
            this.suppliersTableAdapter.Fill(this.dsEshop.Suppliers);
            // TODO:  这行代码将数据加载到表“dsEshop.Suppliers”中。您可以根据需要移动或删除它。
            this.suppliersTableAdapter.Fill(this.dsEshop.Suppliers);

        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsEshop);

        }
    }
}
