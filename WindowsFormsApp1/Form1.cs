using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<object> list = new List<object>() {
                new { name = "Test1", Address = "Test" },
                new { name = "Test2", Address = "2" },
                new { name = "Test2", Address = "3" }
            };

            userControl11.dataGridView1.DataSource = list;

            userControl11.dataGridView1_CellDoubleClickEvent += new DataGridViewCellEventHandler(dataGridView1_CellDoubleClick);
         }        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Your code for the "dataGridView_CellDoubleClick" event
        }
    }
}
