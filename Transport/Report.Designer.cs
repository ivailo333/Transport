namespace Transport
{
    partial class Report
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
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblMPS = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cmbMPS = new System.Windows.Forms.ComboBox();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblNumber_p_list = new System.Windows.Forms.Label();
            this.lblNumber_tovar = new System.Windows.Forms.Label();
            this.lblMaterial1 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.txtNumber_p_list = new System.Windows.Forms.TextBox();
            this.txtNumber_tovar = new System.Windows.Forms.TextBox();
            this.cmbMaterial1 = new System.Windows.Forms.ComboBox();
            this.lblKolichestvo1 = new System.Windows.Forms.Label();
            this.lblGorivo = new System.Windows.Forms.Label();
            this.txtKolichestvo1 = new System.Windows.Forms.TextBox();
            this.cmbMerna_edinitsa1 = new System.Windows.Forms.ComboBox();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblObjectBegin = new System.Windows.Forms.Label();
            this.cmbObjectBegin = new System.Windows.Forms.ComboBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.grdOtcheti = new System.Windows.Forms.DataGridView();
            this.txtClean = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblObjectEnd = new System.Windows.Forms.Label();
            this.cmbObjectEnd = new System.Windows.Forms.ComboBox();
            this.lblKmTovaritelnitsa = new System.Windows.Forms.Label();
            this.txtKmTovaritelnitsa = new System.Windows.Forms.TextBox();
            this.lblMaterial2 = new System.Windows.Forms.Label();
            this.lblMaterial3 = new System.Windows.Forms.Label();
            this.lblMaterial4 = new System.Windows.Forms.Label();
            this.cmbMaterial2 = new System.Windows.Forms.ComboBox();
            this.cmbMaterial3 = new System.Windows.Forms.ComboBox();
            this.cmbMaterial4 = new System.Windows.Forms.ComboBox();
            this.lblKolichestvo2 = new System.Windows.Forms.Label();
            this.lblKolichestvo3 = new System.Windows.Forms.Label();
            this.lblKolichestvo4 = new System.Windows.Forms.Label();
            this.txtKolichestvo2 = new System.Windows.Forms.TextBox();
            this.txtKolichestvo3 = new System.Windows.Forms.TextBox();
            this.txtKolichestvo4 = new System.Windows.Forms.TextBox();
            this.cmbMerna_edinitsa2 = new System.Windows.Forms.ComboBox();
            this.cmbMerna_edinitsa3 = new System.Windows.Forms.ComboBox();
            this.cmbMerna_edinitsa4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtcheti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateFrom.Location = new System.Drawing.Point(20, 40);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(65, 17);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Дата от:";
            // 
            // lblMPS
            // 
            this.lblMPS.AutoSize = true;
            this.lblMPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMPS.Location = new System.Drawing.Point(207, 40);
            this.lblMPS.Name = "lblMPS";
            this.lblMPS.Size = new System.Drawing.Size(42, 17);
            this.lblMPS.TabIndex = 1;
            this.lblMPS.Text = "МПС:";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBegin.Location = new System.Drawing.Point(374, 40);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(96, 17);
            this.lblBegin.TabIndex = 2;
            this.lblBegin.Text = "Начало (км.):";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnd.Location = new System.Drawing.Point(552, 40);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(79, 17);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Край (км.):";
            // 
            // cmbMPS
            // 
            this.cmbMPS.FormattingEnabled = true;
            this.cmbMPS.Location = new System.Drawing.Point(249, 40);
            this.cmbMPS.Name = "cmbMPS";
            this.cmbMPS.Size = new System.Drawing.Size(121, 21);
            this.cmbMPS.TabIndex = 5;
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(469, 40);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(73, 20);
            this.txtBegin.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(631, 40);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(72, 20);
            this.txtEnd.TabIndex = 7;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriver.Location = new System.Drawing.Point(20, 120);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(65, 17);
            this.lblDriver.TabIndex = 8;
            this.lblDriver.Text = "Шофьор:";
            // 
            // lblNumber_p_list
            // 
            this.lblNumber_p_list.AutoSize = true;
            this.lblNumber_p_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber_p_list.Location = new System.Drawing.Point(208, 120);
            this.lblNumber_p_list.Name = "lblNumber_p_list";
            this.lblNumber_p_list.Size = new System.Drawing.Size(141, 17);
            this.lblNumber_p_list.TabIndex = 9;
            this.lblNumber_p_list.Text = "№ на пътния лист *:";
            // 
            // lblNumber_tovar
            // 
            this.lblNumber_tovar.AutoSize = true;
            this.lblNumber_tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber_tovar.Location = new System.Drawing.Point(405, 120);
            this.lblNumber_tovar.Name = "lblNumber_tovar";
            this.lblNumber_tovar.Size = new System.Drawing.Size(175, 17);
            this.lblNumber_tovar.TabIndex = 10;
            this.lblNumber_tovar.Text = "№ на товарителницата *:";
            // 
            // lblMaterial1
            // 
            this.lblMaterial1.AutoSize = true;
            this.lblMaterial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaterial1.Location = new System.Drawing.Point(20, 170);
            this.lblMaterial1.Name = "lblMaterial1";
            this.lblMaterial1.Size = new System.Drawing.Size(90, 17);
            this.lblMaterial1.TabIndex = 11;
            this.lblMaterial1.Text = "Материал 1:";
            // 
            // cmbDriver
            // 
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(83, 120);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(121, 21);
            this.cmbDriver.TabIndex = 12;
            // 
            // txtNumber_p_list
            // 
            this.txtNumber_p_list.Location = new System.Drawing.Point(349, 120);
            this.txtNumber_p_list.Name = "txtNumber_p_list";
            this.txtNumber_p_list.Size = new System.Drawing.Size(49, 20);
            this.txtNumber_p_list.TabIndex = 13;
            // 
            // txtNumber_tovar
            // 
            this.txtNumber_tovar.Location = new System.Drawing.Point(578, 117);
            this.txtNumber_tovar.Name = "txtNumber_tovar";
            this.txtNumber_tovar.Size = new System.Drawing.Size(66, 20);
            this.txtNumber_tovar.TabIndex = 14;
            // 
            // cmbMaterial1
            // 
            this.cmbMaterial1.FormattingEnabled = true;
            this.cmbMaterial1.Location = new System.Drawing.Point(109, 170);
            this.cmbMaterial1.Name = "cmbMaterial1";
            this.cmbMaterial1.Size = new System.Drawing.Size(109, 21);
            this.cmbMaterial1.TabIndex = 15;
            // 
            // lblKolichestvo1
            // 
            this.lblKolichestvo1.AutoSize = true;
            this.lblKolichestvo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKolichestvo1.Location = new System.Drawing.Point(225, 170);
            this.lblKolichestvo1.Name = "lblKolichestvo1";
            this.lblKolichestvo1.Size = new System.Drawing.Size(102, 17);
            this.lblKolichestvo1.TabIndex = 16;
            this.lblKolichestvo1.Text = "Количество 1:";
            // 
            // lblGorivo
            // 
            this.lblGorivo.AutoSize = true;
            this.lblGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGorivo.Location = new System.Drawing.Point(456, 170);
            this.lblGorivo.Name = "lblGorivo";
            this.lblGorivo.Size = new System.Drawing.Size(59, 17);
            this.lblGorivo.TabIndex = 17;
            this.lblGorivo.Text = "Гориво:";
            // 
            // txtKolichestvo1
            // 
            this.txtKolichestvo1.Location = new System.Drawing.Point(330, 170);
            this.txtKolichestvo1.Name = "txtKolichestvo1";
            this.txtKolichestvo1.Size = new System.Drawing.Size(58, 20);
            this.txtKolichestvo1.TabIndex = 18;
            // 
            // cmbMerna_edinitsa1
            // 
            this.cmbMerna_edinitsa1.FormattingEnabled = true;
            this.cmbMerna_edinitsa1.Items.AddRange(new object[] {
            "т.",
            "куб. м.",
            "л."});
            this.cmbMerna_edinitsa1.Location = new System.Drawing.Point(394, 170);
            this.cmbMerna_edinitsa1.Name = "cmbMerna_edinitsa1";
            this.cmbMerna_edinitsa1.Size = new System.Drawing.Size(54, 21);
            this.cmbMerna_edinitsa1.TabIndex = 19;
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(516, 170);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(100, 20);
            this.txtGorivo.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(30, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(180, 463);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 40);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Покажи";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(966, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(240, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(396, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Форма за добавяне и показване на отчета";
            // 
            // lblObjectBegin
            // 
            this.lblObjectBegin.AutoSize = true;
            this.lblObjectBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblObjectBegin.Location = new System.Drawing.Point(648, 120);
            this.lblObjectBegin.Name = "lblObjectBegin";
            this.lblObjectBegin.Size = new System.Drawing.Size(123, 17);
            this.lblObjectBegin.TabIndex = 25;
            this.lblObjectBegin.Text = "Обект (начален):";
            // 
            // cmbObjectBegin
            // 
            this.cmbObjectBegin.FormattingEnabled = true;
            this.cmbObjectBegin.Location = new System.Drawing.Point(769, 116);
            this.cmbObjectBegin.Name = "cmbObjectBegin";
            this.cmbObjectBegin.Size = new System.Drawing.Size(151, 21);
            this.cmbObjectBegin.TabIndex = 26;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(85, 40);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(110, 20);
            this.dtpDateFrom.TabIndex = 27;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTo.Location = new System.Drawing.Point(20, 80);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(66, 17);
            this.lblDateTo.TabIndex = 28;
            this.lblDateTo.Text = "Дата до:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(85, 80);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(110, 20);
            this.dtpDateTo.TabIndex = 29;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHoursWorked.Location = new System.Drawing.Point(207, 80);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(143, 17);
            this.lblHoursWorked.TabIndex = 30;
            this.lblHoursWorked.Text = "Отработени часове:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(350, 80);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(50, 20);
            this.txtHoursWorked.TabIndex = 31;
            // 
            // grdOtcheti
            // 
            this.grdOtcheti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOtcheti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOtcheti.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdOtcheti.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grdOtcheti.Location = new System.Drawing.Point(22, 578);
            this.grdOtcheti.Name = "grdOtcheti";
            this.grdOtcheti.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOtcheti.Size = new System.Drawing.Size(1155, 152);
            this.grdOtcheti.TabIndex = 32;
            // 
            // txtClean
            // 
            this.txtClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClean.Location = new System.Drawing.Point(330, 463);
            this.txtClean.Name = "txtClean";
            this.txtClean.Size = new System.Drawing.Size(120, 40);
            this.txtClean.TabIndex = 33;
            this.txtClean.Text = "Изчисти";
            this.txtClean.UseVisualStyleBackColor = true;
            this.txtClean.Click += new System.EventHandler(this.txtClean_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(469, 463);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Зареди";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(631, 463);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(807, 463);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExport.Location = new System.Drawing.Point(30, 514);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 40);
            this.btnExport.TabIndex = 37;
            this.btnExport.Text = "Експортирай";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblObjectEnd
            // 
            this.lblObjectEnd.AutoSize = true;
            this.lblObjectEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblObjectEnd.Location = new System.Drawing.Point(927, 118);
            this.lblObjectEnd.Name = "lblObjectEnd";
            this.lblObjectEnd.Size = new System.Drawing.Size(106, 17);
            this.lblObjectEnd.TabIndex = 38;
            this.lblObjectEnd.Text = "Обект (краен):";
            // 
            // cmbObjectEnd
            // 
            this.cmbObjectEnd.FormattingEnabled = true;
            this.cmbObjectEnd.Location = new System.Drawing.Point(1032, 116);
            this.cmbObjectEnd.Name = "cmbObjectEnd";
            this.cmbObjectEnd.Size = new System.Drawing.Size(151, 21);
            this.cmbObjectEnd.TabIndex = 39;
            // 
            // lblKmTovaritelnitsa
            // 
            this.lblKmTovaritelnitsa.AutoSize = true;
            this.lblKmTovaritelnitsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKmTovaritelnitsa.Location = new System.Drawing.Point(727, 41);
            this.lblKmTovaritelnitsa.Name = "lblKmTovaritelnitsa";
            this.lblKmTovaritelnitsa.Size = new System.Drawing.Size(145, 17);
            this.lblKmTovaritelnitsa.TabIndex = 40;
            this.lblKmTovaritelnitsa.Text = "Км.(товарителница):";
            // 
            // txtKmTovaritelnitsa
            // 
            this.txtKmTovaritelnitsa.Location = new System.Drawing.Point(875, 41);
            this.txtKmTovaritelnitsa.Name = "txtKmTovaritelnitsa";
            this.txtKmTovaritelnitsa.Size = new System.Drawing.Size(72, 20);
            this.txtKmTovaritelnitsa.TabIndex = 41;
            // 
            // lblMaterial2
            // 
            this.lblMaterial2.AutoSize = true;
            this.lblMaterial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaterial2.Location = new System.Drawing.Point(19, 231);
            this.lblMaterial2.Name = "lblMaterial2";
            this.lblMaterial2.Size = new System.Drawing.Size(90, 17);
            this.lblMaterial2.TabIndex = 42;
            this.lblMaterial2.Text = "Материал 2:";
            // 
            // lblMaterial3
            // 
            this.lblMaterial3.AutoSize = true;
            this.lblMaterial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaterial3.Location = new System.Drawing.Point(19, 302);
            this.lblMaterial3.Name = "lblMaterial3";
            this.lblMaterial3.Size = new System.Drawing.Size(90, 17);
            this.lblMaterial3.TabIndex = 43;
            this.lblMaterial3.Text = "Материал 3:";
            // 
            // lblMaterial4
            // 
            this.lblMaterial4.AutoSize = true;
            this.lblMaterial4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaterial4.Location = new System.Drawing.Point(19, 373);
            this.lblMaterial4.Name = "lblMaterial4";
            this.lblMaterial4.Size = new System.Drawing.Size(90, 17);
            this.lblMaterial4.TabIndex = 44;
            this.lblMaterial4.Text = "Материал 4:";
            // 
            // cmbMaterial2
            // 
            this.cmbMaterial2.FormattingEnabled = true;
            this.cmbMaterial2.Location = new System.Drawing.Point(109, 231);
            this.cmbMaterial2.Name = "cmbMaterial2";
            this.cmbMaterial2.Size = new System.Drawing.Size(109, 21);
            this.cmbMaterial2.TabIndex = 45;
            // 
            // cmbMaterial3
            // 
            this.cmbMaterial3.FormattingEnabled = true;
            this.cmbMaterial3.Location = new System.Drawing.Point(109, 302);
            this.cmbMaterial3.Name = "cmbMaterial3";
            this.cmbMaterial3.Size = new System.Drawing.Size(109, 21);
            this.cmbMaterial3.TabIndex = 46;
            // 
            // cmbMaterial4
            // 
            this.cmbMaterial4.FormattingEnabled = true;
            this.cmbMaterial4.Location = new System.Drawing.Point(109, 373);
            this.cmbMaterial4.Name = "cmbMaterial4";
            this.cmbMaterial4.Size = new System.Drawing.Size(109, 21);
            this.cmbMaterial4.TabIndex = 47;
            // 
            // lblKolichestvo2
            // 
            this.lblKolichestvo2.AutoSize = true;
            this.lblKolichestvo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKolichestvo2.Location = new System.Drawing.Point(225, 235);
            this.lblKolichestvo2.Name = "lblKolichestvo2";
            this.lblKolichestvo2.Size = new System.Drawing.Size(102, 17);
            this.lblKolichestvo2.TabIndex = 48;
            this.lblKolichestvo2.Text = "Количество 2:";
            // 
            // lblKolichestvo3
            // 
            this.lblKolichestvo3.AutoSize = true;
            this.lblKolichestvo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKolichestvo3.Location = new System.Drawing.Point(225, 306);
            this.lblKolichestvo3.Name = "lblKolichestvo3";
            this.lblKolichestvo3.Size = new System.Drawing.Size(102, 17);
            this.lblKolichestvo3.TabIndex = 49;
            this.lblKolichestvo3.Text = "Количество 3:";
            // 
            // lblKolichestvo4
            // 
            this.lblKolichestvo4.AutoSize = true;
            this.lblKolichestvo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKolichestvo4.Location = new System.Drawing.Point(225, 377);
            this.lblKolichestvo4.Name = "lblKolichestvo4";
            this.lblKolichestvo4.Size = new System.Drawing.Size(102, 17);
            this.lblKolichestvo4.TabIndex = 50;
            this.lblKolichestvo4.Text = "Количество 4:";
            // 
            // txtKolichestvo2
            // 
            this.txtKolichestvo2.Location = new System.Drawing.Point(330, 235);
            this.txtKolichestvo2.Name = "txtKolichestvo2";
            this.txtKolichestvo2.Size = new System.Drawing.Size(58, 20);
            this.txtKolichestvo2.TabIndex = 51;
            // 
            // txtKolichestvo3
            // 
            this.txtKolichestvo3.Location = new System.Drawing.Point(330, 306);
            this.txtKolichestvo3.Name = "txtKolichestvo3";
            this.txtKolichestvo3.Size = new System.Drawing.Size(58, 20);
            this.txtKolichestvo3.TabIndex = 52;
            // 
            // txtKolichestvo4
            // 
            this.txtKolichestvo4.Location = new System.Drawing.Point(330, 377);
            this.txtKolichestvo4.Name = "txtKolichestvo4";
            this.txtKolichestvo4.Size = new System.Drawing.Size(58, 20);
            this.txtKolichestvo4.TabIndex = 53;
            // 
            // cmbMerna_edinitsa2
            // 
            this.cmbMerna_edinitsa2.FormattingEnabled = true;
            this.cmbMerna_edinitsa2.Items.AddRange(new object[] {
            "т.",
            "куб. м.",
            "л."});
            this.cmbMerna_edinitsa2.Location = new System.Drawing.Point(394, 235);
            this.cmbMerna_edinitsa2.Name = "cmbMerna_edinitsa2";
            this.cmbMerna_edinitsa2.Size = new System.Drawing.Size(54, 21);
            this.cmbMerna_edinitsa2.TabIndex = 54;
            // 
            // cmbMerna_edinitsa3
            // 
            this.cmbMerna_edinitsa3.FormattingEnabled = true;
            this.cmbMerna_edinitsa3.Items.AddRange(new object[] {
            "т.",
            "куб. м.",
            "л."});
            this.cmbMerna_edinitsa3.Location = new System.Drawing.Point(394, 306);
            this.cmbMerna_edinitsa3.Name = "cmbMerna_edinitsa3";
            this.cmbMerna_edinitsa3.Size = new System.Drawing.Size(54, 21);
            this.cmbMerna_edinitsa3.TabIndex = 55;
            // 
            // cmbMerna_edinitsa4
            // 
            this.cmbMerna_edinitsa4.FormattingEnabled = true;
            this.cmbMerna_edinitsa4.Items.AddRange(new object[] {
            "т.",
            "куб. м.",
            "л."});
            this.cmbMerna_edinitsa4.Location = new System.Drawing.Point(394, 377);
            this.cmbMerna_edinitsa4.Name = "cmbMerna_edinitsa4";
            this.cmbMerna_edinitsa4.Size = new System.Drawing.Size(54, 21);
            this.cmbMerna_edinitsa4.TabIndex = 56;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1195, 742);
            this.Controls.Add(this.cmbMerna_edinitsa4);
            this.Controls.Add(this.cmbMerna_edinitsa3);
            this.Controls.Add(this.cmbMerna_edinitsa2);
            this.Controls.Add(this.txtKolichestvo4);
            this.Controls.Add(this.txtKolichestvo3);
            this.Controls.Add(this.txtKolichestvo2);
            this.Controls.Add(this.lblKolichestvo4);
            this.Controls.Add(this.lblKolichestvo3);
            this.Controls.Add(this.lblKolichestvo2);
            this.Controls.Add(this.cmbMaterial4);
            this.Controls.Add(this.cmbMaterial3);
            this.Controls.Add(this.cmbMaterial2);
            this.Controls.Add(this.lblMaterial4);
            this.Controls.Add(this.lblMaterial3);
            this.Controls.Add(this.lblMaterial2);
            this.Controls.Add(this.txtKmTovaritelnitsa);
            this.Controls.Add(this.lblKmTovaritelnitsa);
            this.Controls.Add(this.cmbObjectEnd);
            this.Controls.Add(this.lblObjectEnd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtClean);
            this.Controls.Add(this.grdOtcheti);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.cmbObjectBegin);
            this.Controls.Add(this.lblObjectBegin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.cmbMerna_edinitsa1);
            this.Controls.Add(this.txtKolichestvo1);
            this.Controls.Add(this.lblGorivo);
            this.Controls.Add(this.lblKolichestvo1);
            this.Controls.Add(this.cmbMaterial1);
            this.Controls.Add(this.txtNumber_tovar);
            this.Controls.Add(this.txtNumber_p_list);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.lblMaterial1);
            this.Controls.Add(this.lblNumber_tovar);
            this.Controls.Add(this.lblNumber_p_list);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.cmbMPS);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblMPS);
            this.Controls.Add(this.lblDateFrom);
            this.Name = "Report";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOtcheti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblMPS;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ComboBox cmbMPS;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblNumber_p_list;
        private System.Windows.Forms.Label lblNumber_tovar;
        private System.Windows.Forms.Label lblMaterial1;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.TextBox txtNumber_p_list;
        private System.Windows.Forms.TextBox txtNumber_tovar;
        private System.Windows.Forms.ComboBox cmbMaterial1;
        private System.Windows.Forms.Label lblKolichestvo1;
        private System.Windows.Forms.Label lblGorivo;
        private System.Windows.Forms.TextBox txtKolichestvo1;
        private System.Windows.Forms.ComboBox cmbMerna_edinitsa1;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblObjectBegin;
        private System.Windows.Forms.ComboBox cmbObjectBegin;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.DataGridView grdOtcheti;
        private System.Windows.Forms.Button txtClean;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblObjectEnd;
        private System.Windows.Forms.ComboBox cmbObjectEnd;
        private System.Windows.Forms.Label lblKmTovaritelnitsa;
        private System.Windows.Forms.TextBox txtKmTovaritelnitsa;
        private System.Windows.Forms.Label lblMaterial2;
        private System.Windows.Forms.Label lblMaterial3;
        private System.Windows.Forms.Label lblMaterial4;
        private System.Windows.Forms.ComboBox cmbMaterial2;
        private System.Windows.Forms.ComboBox cmbMaterial3;
        private System.Windows.Forms.ComboBox cmbMaterial4;
        private System.Windows.Forms.Label lblKolichestvo2;
        private System.Windows.Forms.Label lblKolichestvo3;
        private System.Windows.Forms.Label lblKolichestvo4;
        private System.Windows.Forms.TextBox txtKolichestvo2;
        private System.Windows.Forms.TextBox txtKolichestvo3;
        private System.Windows.Forms.TextBox txtKolichestvo4;
        private System.Windows.Forms.ComboBox cmbMerna_edinitsa2;
        private System.Windows.Forms.ComboBox cmbMerna_edinitsa3;
        private System.Windows.Forms.ComboBox cmbMerna_edinitsa4;
    }
}