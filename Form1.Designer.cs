namespace У.П
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
            this.Coch = new System.Windows.Forms.Button();
            this.Razm = new System.Windows.Forms.Button();
            this.Per = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coch
            // 
            this.Coch.Location = new System.Drawing.Point(12, 12);
            this.Coch.Name = "Coch";
            this.Coch.Size = new System.Drawing.Size(115, 56);
            this.Coch.TabIndex = 0;
            this.Coch.Text = "Сочитание";
            this.Coch.UseVisualStyleBackColor = true;
            this.Coch.Click += new System.EventHandler(this.Coch_Click);
            // 
            // Razm
            // 
            this.Razm.Location = new System.Drawing.Point(12, 74);
            this.Razm.Name = "Razm";
            this.Razm.Size = new System.Drawing.Size(115, 56);
            this.Razm.TabIndex = 1;
            this.Razm.Text = "Размещение";
            this.Razm.UseVisualStyleBackColor = true;
            this.Razm.Click += new System.EventHandler(this.Razm_Click);
            // 
            // Per
            // 
            this.Per.Location = new System.Drawing.Point(12, 136);
            this.Per.Name = "Per";
            this.Per.Size = new System.Drawing.Size(115, 56);
            this.Per.TabIndex = 2;
            this.Per.Text = "Перестановка";
            this.Per.UseVisualStyleBackColor = true;
            this.Per.Click += new System.EventHandler(this.Per_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "m";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(174, 93);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 5;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(174, 31);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 6;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(200, 158);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Per);
            this.Controls.Add(this.Razm);
            this.Controls.Add(this.Coch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coch;
        private System.Windows.Forms.Button Razm;
        private System.Windows.Forms.Button Per;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label3;
    }
}

