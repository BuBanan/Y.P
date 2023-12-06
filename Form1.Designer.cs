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
            this.rB_custom = new System.Windows.Forms.RadioButton();
            this.rB_empl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rB_custom
            // 
            this.rB_custom.AutoSize = true;
            this.rB_custom.Location = new System.Drawing.Point(93, 61);
            this.rB_custom.Name = "rB_custom";
            this.rB_custom.Size = new System.Drawing.Size(73, 17);
            this.rB_custom.TabIndex = 0;
            this.rB_custom.TabStop = true;
            this.rB_custom.Text = "Заказчик";
            this.rB_custom.UseVisualStyleBackColor = true;
            this.rB_custom.CheckedChanged += new System.EventHandler(this.rB_custom_CheckedChanged);
            // 
            // rB_empl
            // 
            this.rB_empl.AutoSize = true;
            this.rB_empl.Location = new System.Drawing.Point(206, 61);
            this.rB_empl.Name = "rB_empl";
            this.rB_empl.Size = new System.Drawing.Size(78, 17);
            this.rB_empl.TabIndex = 1;
            this.rB_empl.TabStop = true;
            this.rB_empl.Text = "Сотрудник";
            this.rB_empl.UseVisualStyleBackColor = true;
            this.rB_empl.CheckedChanged += new System.EventHandler(this.rB_empl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Форма регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ваш Логин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ваш Пароль";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(436, 96);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(93, 13);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Номер телефона";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(326, 115);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Дата рождения";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(74, 150);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(210, 20);
            this.txtSname.TabIndex = 13;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(93, 198);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(134, 20);
            this.txtLog.TabIndex = 14;
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(317, 198);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(134, 20);
            this.txtPas.TabIndex = 16;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(74, 96);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(210, 20);
            this.txtFname.TabIndex = 17;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(418, 112);
            this.txtNum.Mask = "+7 (000) 000-0000";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(128, 20);
            this.txtNum.TabIndex = 18;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(418, 112);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(128, 20);
            this.txtDate.TabIndex = 19;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(349, 150);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(180, 23);
            this.btnGen.TabIndex = 20;
            this.btnGen.Text = "Сгенерировать Логин/Пароль";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 249);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_empl);
            this.Controls.Add(this.rB_custom);
            this.Name = "Form1";
            this.Text = "Пегас";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rB_custom;
        private System.Windows.Forms.RadioButton rB_empl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btnGen;
    }
}

