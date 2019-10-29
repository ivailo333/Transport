namespace Transport
{
    partial class Intro
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMPS = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnObjects = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnDeleteReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(327, 253);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 40);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMPS
            // 
            this.btnMPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMPS.Location = new System.Drawing.Point(28, 61);
            this.btnMPS.Name = "btnMPS";
            this.btnMPS.Size = new System.Drawing.Size(120, 40);
            this.btnMPS.TabIndex = 1;
            this.btnMPS.Text = "МПС";
            this.btnMPS.UseVisualStyleBackColor = true;
            this.btnMPS.Click += new System.EventHandler(this.btnMPS_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrivers.Location = new System.Drawing.Point(285, 61);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(120, 40);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.Text = "Шофьори";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnObjects
            // 
            this.btnObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnObjects.Location = new System.Drawing.Point(555, 61);
            this.btnObjects.Name = "btnObjects";
            this.btnObjects.Size = new System.Drawing.Size(120, 40);
            this.btnObjects.TabIndex = 3;
            this.btnObjects.Text = "Обекти";
            this.btnObjects.UseVisualStyleBackColor = true;
            this.btnObjects.Click += new System.EventHandler(this.btnObjects_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaterials.Location = new System.Drawing.Point(113, 253);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(120, 40);
            this.btnMaterials.TabIndex = 4;
            this.btnMaterials.Text = "Материали";
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnDeleteReports
            // 
            this.btnDeleteReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteReports.Location = new System.Drawing.Point(537, 253);
            this.btnDeleteReports.Name = "btnDeleteReports";
            this.btnDeleteReports.Size = new System.Drawing.Size(197, 40);
            this.btnDeleteReports.TabIndex = 5;
            this.btnDeleteReports.Text = "Изтриване на отчетите";
            this.btnDeleteReports.UseVisualStyleBackColor = true;
            this.btnDeleteReports.Click += new System.EventHandler(this.btnDeleteReports_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteReports);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnObjects);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnMPS);
            this.Controls.Add(this.btnReport);
            this.Name = "Intro";
            this.Text = "Система за управление на транспорта";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMPS;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnObjects;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnDeleteReports;
    }
}

