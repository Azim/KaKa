namespace KaKa
{
    partial class L
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
            this.label4 = new System.Windows.Forms.Label();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ёмкость (КФ)";
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(149, 84);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(75, 20);
            this.m_zl.TabIndex = 25;
            this.m_zl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Узел n-";
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(149, 58);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(75, 20);
            this.m_nml.TabIndex = 23;
            this.m_nml.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Узел n+";
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(149, 32);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(75, 20);
            this.m_npl.TabIndex = 21;
            this.m_npl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Конденсатор C";
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(149, 6);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.ReadOnly = true;
            this.m_nextl.Size = new System.Drawing.Size(75, 20);
            this.m_nextl.TabIndex = 19;
            this.m_nextl.Text = "1";
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(73, 123);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXTL_BUTTON.TabIndex = 18;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 159);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_zl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nextl;
        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
    }
}