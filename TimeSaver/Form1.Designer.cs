namespace TimeSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transformation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Comparison = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transformation
            // 
            this.transformation.Location = new System.Drawing.Point(114, 257);
            this.transformation.Name = "transformation";
            this.transformation.Size = new System.Drawing.Size(182, 36);
            this.transformation.TabIndex = 20;
            this.transformation.Text = "Преобразовать таблицу";
            this.transformation.UseVisualStyleBackColor = true;
            this.transformation.Click += new System.EventHandler(this.transformation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 21);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выбранный файл:";
            // 
            // chooseFile1
            // 
            this.chooseFile1.Location = new System.Drawing.Point(140, 19);
            this.chooseFile1.Name = "chooseFile1";
            this.chooseFile1.Size = new System.Drawing.Size(118, 23);
            this.chooseFile1.TabIndex = 17;
            this.chooseFile1.Tag = "1";
            this.chooseFile1.Text = "Выбрать файл";
            this.chooseFile1.UseVisualStyleBackColor = true;
            this.chooseFile1.Click += new System.EventHandler(this.chooseFile1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(284, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 37);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Укажите номер листа, на котором находится таблица с сайта ГАТИ:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 21);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Comparison
            // 
            this.Comparison.Location = new System.Drawing.Point(114, 366);
            this.Comparison.Name = "Comparison";
            this.Comparison.Size = new System.Drawing.Size(182, 38);
            this.Comparison.TabIndex = 24;
            this.Comparison.Text = "Сравнить ордера";
            this.Comparison.UseVisualStyleBackColor = true;
            this.Comparison.Click += new System.EventHandler(this.Comparison_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Укажите номер листа, последнего отчета по ГАТИ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 21);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "АВАРИЯ (ВОДОПРОВОД)",
            "ВОССТ.БЛАГ.П.АВАРИИ (ВОДОПРОВОД)",
            "****ОГРАНИЧЕНО РАНЕЕ",
            "АВАРИЯ (КАНАЛИЗАЦИЯ)",
            "АВАРИЯ (ТЕПЛОСЕТЬ)",
            "БЛАГОУСТРОЙСТВО (.)",
            "ВОССТ.БЛАГ.П.АВАРИИ (.)",
            "ВОССТ.БЛАГ.П.АВАРИИ (КАНАЛИЗАЦИЯ)",
            "ВОССТ.БЛАГ.П.АВАРИИ (ТЕПЛОСЕТЬ)",
            "ВР.ОГРАЖДЕНИЕ (.)",
            "ВР.ОГРАЖДЕНИЕ (ВРЕМ.ОБЪЕКТ СТРОИТЕЛЬСТВА)",
            "ВР.ОГРАЖДЕНИЕ (КАНАЛИЗАЦИЯ)",
            "ВР.ОГРАЖДЕНИЕ (ОБЩЕСТВЕННЫЙ ТУАЛЕТ)",
            "ВРЕМ.СКЛАДИРОВАНИЕ (.)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (.)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ВОДОВОД)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ВОДОПРОВОД)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ВРЕМ.ОБЪЕКТ СТРОИТЕЛЬСТВА)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ВЫЕЗД ИЗ ЗОНЫ РАБОТ)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ДОРОГА)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (ИНЖЕНЕРНЫЕ СЕТИ)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (КАНАЛИЗАЦИЯ)",
            "ЗЕМЛЯНЫЕ РАБОТЫ (СКВАЖИНА)",
            "ПРОЧИЕ (ВРЕМ.ОБЪЕКТ СТРОИТЕЛЬСТВА)",
            "ПРОЧИЕ (ВЫЕЗД ИЗ ЗОНЫ РАБОТ)",
            "ПРОЧИЕ (ДОРОГА)",
            "РЕМОНТ (.)",
            "РЕМОНТ (КАНАЛИЗАЦИЯ)",
            "УСТ.ЛЕСОВ (.)",
            "УСТР-ВО ВЫЕЗДА (ВЫЕЗД ИЗ ЗОНЫ РАБОТ)"});
            this.comboBox1.Location = new System.Drawing.Point(45, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Укажите фильтр, по которому будет сортироваться новая таблица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "1. Выберите файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "2.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "3.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "4.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Comparison);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.transformation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TimeSaver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transformation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFile1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Comparison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

