namespace Transport
{
    partial class Materials
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
            this.lblVid = new System.Windows.Forms.Label();
            this.lblMerna_edinitsa = new System.Windows.Forms.Label();
            this.lblProizhod = new System.Windows.Forms.Label();
            this.txtVid = new System.Windows.Forms.TextBox();
            this.txtProizhod = new System.Windows.Forms.TextBox();
            this.cmbMerna_edinitsa = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVid.Location = new System.Drawing.Point(30, 40);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(46, 17);
            this.lblVid.TabIndex = 0;
            this.lblVid.Text = "Вид *:";
            // 
            // lblMerna_edinitsa
            // 
            this.lblMerna_edinitsa.AutoSize = true;
            this.lblMerna_edinitsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMerna_edinitsa.Location = new System.Drawing.Point(330, 40);
            this.lblMerna_edinitsa.Name = "lblMerna_edinitsa";
            this.lblMerna_edinitsa.Size = new System.Drawing.Size(115, 17);
            this.lblMerna_edinitsa.TabIndex = 1;
            this.lblMerna_edinitsa.Text = "Мерна единица:";
            // 
            // lblProizhod
            // 
            this.lblProizhod.AutoSize = true;
            this.lblProizhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizhod.Location = new System.Drawing.Point(30, 80);
            this.lblProizhod.Name = "lblProizhod";
            this.lblProizhod.Size = new System.Drawing.Size(75, 17);
            this.lblProizhod.TabIndex = 2;
            this.lblProizhod.Text = "Произход:";
            // 
            // txtVid
            // 
            this.txtVid.Location = new System.Drawing.Point(75, 40);
            this.txtVid.Name = "txtVid";
            this.txtVid.Size = new System.Drawing.Size(100, 20);
            this.txtVid.TabIndex = 3;
            // 
            // txtProizhod
            // 
            this.txtProizhod.Location = new System.Drawing.Point(110, 80);
            this.txtProizhod.Name = "txtProizhod";
            this.txtProizhod.Size = new System.Drawing.Size(100, 20);
            this.txtProizhod.TabIndex = 4;
            // 
            // cmbMerna_edinitsa
            // 
            this.cmbMerna_edinitsa.FormattingEnabled = true;
            this.cmbMerna_edinitsa.Items.AddRange(new object[] {
            "т.",
            "куб. м.",
            "л."});
            this.cmbMerna_edinitsa.Location = new System.Drawing.Point(450, 40);
            this.cmbMerna_edinitsa.Name = "cmbMerna_edinitsa";
            this.cmbMerna_edinitsa.Size = new System.Drawing.Size(92, 21);
            this.cmbMerna_edinitsa.TabIndex = 5;
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
            this.label4.Size = new System.Drawing.Size(316, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Форма за добавяне на материали";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(500, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(340, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(180, 300);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "Зареди";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbMerna_edinitsa);
            this.Controls.Add(this.txtProizhod);
            this.Controls.Add(this.txtVid);
            this.Controls.Add(this.lblProizhod);
            this.Controls.Add(this.lblMerna_edinitsa);
            this.Controls.Add(this.lblVid);
            this.Name = "Materials";
            this.Text = "Материали";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.Label lblMerna_edinitsa;
        private System.Windows.Forms.Label lblProizhod;
        private System.Windows.Forms.TextBox txtVid;
        private System.Windows.Forms.TextBox txtProizhod;
        private System.Windows.Forms.ComboBox cmbMerna_edinitsa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoad;
    }
}