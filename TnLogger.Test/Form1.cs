using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TnLogger.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception(textBox1.Text);
            }
            catch(Exception ex)
            {
                LogManager.Log(ex);
            }

            GridDataBind();
        }

        private void GridDataBind()
        {
            dataGridView1.DataSource = StoreProvider.Errors;
            dataGridView1.Refresh();
        }
    }
}
