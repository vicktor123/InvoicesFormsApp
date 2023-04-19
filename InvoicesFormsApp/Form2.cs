using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var ID = (int)this.Tag;
            this.Text = $"Просмотр по счету: {ID}";
            try
            {
                this.invoiceLineItemsTableAdapter1.FillBy(
                    invoicesDataSet1.InvoiceLineItems,ID);


            }
            catch (Exception ex)
            {
                MessageBox.Show("");

            }
        }
    }
}
