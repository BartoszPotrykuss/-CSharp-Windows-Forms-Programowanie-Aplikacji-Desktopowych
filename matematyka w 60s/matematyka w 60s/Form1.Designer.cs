namespace matematyka_w_60s
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zegar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pokazDzialanie = new System.Windows.Forms.Label();
            this.dodawanie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.punktyL = new System.Windows.Forms.Label();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.wszystkieDzialania = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Czas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(302, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Działanie:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zegar
            // 
            this.zegar.AutoSize = true;
            this.zegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zegar.Location = new System.Drawing.Point(390, 183);
            this.zegar.Name = "zegar";
            this.zegar.Size = new System.Drawing.Size(30, 31);
            this.zegar.TabIndex = 5;
            this.zegar.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            // 
            // pokazDzialanie
            // 
            this.pokazDzialanie.AutoSize = true;
            this.pokazDzialanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pokazDzialanie.Location = new System.Drawing.Point(452, 132);
            this.pokazDzialanie.Name = "pokazDzialanie";
            this.pokazDzialanie.Size = new System.Drawing.Size(0, 31);
            this.pokazDzialanie.TabIndex = 7;
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(114, 78);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(83, 23);
            this.dodawanie.TabIndex = 8;
            this.dodawanie.Text = "Dodawanie";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(603, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Punkty: ";
            // 
            // punktyL
            // 
            this.punktyL.AutoSize = true;
            this.punktyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punktyL.Location = new System.Drawing.Point(724, 277);
            this.punktyL.Name = "punktyL";
            this.punktyL.Size = new System.Drawing.Size(0, 31);
            this.punktyL.TabIndex = 10;
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(212, 78);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(80, 23);
            this.odejmowanie.TabIndex = 11;
            this.odejmowanie.Text = "Odejmowanie";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(444, 86);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(75, 23);
            this.mnozenie.TabIndex = 12;
            this.mnozenie.Text = "Mnożenie";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(538, 86);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(75, 23);
            this.dzielenie.TabIndex = 13;
            this.dzielenie.Text = "Dzielenie";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // wszystkieDzialania
            // 
            this.wszystkieDzialania.Location = new System.Drawing.Point(329, 78);
            this.wszystkieDzialania.Name = "wszystkieDzialania";
            this.wszystkieDzialania.Size = new System.Drawing.Size(91, 39);
            this.wszystkieDzialania.TabIndex = 14;
            this.wszystkieDzialania.Text = "Wszystkie działania";
            this.wszystkieDzialania.UseVisualStyleBackColor = true;
            this.wszystkieDzialania.Click += new System.EventHandler(this.wszystkieDzialania_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(87, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wybierz ile chcesz czasu: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "60";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(98, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wybierz działanie jakie chcesz wykonwywać";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wszystkieDzialania);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.punktyL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.pokazDzialanie);
            this.Controls.Add(this.zegar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label zegar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pokazDzialanie;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label punktyL;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Button wszystkieDzialania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

