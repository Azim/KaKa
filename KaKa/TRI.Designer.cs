﻿namespace KaKa
{
    partial class TRI
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
            this.IDC_NEXTR_BUTTON = new System.Windows.Forms.Button();
            this.m_nextei = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_np1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_nm1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_nm2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_np2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDC_NEXTR_BUTTON
            // 
            this.IDC_NEXTR_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_NEXTR_BUTTON.Location = new System.Drawing.Point(75, 180);
            this.IDC_NEXTR_BUTTON.Name = "IDC_NEXTR_BUTTON";
            this.IDC_NEXTR_BUTTON.Size = new System.Drawing.Size(102, 23);
            this.IDC_NEXTR_BUTTON.TabIndex = 0;
            this.IDC_NEXTR_BUTTON.Text = "Следующий";
            this.IDC_NEXTR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTR_BUTTON.Click += new System.EventHandler(this.IDC_NEXT_BUTTON_Click);
            // 
            // m_nextei
            // 
            this.m_nextei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_nextei.Location = new System.Drawing.Point(177, 15);
            this.m_nextei.Name = "m_nextei";
            this.m_nextei.ReadOnly = true;
            this.m_nextei.Size = new System.Drawing.Size(75, 20);
            this.m_nextei.TabIndex = 1;
            this.m_nextei.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ид. трансформатор TRI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Узел n1+";
            // 
            // m_np1
            // 
            this.m_np1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_np1.Location = new System.Drawing.Point(177, 41);
            this.m_np1.Name = "m_np1";
            this.m_np1.Size = new System.Drawing.Size(75, 20);
            this.m_np1.TabIndex = 3;
            this.m_np1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Узел n1-";
            // 
            // m_nm1
            // 
            this.m_nm1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_nm1.Location = new System.Drawing.Point(177, 67);
            this.m_nm1.Name = "m_nm1";
            this.m_nm1.Size = new System.Drawing.Size(75, 20);
            this.m_nm1.TabIndex = 5;
            this.m_nm1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "коэффициент трансформации";
            // 
            // m_z
            // 
            this.m_z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_z.Location = new System.Drawing.Point(177, 145);
            this.m_z.Name = "m_z";
            this.m_z.Size = new System.Drawing.Size(75, 20);
            this.m_z.TabIndex = 7;
            this.m_z.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Узел n2-";
            // 
            // m_nm2
            // 
            this.m_nm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_nm2.Location = new System.Drawing.Point(177, 119);
            this.m_nm2.Name = "m_nm2";
            this.m_nm2.Size = new System.Drawing.Size(75, 20);
            this.m_nm2.TabIndex = 11;
            this.m_nm2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Узел n2+";
            // 
            // m_np2
            // 
            this.m_np2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_np2.Location = new System.Drawing.Point(177, 93);
            this.m_np2.Name = "m_np2";
            this.m_np2.Size = new System.Drawing.Size(75, 20);
            this.m_np2.TabIndex = 9;
            this.m_np2.Text = "0";
            // 
            // TRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_nm2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_np2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_z);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_nm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_np1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nextei);
            this.Controls.Add(this.IDC_NEXTR_BUTTON);
            this.MaximumSize = new System.Drawing.Size(280, 400);
            this.Name = "TRI";
            this.Text = "TRI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTR_BUTTON;
        private System.Windows.Forms.TextBox m_nextei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_np1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_nm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_nm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_np2;
    }
}