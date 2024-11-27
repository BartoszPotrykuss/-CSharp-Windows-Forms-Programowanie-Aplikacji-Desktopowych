namespace formatowanie_tekstu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.czerwonyBtn = new System.Windows.Forms.Button();
            this.zielonyBtn = new System.Windows.Forms.Button();
            this.niebieskiBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Prosty",
            "Pochyły"});
            this.comboBox1.Location = new System.Drawing.Point(104, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "To jest przykład paragrafu, który może być dowolnie formatowany przez Windows For" +
    "ms";
            // 
            // czerwonyBtn
            // 
            this.czerwonyBtn.BackColor = System.Drawing.Color.Red;
            this.czerwonyBtn.ForeColor = System.Drawing.Color.White;
            this.czerwonyBtn.Location = new System.Drawing.Point(104, 193);
            this.czerwonyBtn.Name = "czerwonyBtn";
            this.czerwonyBtn.Size = new System.Drawing.Size(40, 37);
            this.czerwonyBtn.TabIndex = 3;
            this.czerwonyBtn.UseVisualStyleBackColor = false;
            this.czerwonyBtn.Click += new System.EventHandler(this.czerwonyBtn_Click);
            // 
            // zielonyBtn
            // 
            this.zielonyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zielonyBtn.Location = new System.Drawing.Point(150, 193);
            this.zielonyBtn.Name = "zielonyBtn";
            this.zielonyBtn.Size = new System.Drawing.Size(40, 37);
            this.zielonyBtn.TabIndex = 4;
            this.zielonyBtn.UseVisualStyleBackColor = false;
            this.zielonyBtn.Click += new System.EventHandler(this.zielonyBtn_Click);
            // 
            // niebieskiBtn
            // 
            this.niebieskiBtn.BackColor = System.Drawing.Color.Blue;
            this.niebieskiBtn.Location = new System.Drawing.Point(196, 193);
            this.niebieskiBtn.Name = "niebieskiBtn";
            this.niebieskiBtn.Size = new System.Drawing.Size(40, 37);
            this.niebieskiBtn.TabIndex = 5;
            this.niebieskiBtn.UseVisualStyleBackColor = false;
            this.niebieskiBtn.Click += new System.EventHandler(this.niebieskiBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jakim kolorem sformatować <tekst> Wybierz przycisk.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niebieskiBtn);
            this.Controls.Add(this.zielonyBtn);
            this.Controls.Add(this.czerwonyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button czerwonyBtn;
        private System.Windows.Forms.Button zielonyBtn;
        private System.Windows.Forms.Button niebieskiBtn;
        private System.Windows.Forms.Label label2;
    }
}

