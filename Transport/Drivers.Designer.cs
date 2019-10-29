namespace Transport
{
    partial class Drivers
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategorii = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbCategorii = new System.Windows.Forms.ListBox();
            this.chbProfessional_competence = new System.Windows.Forms.CheckBox();
            this.chbUdostoverenie = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(30, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име и фамилия *:";
            // 
            // lblCategorii
            // 
            this.lblCategorii.AutoSize = true;
            this.lblCategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategorii.Location = new System.Drawing.Point(30, 80);
            this.lblCategorii.Name = "lblCategorii";
            this.lblCategorii.Size = new System.Drawing.Size(81, 17);
            this.lblCategorii.TabIndex = 2;
            this.lblCategorii.Text = "Категории:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(30, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(640, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(240, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Форма за добавяне на шофьори";
            // 
            // lsbCategorii
            // 
            this.lsbCategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbCategorii.FormattingEnabled = true;
            this.lsbCategorii.ItemHeight = 16;
            this.lsbCategorii.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "C+E",
            "D+E",
            "Tkt"});
            this.lsbCategorii.Location = new System.Drawing.Point(117, 80);
            this.lsbCategorii.Name = "lsbCategorii";
            this.lsbCategorii.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbCategorii.Size = new System.Drawing.Size(52, 116);
            this.lsbCategorii.TabIndex = 9;
            // 
            // chbProfessional_competence
            // 
            this.chbProfessional_competence.AutoSize = true;
            this.chbProfessional_competence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbProfessional_competence.Location = new System.Drawing.Point(300, 40);
            this.chbProfessional_competence.Name = "chbProfessional_competence";
            this.chbProfessional_competence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbProfessional_competence.Size = new System.Drawing.Size(239, 21);
            this.chbProfessional_competence.TabIndex = 12;
            this.chbProfessional_competence.Text = "Професионална компетентност";
            this.chbProfessional_competence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chbProfessional_competence.UseVisualStyleBackColor = true;
            // 
            // chbUdostoverenie
            // 
            this.chbUdostoverenie.AutoSize = true;
            this.chbUdostoverenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbUdostoverenie.Location = new System.Drawing.Point(300, 80);
            this.chbUdostoverenie.Name = "chbUdostoverenie";
            this.chbUdostoverenie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbUdostoverenie.Size = new System.Drawing.Size(311, 21);
            this.chbUdostoverenie.TabIndex = 13;
            this.chbUdostoverenie.Text = "Удостоверение за психологическа годност";
            this.chbUdostoverenie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chbUdostoverenie.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(175, 299);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Зареди";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(495, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(335, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chbUdostoverenie);
            this.Controls.Add(this.chbProfessional_competence);
            this.Controls.Add(this.lsbCategorii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategorii);
            this.Controls.Add(this.lblName);
            this.Name = "Drivers";
            this.Text = "Шофьори";
            this.Load += new System.EventHandler(this.Drivers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategorii;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbCategorii;
        private System.Windows.Forms.CheckBox chbProfessional_competence;
        private System.Windows.Forms.CheckBox chbUdostoverenie;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}