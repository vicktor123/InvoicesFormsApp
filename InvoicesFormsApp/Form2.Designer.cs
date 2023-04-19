namespace InvoicesFormsApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceLineItemsTableAdapter1 = new InvoicesFormsApp.invoicesDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.invoicesDataSet1 = new InvoicesFormsApp.invoicesDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceSequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLineItemAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLineItemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.invoiceSequenceDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.invoiceLineItemAmountDataGridViewTextBoxColumn,
            this.invoiceLineItemDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoiceLineItemsTableAdapter1
            // 
            this.invoiceLineItemsTableAdapter1.ClearBeforeFill = true;
            // 
            // invoicesDataSet1
            // 
            this.invoicesDataSet1.DataSetName = "invoicesDataSet";
            this.invoicesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "InvoiceLineItems";
            this.bindingSource1.DataSource = this.invoicesDataSet1;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // invoiceSequenceDataGridViewTextBoxColumn
            // 
            this.invoiceSequenceDataGridViewTextBoxColumn.DataPropertyName = "InvoiceSequence";
            this.invoiceSequenceDataGridViewTextBoxColumn.HeaderText = "InvoiceSequence";
            this.invoiceSequenceDataGridViewTextBoxColumn.Name = "invoiceSequenceDataGridViewTextBoxColumn";
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            // 
            // invoiceLineItemAmountDataGridViewTextBoxColumn
            // 
            this.invoiceLineItemAmountDataGridViewTextBoxColumn.DataPropertyName = "InvoiceLineItemAmount";
            this.invoiceLineItemAmountDataGridViewTextBoxColumn.HeaderText = "InvoiceLineItemAmount";
            this.invoiceLineItemAmountDataGridViewTextBoxColumn.Name = "invoiceLineItemAmountDataGridViewTextBoxColumn";
            // 
            // invoiceLineItemDescriptionDataGridViewTextBoxColumn
            // 
            this.invoiceLineItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "InvoiceLineItemDescription";
            this.invoiceLineItemDescriptionDataGridViewTextBoxColumn.HeaderText = "InvoiceLineItemDescription";
            this.invoiceLineItemDescriptionDataGridViewTextBoxColumn.Name = "invoiceLineItemDescriptionDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 357);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceSequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLineItemAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLineItemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private invoicesDataSet invoicesDataSet1;
        private invoicesDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter1;
    }
}