namespace MFC
{
    partial class FormServices
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
            this.buttonPaid = new System.Windows.Forms.Button();
            this.buttonSmart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResponsibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(201, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуги";
            // 
            // buttonPaid
            // 
            this.buttonPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaid.ForeColor = System.Drawing.Color.White;
            this.buttonPaid.Location = new System.Drawing.Point(61, 92);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(147, 51);
            this.buttonPaid.TabIndex = 1;
            this.buttonPaid.Text = "Платные услуги";
            this.buttonPaid.UseVisualStyleBackColor = false;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // buttonSmart
            // 
            this.buttonSmart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSmart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSmart.ForeColor = System.Drawing.Color.White;
            this.buttonSmart.Location = new System.Drawing.Point(252, 92);
            this.buttonSmart.Name = "buttonSmart";
            this.buttonSmart.Size = new System.Drawing.Size(147, 51);
            this.buttonSmart.TabIndex = 2;
            this.buttonSmart.Text = "Умные услуги";
            this.buttonSmart.UseVisualStyleBackColor = false;
            this.buttonSmart.Click += new System.EventHandler(this.buttonSmart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 73);
            this.panel1.TabIndex = 3;
            // 
            // buttonResponsibility
            // 
            this.buttonResponsibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonResponsibility.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResponsibility.ForeColor = System.Drawing.Color.White;
            this.buttonResponsibility.Location = new System.Drawing.Point(154, 168);
            this.buttonResponsibility.Name = "buttonResponsibility";
            this.buttonResponsibility.Size = new System.Drawing.Size(147, 51);
            this.buttonResponsibility.TabIndex = 22;
            this.buttonResponsibility.Text = "Ответсвенность";
            this.buttonResponsibility.UseVisualStyleBackColor = false;
            this.buttonResponsibility.Click += new System.EventHandler(this.buttonResponsibility_Click);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 318);
            this.Controls.Add(this.buttonResponsibility);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSmart);
            this.Controls.Add(this.buttonPaid);
            this.Controls.Add(this.label1);
            this.Name = "FormServices";
            this.Text = "Услуги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPaid;
        private System.Windows.Forms.Button buttonSmart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResponsibility;
    }
}