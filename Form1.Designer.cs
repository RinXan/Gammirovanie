namespace Gammirovanie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.LangCheckbox = new System.Windows.Forms.CheckBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BinKeyTextBox = new System.Windows.Forms.TextBox();
            this.OpenTextBox = new System.Windows.Forms.TextBox();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.BinOpenTextBox = new System.Windows.Forms.TextBox();
            this.BinCipherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateKeyСheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 12);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(160, 30);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(628, 12);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(160, 30);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // LangCheckbox
            // 
            this.LangCheckbox.AutoSize = true;
            this.LangCheckbox.Location = new System.Drawing.Point(12, 48);
            this.LangCheckbox.Name = "LangCheckbox";
            this.LangCheckbox.Size = new System.Drawing.Size(296, 24);
            this.LangCheckbox.TabIndex = 2;
            this.LangCheckbox.Text = "Кириллица (латиница по умолчанию)";
            this.LangCheckbox.UseVisualStyleBackColor = true;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(230, 12);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(377, 30);
            this.KeyTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ";
            // 
            // BinKeyTextBox
            // 
            this.BinKeyTextBox.Location = new System.Drawing.Point(267, 569);
            this.BinKeyTextBox.Multiline = true;
            this.BinKeyTextBox.Name = "BinKeyTextBox";
            this.BinKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinKeyTextBox.Size = new System.Drawing.Size(521, 66);
            this.BinKeyTextBox.TabIndex = 5;
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Location = new System.Drawing.Point(12, 108);
            this.OpenTextBox.Multiline = true;
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenTextBox.Size = new System.Drawing.Size(380, 200);
            this.OpenTextBox.TabIndex = 6;
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(408, 108);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherTextBox.Size = new System.Drawing.Size(380, 200);
            this.CipherTextBox.TabIndex = 7;
            // 
            // BinOpenTextBox
            // 
            this.BinOpenTextBox.Location = new System.Drawing.Point(12, 356);
            this.BinOpenTextBox.Multiline = true;
            this.BinOpenTextBox.Name = "BinOpenTextBox";
            this.BinOpenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinOpenTextBox.Size = new System.Drawing.Size(380, 200);
            this.BinOpenTextBox.TabIndex = 8;
            // 
            // BinCipherTextBox
            // 
            this.BinCipherTextBox.Location = new System.Drawing.Point(408, 356);
            this.BinCipherTextBox.Multiline = true;
            this.BinCipherTextBox.Name = "BinCipherTextBox";
            this.BinCipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinCipherTextBox.Size = new System.Drawing.Size(380, 200);
            this.BinCipherTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Двоичное представление открытого и зашифрованного текстов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Двоичное представление ключа";
            // 
            // GenerateKeyСheckBox
            // 
            this.GenerateKeyСheckBox.AutoSize = true;
            this.GenerateKeyСheckBox.Location = new System.Drawing.Point(409, 48);
            this.GenerateKeyСheckBox.Name = "GenerateKeyСheckBox";
            this.GenerateKeyСheckBox.Size = new System.Drawing.Size(232, 24);
            this.GenerateKeyСheckBox.TabIndex = 12;
            this.GenerateKeyСheckBox.Text = "Хотите сгенерировать ключ?";
            this.GenerateKeyСheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Открытый текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Шифротекст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateKeyСheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BinCipherTextBox);
            this.Controls.Add(this.BinOpenTextBox);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.OpenTextBox);
            this.Controls.Add(this.BinKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.LangCheckbox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Name = "Form1";
            this.Text = "Гаммирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EncryptButton;
        private Button DecryptButton;
        private CheckBox LangCheckbox;
        private TextBox KeyTextBox;
        private Label label1;
        private TextBox BinKeyTextBox;
        private TextBox OpenTextBox;
        private TextBox CipherTextBox;
        private TextBox BinOpenTextBox;
        private TextBox BinCipherTextBox;
        private Label label2;
        private Label label3;
        private CheckBox GenerateKeyСheckBox;
        private Label label4;
        private Label label5;
    }
}