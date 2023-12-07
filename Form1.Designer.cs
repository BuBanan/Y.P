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
            this.cBRou = new System.Windows.Forms.ComboBox();
            this.cBDate = new System.Windows.Forms.ComboBox();
            this.cBVan = new System.Windows.Forms.ComboBox();
            this.cBLin = new System.Windows.Forms.CheckBox();
            this.cBLug = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBeat = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            this.cBBack = new System.Windows.Forms.CheckBox();
            this.UpDChild = new System.Windows.Forms.NumericUpDown();
            this.UpDOld = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDOld)).BeginInit();
            this.SuspendLayout();
            // 
            // cBRou
            // 
            this.cBRou.FormattingEnabled = true;
            this.cBRou.Items.AddRange(new object[] {
            "Москва-Санкт-Петербург",
            "Москва-Краснодар",
            "Москва-Новокузнецк"});
            this.cBRou.Location = new System.Drawing.Point(95, 4);
            this.cBRou.Name = "cBRou";
            this.cBRou.Size = new System.Drawing.Size(223, 21);
            this.cBRou.TabIndex = 0;
            // 
            // cBDate
            // 
            this.cBDate.FormattingEnabled = true;
            this.cBDate.Location = new System.Drawing.Point(95, 31);
            this.cBDate.Name = "cBDate";
            this.cBDate.Size = new System.Drawing.Size(223, 21);
            this.cBDate.TabIndex = 1;
            // 
            // cBVan
            // 
            this.cBVan.FormattingEnabled = true;
            this.cBVan.Items.AddRange(new object[] {
            "Плацкарт",
            "СВ",
            "Купе",
            "Для инвалидов"});
            this.cBVan.Location = new System.Drawing.Point(95, 58);
            this.cBVan.Name = "cBVan";
            this.cBVan.Size = new System.Drawing.Size(223, 21);
            this.cBVan.TabIndex = 2;
            // 
            // cBLin
            // 
            this.cBLin.AutoSize = true;
            this.cBLin.Location = new System.Drawing.Point(324, 9);
            this.cBLin.Name = "cBLin";
            this.cBLin.Size = new System.Drawing.Size(102, 17);
            this.cBLin.TabIndex = 4;
            this.cBLin.Text = "Наличие белья";
            this.cBLin.UseVisualStyleBackColor = true;
            // 
            // cBLug
            // 
            this.cBLug.AutoSize = true;
            this.cBLug.Location = new System.Drawing.Point(324, 62);
            this.cBLug.Name = "cBLug";
            this.cBLug.Size = new System.Drawing.Size(109, 17);
            this.cBLug.TabIndex = 5;
            this.cBLug.Text = "Наличие багажа";
            this.cBLug.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Рейс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата и время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип вагона";
            // 
            // cBeat
            // 
            this.cBeat.AutoSize = true;
            this.cBeat.Location = new System.Drawing.Point(324, 35);
            this.cBeat.Name = "cBeat";
            this.cBeat.Size = new System.Drawing.Size(113, 17);
            this.cBeat.TabIndex = 9;
            this.cBeat.Text = "Наличие питания";
            this.cBeat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Кол-во взрослых";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кол-во детей";
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(12, 111);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(425, 23);
            this.btnPrice.TabIndex = 14;
            this.btnPrice.Text = "Расчитать стоимость";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // cBBack
            // 
            this.cBBack.AutoSize = true;
            this.cBBack.Location = new System.Drawing.Point(324, 91);
            this.cBBack.Name = "cBBack";
            this.cBBack.Size = new System.Drawing.Size(100, 17);
            this.cBBack.TabIndex = 15;
            this.cBBack.Text = "Билет обратно";
            this.cBBack.UseVisualStyleBackColor = true;
            // 
            // UpDChild
            // 
            this.UpDChild.Location = new System.Drawing.Point(91, 85);
            this.UpDChild.Name = "UpDChild";
            this.UpDChild.Size = new System.Drawing.Size(63, 20);
            this.UpDChild.TabIndex = 18;
            // 
            // UpDOld
            // 
            this.UpDOld.Location = new System.Drawing.Point(259, 86);
            this.UpDOld.Name = "UpDOld";
            this.UpDOld.Size = new System.Drawing.Size(59, 20);
            this.UpDOld.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 143);
            this.Controls.Add(this.UpDOld);
            this.Controls.Add(this.UpDChild);
            this.Controls.Add(this.cBBack);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBLug);
            this.Controls.Add(this.cBLin);
            this.Controls.Add(this.cBVan);
            this.Controls.Add(this.cBDate);
            this.Controls.Add(this.cBRou);
            this.Name = "Form1";
            this.Text = "ЖДКасса";
            ((System.ComponentModel.ISupportInitialize)(this.UpDChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBRou;
        private System.Windows.Forms.ComboBox cBDate;
        private System.Windows.Forms.ComboBox cBVan;
        private System.Windows.Forms.CheckBox cBLin;
        private System.Windows.Forms.CheckBox cBLug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cBeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.CheckBox cBBack;
        private System.Windows.Forms.NumericUpDown UpDChild;
        private System.Windows.Forms.NumericUpDown UpDOld;
    }
}

