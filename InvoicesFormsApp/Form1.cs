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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoicesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invoicesDataSet.Invoices". При необходимости она может быть перемещена или удалена.
            this.invoicesTableAdapter.Fill(this.invoicesDataSet.Invoices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invoicesDataSet.Terms". При необходимости она может быть перемещена или удалена.
            this.termsTableAdapter.Fill(this.invoicesDataSet.Terms);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "invoicesDataSet.Vendors". При необходимости она может быть перемещена или удалена.
            this.vendorsTableAdapter.Fill(this.invoicesDataSet.Vendors);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.invoicesTableAdapter.Fill(this.invoicesDataSet.Invoices);
                this.vendorsTableAdapter.FillByVenID(
                    this.invoicesDataSet.Vendors,
                    ((int)(Convert.ChangeType(toolStripTextBox1.Text,
                    typeof(int)))));
                invoicesBindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.vendorsTableAdapter.Fill(this.invoicesDataSet.Vendors);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row != null) {
                    int invID = (int)row.Cells[0].Value;
                    Form2 frm2 = new Form2();
                    frm2.Tag = invID;
                    frm2.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form3()).ShowDialog();
        }
    }
}
