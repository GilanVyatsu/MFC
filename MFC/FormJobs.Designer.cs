namespace MFC
{
    partial class FormJobs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEcsp = new System.Windows.Forms.Label();
            this.labelChep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n\r\nВы можете отправить нам свое резюме с пометкой \"Вакансия\" на ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "isupovaov@mfc43.ru ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(1, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отправить резюме";
            // 
            // labelVed
            // 
            this.labelVed.BackColor = System.Drawing.Color.White;
            this.labelVed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelVed.Location = new System.Drawing.Point(23, 139);
            this.labelVed.Name = "labelVed";
            this.labelVed.Size = new System.Drawing.Size(472, 45);
            this.labelVed.TabIndex = 3;
            this.labelVed.Text = "Ведущий эксперт-методолог сектора платных услуг управления разработки и реализаци" +
    "и перспективных проектов";
            this.labelVed.Click += new System.EventHandler(this.labelVed_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Открытые вакансии";
            // 
            // labelEcsp
            // 
            this.labelEcsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEcsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelEcsp.Location = new System.Drawing.Point(23, 184);
            this.labelEcsp.Name = "labelEcsp";
            this.labelEcsp.Size = new System.Drawing.Size(442, 49);
            this.labelEcsp.TabIndex = 5;
            this.labelEcsp.Text = "Эксперт-методолог сектора реализации проектов управления разработки и реализации " +
    "перспективных проектов";
            this.labelEcsp.Click += new System.EventHandler(this.labelEcsp_Click);
            // 
            // labelChep
            // 
            this.labelChep.AutoSize = true;
            this.labelChep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelChep.Location = new System.Drawing.Point(23, 233);
            this.labelChep.Name = "labelChep";
            this.labelChep.Size = new System.Drawing.Size(506, 19);
            this.labelChep.TabIndex = 6;
            this.labelChep.Text = "Эксперт территориального отдела МФЦ в г. Кирово-Чепецке (временно)";
            this.labelChep.Click += new System.EventHandler(this.labelChep_Click);
            // 
            // FormJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.labelChep);
            this.Controls.Add(this.labelEcsp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelVed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormJobs";
            this.Text = "Вакансии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEcsp;
        private System.Windows.Forms.Label labelChep;
    }
}