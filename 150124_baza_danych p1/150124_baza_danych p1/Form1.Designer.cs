namespace _150124_baza_danych_p1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label peselLabel;
            System.Windows.Forms.Label data_urodeniaLabel;
            System.Windows.Forms.Label miejscowość_urLabel;
            System.Windows.Forms.Label kodPocztowyLabel;
            System.Windows.Forms.Label miejscowoscLabel;
            System.Windows.Forms.Label adresLabel;
            this.baza_testowaDataSet1 = new _150124_baza_danych_p1.baza_testowaDataSet1();
            this.uczenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uczenTableAdapter = new _150124_baza_danych_p1.baza_testowaDataSet1TableAdapters.uczenTableAdapter();
            this.tableAdapterManager = new _150124_baza_danych_p1.baza_testowaDataSet1TableAdapters.TableAdapterManager();
            this.uczenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uczenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uczenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.data_urodeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.miejscowość_urTextBox = new System.Windows.Forms.TextBox();
            this.kodPocztowyTextBox = new System.Windows.Forms.TextBox();
            this.miejscowoscTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            peselLabel = new System.Windows.Forms.Label();
            data_urodeniaLabel = new System.Windows.Forms.Label();
            miejscowość_urLabel = new System.Windows.Forms.Label();
            kodPocztowyLabel = new System.Windows.Forms.Label();
            miejscowoscLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza_testowaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczenBindingNavigator)).BeginInit();
            this.uczenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baza_testowaDataSet1
            // 
            this.baza_testowaDataSet1.DataSetName = "baza_testowaDataSet1";
            this.baza_testowaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uczenBindingSource
            // 
            this.uczenBindingSource.DataMember = "uczen";
            this.uczenBindingSource.DataSource = this.baza_testowaDataSet1;
            // 
            // uczenTableAdapter
            // 
            this.uczenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.uczenTableAdapter = this.uczenTableAdapter;
            this.tableAdapterManager.UpdateOrder = _150124_baza_danych_p1.baza_testowaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uczenBindingNavigator
            // 
            this.uczenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uczenBindingNavigator.BindingSource = this.uczenBindingSource;
            this.uczenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uczenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uczenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uczenBindingNavigatorSaveItem});
            this.uczenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uczenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uczenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uczenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uczenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uczenBindingNavigator.Name = "uczenBindingNavigator";
            this.uczenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uczenBindingNavigator.Size = new System.Drawing.Size(1017, 25);
            this.uczenBindingNavigator.TabIndex = 0;
            this.uczenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
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
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uczenBindingNavigatorSaveItem
            // 
            this.uczenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uczenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uczenBindingNavigatorSaveItem.Image")));
            this.uczenBindingNavigatorSaveItem.Name = "uczenBindingNavigatorSaveItem";
            this.uczenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uczenBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.uczenBindingNavigatorSaveItem.Click += new System.EventHandler(this.uczenBindingNavigatorSaveItem_Click);
            // 
            // uczenDataGridView
            // 
            this.uczenDataGridView.AutoGenerateColumns = false;
            this.uczenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uczenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.uczenDataGridView.DataSource = this.uczenBindingSource;
            this.uczenDataGridView.Location = new System.Drawing.Point(320, 38);
            this.uczenDataGridView.Name = "uczenDataGridView";
            this.uczenDataGridView.Size = new System.Drawing.Size(658, 254);
            this.uczenDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Imie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nazwisko";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pesel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pesel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_urodenia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data urodenia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "miejscowość_ur";
            this.dataGridViewTextBoxColumn6.HeaderText = "Miejscowość urodzenia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kodPocztowy";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kod pocztowy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "miejscowosc";
            this.dataGridViewTextBoxColumn8.HeaderText = "Miejscowosc";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "adres";
            this.dataGridViewTextBoxColumn9.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(114, 53);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(26, 82);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(29, 13);
            imieLabel.TabIndex = 4;
            imieLabel.Text = "Imie:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "Imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(114, 79);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieTextBox.TabIndex = 5;
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(26, 108);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 6;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(114, 105);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoTextBox.TabIndex = 7;
            // 
            // peselLabel
            // 
            peselLabel.AutoSize = true;
            peselLabel.Location = new System.Drawing.Point(26, 134);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new System.Drawing.Size(35, 13);
            peselLabel.TabIndex = 8;
            peselLabel.Text = "pesel:";
            // 
            // peselTextBox
            // 
            this.peselTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "pesel", true));
            this.peselTextBox.Location = new System.Drawing.Point(114, 131);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(200, 20);
            this.peselTextBox.TabIndex = 9;
            // 
            // data_urodeniaLabel
            // 
            data_urodeniaLabel.AutoSize = true;
            data_urodeniaLabel.Location = new System.Drawing.Point(26, 161);
            data_urodeniaLabel.Name = "data_urodeniaLabel";
            data_urodeniaLabel.Size = new System.Drawing.Size(77, 13);
            data_urodeniaLabel.TabIndex = 10;
            data_urodeniaLabel.Text = "Data urodenia:";
            // 
            // data_urodeniaDateTimePicker
            // 
            this.data_urodeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uczenBindingSource, "Data_urodenia", true));
            this.data_urodeniaDateTimePicker.Location = new System.Drawing.Point(114, 157);
            this.data_urodeniaDateTimePicker.Name = "data_urodeniaDateTimePicker";
            this.data_urodeniaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_urodeniaDateTimePicker.TabIndex = 11;
            // 
            // miejscowość_urLabel
            // 
            miejscowość_urLabel.AutoSize = true;
            miejscowość_urLabel.Location = new System.Drawing.Point(26, 186);
            miejscowość_urLabel.Name = "miejscowość_urLabel";
            miejscowość_urLabel.Size = new System.Drawing.Size(82, 13);
            miejscowość_urLabel.TabIndex = 12;
            miejscowość_urLabel.Text = "miejscowość ur:";
            // 
            // miejscowość_urTextBox
            // 
            this.miejscowość_urTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "miejscowość_ur", true));
            this.miejscowość_urTextBox.Location = new System.Drawing.Point(114, 183);
            this.miejscowość_urTextBox.Name = "miejscowość_urTextBox";
            this.miejscowość_urTextBox.Size = new System.Drawing.Size(200, 20);
            this.miejscowość_urTextBox.TabIndex = 13;
            // 
            // kodPocztowyLabel
            // 
            kodPocztowyLabel.AutoSize = true;
            kodPocztowyLabel.Location = new System.Drawing.Point(26, 212);
            kodPocztowyLabel.Name = "kodPocztowyLabel";
            kodPocztowyLabel.Size = new System.Drawing.Size(77, 13);
            kodPocztowyLabel.TabIndex = 14;
            kodPocztowyLabel.Text = "kod Pocztowy:";
            // 
            // kodPocztowyTextBox
            // 
            this.kodPocztowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "kodPocztowy", true));
            this.kodPocztowyTextBox.Location = new System.Drawing.Point(114, 209);
            this.kodPocztowyTextBox.Name = "kodPocztowyTextBox";
            this.kodPocztowyTextBox.Size = new System.Drawing.Size(200, 20);
            this.kodPocztowyTextBox.TabIndex = 15;
            // 
            // miejscowoscLabel
            // 
            miejscowoscLabel.AutoSize = true;
            miejscowoscLabel.Location = new System.Drawing.Point(26, 238);
            miejscowoscLabel.Name = "miejscowoscLabel";
            miejscowoscLabel.Size = new System.Drawing.Size(70, 13);
            miejscowoscLabel.TabIndex = 16;
            miejscowoscLabel.Text = "miejscowosc:";
            // 
            // miejscowoscTextBox
            // 
            this.miejscowoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "miejscowosc", true));
            this.miejscowoscTextBox.Location = new System.Drawing.Point(114, 235);
            this.miejscowoscTextBox.Name = "miejscowoscTextBox";
            this.miejscowoscTextBox.Size = new System.Drawing.Size(200, 20);
            this.miejscowoscTextBox.TabIndex = 17;
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(26, 264);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(36, 13);
            adresLabel.TabIndex = 18;
            adresLabel.Text = "adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczenBindingSource, "adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(114, 261);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 330);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(peselLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(data_urodeniaLabel);
            this.Controls.Add(this.data_urodeniaDateTimePicker);
            this.Controls.Add(miejscowość_urLabel);
            this.Controls.Add(this.miejscowość_urTextBox);
            this.Controls.Add(kodPocztowyLabel);
            this.Controls.Add(this.kodPocztowyTextBox);
            this.Controls.Add(miejscowoscLabel);
            this.Controls.Add(this.miejscowoscTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.uczenDataGridView);
            this.Controls.Add(this.uczenBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza_testowaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczenBindingNavigator)).EndInit();
            this.uczenBindingNavigator.ResumeLayout(false);
            this.uczenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private baza_testowaDataSet1 baza_testowaDataSet1;
        private System.Windows.Forms.BindingSource uczenBindingSource;
        private baza_testowaDataSet1TableAdapters.uczenTableAdapter uczenTableAdapter;
        private baza_testowaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uczenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uczenBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uczenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.DateTimePicker data_urodeniaDateTimePicker;
        private System.Windows.Forms.TextBox miejscowość_urTextBox;
        private System.Windows.Forms.TextBox kodPocztowyTextBox;
        private System.Windows.Forms.TextBox miejscowoscTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
    }
}

