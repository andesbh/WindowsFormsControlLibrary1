using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsControlLibrary1.UserControl1;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public event DataGridViewCellEventHandler dataGridView1_CellDoubleClickEvent;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClickEvent;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellDoubleClickEvent?.Invoke(this.dataGridView1, e);
        }
    }
}
