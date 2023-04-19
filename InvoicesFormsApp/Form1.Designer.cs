namespace InvoicesFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorAddress1Label;
            System.Windows.Forms.Label vendorAddress2Label;
            System.Windows.Forms.Label vendorCityLabel;
            System.Windows.Forms.Label vendorStateLabel;
            System.Windows.Forms.Label vendorZipCodeLabel;
            System.Windows.Forms.Label vendorPhoneLabel;
            System.Windows.Forms.Label vendorContactLNameLabel;
            System.Windows.Forms.Label vendorContactFNameLabel;
            System.Windows.Forms.Label defaultTermsIDLabel;
            System.Windows.Forms.Label defaultAccountNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.invoicesDataSet = new InvoicesFormsApp.invoicesDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new InvoicesFormsApp.invoicesDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new InvoicesFormsApp.invoicesDataSetTableAdapters.TableAdapterManager();
            this.termsTableAdapter = new InvoicesFormsApp.invoicesDataSetTableAdapters.TermsTableAdapter();
            this.vendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorAddress1TextBox = new System.Windows.Forms.TextBox();
            this.vendorAddress2TextBox = new System.Windows.Forms.TextBox();
            this.vendorCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorStateTextBox = new System.Windows.Forms.TextBox();
            this.vendorZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneTextBox = new System.Windows.Forms.TextBox();
            this.vendorContactLNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorContactFNameTextBox = new System.Windows.Forms.TextBox();
            this.defaultTermsIDComboBox = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultAccountNoTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new InvoicesFormsApp.invoicesDataSetTableAdapters.InvoicesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.vendorsTableAdapter1 = new InvoicesFormsApp.invoicesDataSetTableAdapters.VendorsTableAdapter();
            vendorIDLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorAddress1Label = new System.Windows.Forms.Label();
            vendorAddress2Label = new System.Windows.Forms.Label();
            vendorCityLabel = new System.Windows.Forms.Label();
            vendorStateLabel = new System.Windows.Forms.Label();
            vendorZipCodeLabel = new System.Windows.Forms.Label();
            vendorPhoneLabel = new System.Windows.Forms.Label();
            vendorContactLNameLabel = new System.Windows.Forms.Label();
            vendorContactFNameLabel = new System.Windows.Forms.Label();
            defaultTermsIDLabel = new System.Windows.Forms.Label();
            defaultAccountNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(68, 67);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 1;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(68, 93);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(75, 13);
            vendorNameLabel.TabIndex = 3;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorAddress1Label
            // 
            vendorAddress1Label.AutoSize = true;
            vendorAddress1Label.Location = new System.Drawing.Point(68, 119);
            vendorAddress1Label.Name = "vendorAddress1Label";
            vendorAddress1Label.Size = new System.Drawing.Size(91, 13);
            vendorAddress1Label.TabIndex = 5;
            vendorAddress1Label.Text = "Vendor Address1:";
            // 
            // vendorAddress2Label
            // 
            vendorAddress2Label.AutoSize = true;
            vendorAddress2Label.Location = new System.Drawing.Point(68, 145);
            vendorAddress2Label.Name = "vendorAddress2Label";
            vendorAddress2Label.Size = new System.Drawing.Size(91, 13);
            vendorAddress2Label.TabIndex = 7;
            vendorAddress2Label.Text = "Vendor Address2:";
            // 
            // vendorCityLabel
            // 
            vendorCityLabel.AutoSize = true;
            vendorCityLabel.Location = new System.Drawing.Point(68, 171);
            vendorCityLabel.Name = "vendorCityLabel";
            vendorCityLabel.Size = new System.Drawing.Size(64, 13);
            vendorCityLabel.TabIndex = 9;
            vendorCityLabel.Text = "Vendor City:";
            // 
            // vendorStateLabel
            // 
            vendorStateLabel.AutoSize = true;
            vendorStateLabel.Location = new System.Drawing.Point(357, 63);
            vendorStateLabel.Name = "vendorStateLabel";
            vendorStateLabel.Size = new System.Drawing.Size(72, 13);
            vendorStateLabel.TabIndex = 11;
            vendorStateLabel.Text = "Vendor State:";
            // 
            // vendorZipCodeLabel
            // 
            vendorZipCodeLabel.AutoSize = true;
            vendorZipCodeLabel.Location = new System.Drawing.Point(357, 89);
            vendorZipCodeLabel.Name = "vendorZipCodeLabel";
            vendorZipCodeLabel.Size = new System.Drawing.Size(90, 13);
            vendorZipCodeLabel.TabIndex = 13;
            vendorZipCodeLabel.Text = "Vendor Zip Code:";
            // 
            // vendorPhoneLabel
            // 
            vendorPhoneLabel.AutoSize = true;
            vendorPhoneLabel.Location = new System.Drawing.Point(357, 115);
            vendorPhoneLabel.Name = "vendorPhoneLabel";
            vendorPhoneLabel.Size = new System.Drawing.Size(78, 13);
            vendorPhoneLabel.TabIndex = 15;
            vendorPhoneLabel.Text = "Vendor Phone:";
            // 
            // vendorContactLNameLabel
            // 
            vendorContactLNameLabel.AutoSize = true;
            vendorContactLNameLabel.Location = new System.Drawing.Point(357, 141);
            vendorContactLNameLabel.Name = "vendorContactLNameLabel";
            vendorContactLNameLabel.Size = new System.Drawing.Size(121, 13);
            vendorContactLNameLabel.TabIndex = 17;
            vendorContactLNameLabel.Text = "Vendor Contact LName:";
            // 
            // vendorContactFNameLabel
            // 
            vendorContactFNameLabel.AutoSize = true;
            vendorContactFNameLabel.Location = new System.Drawing.Point(357, 167);
            vendorContactFNameLabel.Name = "vendorContactFNameLabel";
            vendorContactFNameLabel.Size = new System.Drawing.Size(121, 13);
            vendorContactFNameLabel.TabIndex = 19;
            vendorContactFNameLabel.Text = "Vendor Contact FName:";
            // 
            // defaultTermsIDLabel
            // 
            defaultTermsIDLabel.AutoSize = true;
            defaultTermsIDLabel.Location = new System.Drawing.Point(357, 193);
            defaultTermsIDLabel.Name = "defaultTermsIDLabel";
            defaultTermsIDLabel.Size = new System.Drawing.Size(90, 13);
            defaultTermsIDLabel.TabIndex = 21;
            defaultTermsIDLabel.Text = "Default Terms ID:";
            // 
            // defaultAccountNoLabel
            // 
            defaultAccountNoLabel.AutoSize = true;
            defaultAccountNoLabel.Location = new System.Drawing.Point(68, 197);
            defaultAccountNoLabel.Name = "defaultAccountNoLabel";
            defaultAccountNoLabel.Size = new System.Drawing.Size(104, 13);
            defaultAccountNoLabel.TabIndex = 23;
            defaultAccountNoLabel.Text = "Default Account No:";
            // 
            // invoicesDataSet
            // 
            this.invoicesDataSet.DataSetName = "invoicesDataSet";
            this.invoicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.invoicesDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactUpdatesTableAdapter = null;
            this.tableAdapterManager.GLAccountsTableAdapter = null;
            this.tableAdapterManager.InvoiceArchiveTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.TermsTableAdapter = this.termsTableAdapter;
            this.tableAdapterManager.UpdateOrder = InvoicesFormsApp.invoicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsBindingNavigator
            // 
            this.vendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorsBindingNavigator.BindingSource = this.vendorsBindingSource;
            this.vendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendorsBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.vendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorsBindingNavigator.Name = "vendorsBindingNavigator";
            this.vendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(709, 25);
            this.vendorsBindingNavigator.TabIndex = 0;
            this.vendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vendorsBindingNavigatorSaveItem
            // 
            this.vendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorsBindingNavigatorSaveItem.Image")));
            this.vendorsBindingNavigatorSaveItem.Name = "vendorsBindingNavigatorSaveItem";
            this.vendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDTextBox.Location = new System.Drawing.Point(195, 64);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorIDTextBox.TabIndex = 2;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(195, 90);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorNameTextBox.TabIndex = 4;
            // 
            // vendorAddress1TextBox
            // 
            this.vendorAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorAddress1", true));
            this.vendorAddress1TextBox.Location = new System.Drawing.Point(195, 116);
            this.vendorAddress1TextBox.Name = "vendorAddress1TextBox";
            this.vendorAddress1TextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorAddress1TextBox.TabIndex = 6;
            // 
            // vendorAddress2TextBox
            // 
            this.vendorAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorAddress2", true));
            this.vendorAddress2TextBox.Location = new System.Drawing.Point(195, 142);
            this.vendorAddress2TextBox.Name = "vendorAddress2TextBox";
            this.vendorAddress2TextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorAddress2TextBox.TabIndex = 8;
            // 
            // vendorCityTextBox
            // 
            this.vendorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorCity", true));
            this.vendorCityTextBox.Location = new System.Drawing.Point(195, 168);
            this.vendorCityTextBox.Name = "vendorCityTextBox";
            this.vendorCityTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorCityTextBox.TabIndex = 10;
            // 
            // vendorStateTextBox
            // 
            this.vendorStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorState", true));
            this.vendorStateTextBox.Location = new System.Drawing.Point(484, 60);
            this.vendorStateTextBox.Name = "vendorStateTextBox";
            this.vendorStateTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorStateTextBox.TabIndex = 12;
            // 
            // vendorZipCodeTextBox
            // 
            this.vendorZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorZipCode", true));
            this.vendorZipCodeTextBox.Location = new System.Drawing.Point(484, 86);
            this.vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            this.vendorZipCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorZipCodeTextBox.TabIndex = 14;
            // 
            // vendorPhoneTextBox
            // 
            this.vendorPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorPhone", true));
            this.vendorPhoneTextBox.Location = new System.Drawing.Point(484, 112);
            this.vendorPhoneTextBox.Name = "vendorPhoneTextBox";
            this.vendorPhoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorPhoneTextBox.TabIndex = 16;
            // 
            // vendorContactLNameTextBox
            // 
            this.vendorContactLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorContactLName", true));
            this.vendorContactLNameTextBox.Location = new System.Drawing.Point(484, 138);
            this.vendorContactLNameTextBox.Name = "vendorContactLNameTextBox";
            this.vendorContactLNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorContactLNameTextBox.TabIndex = 18;
            // 
            // vendorContactFNameTextBox
            // 
            this.vendorContactFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorContactFName", true));
            this.vendorContactFNameTextBox.Location = new System.Drawing.Point(484, 164);
            this.vendorContactFNameTextBox.Name = "vendorContactFNameTextBox";
            this.vendorContactFNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendorContactFNameTextBox.TabIndex = 20;
            // 
            // defaultTermsIDComboBox
            // 
            this.defaultTermsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "DefaultTermsID", true));
            this.defaultTermsIDComboBox.DataSource = this.termsBindingSource;
            this.defaultTermsIDComboBox.DisplayMember = "TermsDescription";
            this.defaultTermsIDComboBox.FormattingEnabled = true;
            this.defaultTermsIDComboBox.Location = new System.Drawing.Point(484, 190);
            this.defaultTermsIDComboBox.Name = "defaultTermsIDComboBox";
            this.defaultTermsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultTermsIDComboBox.TabIndex = 22;
            this.defaultTermsIDComboBox.ValueMember = "TermsID";
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.invoicesDataSet;
            // 
            // defaultAccountNoTextBox
            // 
            this.defaultAccountNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "DefaultAccountNo", true));
            this.defaultAccountNoTextBox.Location = new System.Drawing.Point(195, 194);
            this.defaultAccountNoTextBox.Name = "defaultAccountNoTextBox";
            this.defaultAccountNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.defaultAccountNoTextBox.TabIndex = 24;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.InvoiceNumber,
            this.PaymentTotal,
            this.InvoiceDueDate,
            this.PaymentDate,
            this.Column1,
            this.vendorIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoicesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 325);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "InvoiceID";
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "InvoiceNumber";
            this.InvoiceNumber.Name = "InvoiceNumber";
            // 
            // PaymentTotal
            // 
            this.PaymentTotal.DataPropertyName = "PaymentTotal";
            this.PaymentTotal.HeaderText = "PaymentTotal";
            this.PaymentTotal.Name = "PaymentTotal";
            // 
            // InvoiceDueDate
            // 
            this.InvoiceDueDate.DataPropertyName = "InvoiceDueDate";
            this.InvoiceDueDate.HeaderText = "InvoiceDueDate";
            this.InvoiceDueDate.Name = "InvoiceDueDate";
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "PaymentDate";
            this.PaymentDate.Name = "PaymentDate";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Детали";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Просмотр";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Vendors";
            this.invoicesBindingSource.DataSource = this.vendorsBindingSource;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendorsTableAdapter1
            // 
            this.vendorsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorAddress1Label);
            this.Controls.Add(this.vendorAddress1TextBox);
            this.Controls.Add(vendorAddress2Label);
            this.Controls.Add(this.vendorAddress2TextBox);
            this.Controls.Add(vendorCityLabel);
            this.Controls.Add(this.vendorCityTextBox);
            this.Controls.Add(vendorStateLabel);
            this.Controls.Add(this.vendorStateTextBox);
            this.Controls.Add(vendorZipCodeLabel);
            this.Controls.Add(this.vendorZipCodeTextBox);
            this.Controls.Add(vendorPhoneLabel);
            this.Controls.Add(this.vendorPhoneTextBox);
            this.Controls.Add(vendorContactLNameLabel);
            this.Controls.Add(this.vendorContactLNameTextBox);
            this.Controls.Add(vendorContactFNameLabel);
            this.Controls.Add(this.vendorContactFNameTextBox);
            this.Controls.Add(defaultTermsIDLabel);
            this.Controls.Add(this.defaultTermsIDComboBox);
            this.Controls.Add(defaultAccountNoLabel);
            this.Controls.Add(this.defaultAccountNoTextBox);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private invoicesDataSet invoicesDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private invoicesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private invoicesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendorsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorAddress1TextBox;
        private System.Windows.Forms.TextBox vendorAddress2TextBox;
        private System.Windows.Forms.TextBox vendorCityTextBox;
        private System.Windows.Forms.TextBox vendorStateTextBox;
        private System.Windows.Forms.TextBox vendorZipCodeTextBox;
        private System.Windows.Forms.TextBox vendorPhoneTextBox;
        private System.Windows.Forms.TextBox vendorContactLNameTextBox;
        private System.Windows.Forms.TextBox vendorContactFNameTextBox;
        private System.Windows.Forms.ComboBox defaultTermsIDComboBox;
        private System.Windows.Forms.TextBox defaultAccountNoTextBox;
        private invoicesDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private invoicesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private invoicesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter1;
    }
}

