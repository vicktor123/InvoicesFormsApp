using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesFormsApp
{
    public partial class Form3 : Form
    {
        int invoiceSequence = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invoicesDataSet.InvoiceLineItems". При необходимости она может быть перемещена или удалена.
            //this.invoiceLineItemsTableAdapter.Fill(this.invoicesDataSet.InvoiceLineItems);
            // this.invoicesTableAdapter.Fill(this.invoicesDataSet.Invoices);
            //toolStripTextBox1.Focus();
            comboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;

            this.termsTableAdapter.Fill(this.invoicesDataSet.Terms);
            comboBox1.SelectedIndex = -1;
            

        
            this.gLAccountsTableAdapter.Fill(this.invoicesDataSet.GLAccounts);
          
            
           
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            
            DisableControls();

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            Calculate();
        }
        private void Calculate()
        {
            int termID = (int)comboBox1.SelectedValue;
            int dueDays = (int)this.termsTableAdapter.ScalarQueryDueDays(termID);

            DateTime invoiceDate = dateTimePicker1.Value;
            DateTime dueTime = invoiceDate.AddDays(dueDays);

            textBox4.Text=dueTime.ToShortDateString();
        }        
        void DisableControls()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;
            //btnAccept.Enabled = fali
            //btnCancel.Enabled = fali
        }

        void EnableControls(bool flag)
        {
            textBox1.Enabled = flag;
            textBox2.Enabled = flag;
            textBox3.Enabled = flag;
            dateTimePicker1.Enabled = flag;
            comboBox1.Enabled = flag;
            comboBox2.Enabled = flag;
            textBox5.Enabled = flag;
            textBox6.Enabled = flag;
            button1.Enabled = flag;
            //btnAccept.Enabled = fali
            //btnCancel.Enabled = fali
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            try
           {
                //this.invoicesTableAdapter.Fill(this.invoicesDataSet.Invoices);

                int vendorID= (int)(Convert.ChangeType(toolStripTextBox1.Text,typeof(int)));
                this.vendorsTableAdapter.FillByVenID(
                    this.invoicesDataSet.Vendors,vendorID);
                //invoicesBindingSource.ResetBindings(true);
               
                if (this.invoicesDataSet.Vendors.Rows.Count == 0)
                {
                    MessageBox.Show($"Нет продавца с ID {toolStripTextBox1.Text}");
                    toolStripTextBox1.Clear();
                }
                else
                {
                    EnableControls(true);
                    this.bindingSource2.CancelEdit();
                   for(int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                   {
                       dataGridView1.Rows.RemoveAt(i);
                   }
                   //add invoice table
                    this.bindingSource2.AddNew();
                    textBox1.Text = toolStripTextBox1.Text;
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker1.Checked = false;
                    int IDTermsDefault = (int)this.vendorsTableAdapter.ScalarQueryIDTerms(vendorID);
                    comboBox1.SelectedValue = IDTermsDefault;
                    int IDAccountDefault = (int)this.vendorsTableAdapter.ScalarQueryIDDefaultAccount(vendorID);
                    comboBox2.SelectedValue = IDAccountDefault;

                }
                
                
                
           }
           catch (Exception ex)
           {
              MessageBox.Show(ex.Message);
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidLineItem())
            {
                bindingSource4.AddNew();
                int rowIndex = dataGridView1.Rows.Count - 1;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                DataGridViewCell cell = row.Cells[0];
                int ident = (int)this.invoicesTableAdapter.GetLastIdentityValue();
                cell.Value = ++ident;

                invoiceSequence = invoiceSequence + 1;
                cell = row.Cells[1];
                cell.Value = invoiceSequence;

                cell = row.Cells[2];
                var cb2 = comboBox2.SelectedValue;
                cell.Value = comboBox2.SelectedValue;

                cell = row.Cells[3];
                cell.Value = textBox6.Text;

                cell = row.Cells[4];
                cell.Value = textBox5.Text;

                cell = row.Cells[5];
                cell.Value = comboBox2.Text;

                //int rowIndex1= dataGridView1.Rows.Count - 1;

                //  dataGridView1.Rows.RemoveAt(0);
                // dataGridView1.AllowUserToAddRows = true;
                bindingSource4.EndEdit();

                this.GetInvoiceTotal();
                textBox5.Focus();
            }
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show($"{name} is a required field.");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"{name} must be a decimal value.");
                textBox.Focus();
                return false;
            }
        }

        private bool IsValidLineItem()
        {
            if (IsPresent(textBox5, "Descript") 
                && IsPresent(textBox6, "Amount") 
                && IsDecimal(textBox6,"Amount"))

            {
                return true;
            }
            return false;
        }
        private bool IsValiInvoice()
        {
            if (IsPresent(textBox3,"Invoice Number"))
            {
                if (dateTimePicker1.Checked)
                {
                    if (dataGridView1.Rows.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        textBox5.Focus();
                        return false;
                    }
                }
                else
                {
                    dateTimePicker1.Focus();
                    return false;
                }
            }
            return false;
        }

        private void GetInvoiceTotal()
        {
            DataGridViewCell cell;
            decimal amount;
            decimal invoiceT = 0;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                cell= row.Cells[3];
                amount=(decimal)cell.Value;
                invoiceT += amount;
            }
            invoiceTotal.Text = invoiceT.ToString("c");
            textBox7.Text= invoiceTotal.Text;
            textBox8.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValiInvoice())
            {

                this.GetInvoiceTotal();
                bindingSource2.EndEdit();
                invoicesTableAdapter.Update(this.invoicesDataSet.Invoices);


                int ident = (int)this.invoicesTableAdapter.GetLastIdentityValue();

                DataGridViewCell cell;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cell = row.Cells[0];
                    cell.Value = ident;
                }
                this.invoiceLineItemsTableAdapter.Update(invoicesDataSet.InvoiceLineItems);
                this.invoicesDataSet.Vendors.Rows.Clear();
                this.invoicesDataSet.Invoices.Rows.Clear();
                this.invoicesDataSet.InvoiceLineItems.Rows.Clear();
                invoiceSequence = 0;
            }

        }
    }
}
