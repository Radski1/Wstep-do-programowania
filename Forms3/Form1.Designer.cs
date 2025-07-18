namespace Forms3
{
    partial class pozostalyCzas
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
            this.czasLbl = new System.Windows.Forms.Label();
            this.label999 = new System.Windows.Forms.Label();
            this.lewaLiczbaLbl = new System.Windows.Forms.Label();
            this.plusLbl = new System.Windows.Forms.Label();
            this.prawaLiczbaLbl = new System.Windows.Forms.Label();
            this.rownaSieLbl = new System.Windows.Forms.Label();
            this.wynik1 = new System.Windows.Forms.NumericUpDown();
            this.wynik2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.minus2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minus1 = new System.Windows.Forms.Label();
            this.wynik3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.razy2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.razy1 = new System.Windows.Forms.Label();
            this.wynik4 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dzielenie2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dzielenie1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stoper = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wynik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik4)).BeginInit();
            this.SuspendLayout();
            // 
            // czasLbl
            // 
            this.czasLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.czasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czasLbl.Location = new System.Drawing.Point(272, 9);
            this.czasLbl.Name = "czasLbl";
            this.czasLbl.Size = new System.Drawing.Size(200, 30);
            this.czasLbl.TabIndex = 0;
            this.czasLbl.Click += new System.EventHandler(this.czasLbl_Click);
            // 
            // label999
            // 
            this.label999.AutoSize = true;
            this.label999.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label999.Location = new System.Drawing.Point(109, 9);
            this.label999.Name = "label999";
            this.label999.Size = new System.Drawing.Size(157, 25);
            this.label999.TabIndex = 1;
            this.label999.Text = "Pozostaly czas";
            this.label999.Click += new System.EventHandler(this.pzczasLbl_Click);
            // 
            // lewaLiczbaLbl
            // 
            this.lewaLiczbaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lewaLiczbaLbl.Location = new System.Drawing.Point(50, 75);
            this.lewaLiczbaLbl.Name = "lewaLiczbaLbl";
            this.lewaLiczbaLbl.Size = new System.Drawing.Size(60, 50);
            this.lewaLiczbaLbl.TabIndex = 2;
            this.lewaLiczbaLbl.Text = "?";
            this.lewaLiczbaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLbl
            // 
            this.plusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusLbl.Location = new System.Drawing.Point(116, 75);
            this.plusLbl.Name = "plusLbl";
            this.plusLbl.Size = new System.Drawing.Size(60, 50);
            this.plusLbl.TabIndex = 3;
            this.plusLbl.Text = "+";
            this.plusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prawaLiczbaLbl
            // 
            this.prawaLiczbaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prawaLiczbaLbl.Location = new System.Drawing.Point(182, 75);
            this.prawaLiczbaLbl.Name = "prawaLiczbaLbl";
            this.prawaLiczbaLbl.Size = new System.Drawing.Size(60, 50);
            this.prawaLiczbaLbl.TabIndex = 4;
            this.prawaLiczbaLbl.Text = "?";
            this.prawaLiczbaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rownaSieLbl
            // 
            this.rownaSieLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownaSieLbl.Location = new System.Drawing.Point(248, 75);
            this.rownaSieLbl.Name = "rownaSieLbl";
            this.rownaSieLbl.Size = new System.Drawing.Size(60, 50);
            this.rownaSieLbl.TabIndex = 5;
            this.rownaSieLbl.Text = "=";
            this.rownaSieLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynik1
            // 
            this.wynik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik1.Location = new System.Drawing.Point(314, 84);
            this.wynik1.MaximumSize = new System.Drawing.Size(100, 0);
            this.wynik1.Name = "wynik1";
            this.wynik1.Size = new System.Drawing.Size(100, 35);
            this.wynik1.TabIndex = 1;
            // 
            // wynik2
            // 
            this.wynik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik2.Location = new System.Drawing.Point(314, 134);
            this.wynik2.MaximumSize = new System.Drawing.Size(100, 0);
            this.wynik2.Name = "wynik2";
            this.wynik2.Size = new System.Drawing.Size(100, 35);
            this.wynik2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(248, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus2
            // 
            this.minus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus2.Location = new System.Drawing.Point(182, 125);
            this.minus2.Name = "minus2";
            this.minus2.Size = new System.Drawing.Size(60, 50);
            this.minus2.TabIndex = 9;
            this.minus2.Text = "?";
            this.minus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(116, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus1
            // 
            this.minus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus1.Location = new System.Drawing.Point(50, 125);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(60, 50);
            this.minus1.TabIndex = 7;
            this.minus1.Text = "?";
            this.minus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynik3
            // 
            this.wynik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik3.Location = new System.Drawing.Point(314, 181);
            this.wynik3.MaximumSize = new System.Drawing.Size(100, 0);
            this.wynik3.Name = "wynik3";
            this.wynik3.Size = new System.Drawing.Size(100, 35);
            this.wynik3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(248, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // razy2
            // 
            this.razy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.razy2.Location = new System.Drawing.Point(182, 172);
            this.razy2.Name = "razy2";
            this.razy2.Size = new System.Drawing.Size(60, 50);
            this.razy2.TabIndex = 14;
            this.razy2.Text = "?";
            this.razy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(116, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 13;
            this.label7.Text = "×";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // razy1
            // 
            this.razy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.razy1.Location = new System.Drawing.Point(50, 172);
            this.razy1.Name = "razy1";
            this.razy1.Size = new System.Drawing.Size(60, 50);
            this.razy1.TabIndex = 12;
            this.razy1.Text = "?";
            this.razy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynik4
            // 
            this.wynik4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik4.Location = new System.Drawing.Point(314, 222);
            this.wynik4.MaximumSize = new System.Drawing.Size(100, 0);
            this.wynik4.Name = "wynik4";
            this.wynik4.Size = new System.Drawing.Size(100, 35);
            this.wynik4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(248, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 20;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dzielenie2
            // 
            this.dzielenie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzielenie2.Location = new System.Drawing.Point(182, 213);
            this.dzielenie2.Name = "dzielenie2";
            this.dzielenie2.Size = new System.Drawing.Size(60, 50);
            this.dzielenie2.TabIndex = 19;
            this.dzielenie2.Text = "?";
            this.dzielenie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(116, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 18;
            this.label11.Text = "÷";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dzielenie1
            // 
            this.dzielenie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzielenie1.Location = new System.Drawing.Point(50, 213);
            this.dzielenie1.Name = "dzielenie1";
            this.dzielenie1.Size = new System.Drawing.Size(60, 50);
            this.dzielenie1.TabIndex = 17;
            this.dzielenie1.Text = "?";
            this.dzielenie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(175, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rozpocznij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stoper
            // 
            this.stoper.Interval = 1000;
            this.stoper.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pozostalyCzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wynik4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dzielenie2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dzielenie1);
            this.Controls.Add(this.wynik3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.razy2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.razy1);
            this.Controls.Add(this.wynik2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minus2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.wynik1);
            this.Controls.Add(this.rownaSieLbl);
            this.Controls.Add(this.prawaLiczbaLbl);
            this.Controls.Add(this.plusLbl);
            this.Controls.Add(this.lewaLiczbaLbl);
            this.Controls.Add(this.label999);
            this.Controls.Add(this.czasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "pozostalyCzas";
            this.Text = "Quiz matematyczny";
            this.Load += new System.EventHandler(this.pozostalyCzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wynik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label czasLbl;
        private System.Windows.Forms.Label label999;
        private System.Windows.Forms.Label lewaLiczbaLbl;
        private System.Windows.Forms.Label plusLbl;
        private System.Windows.Forms.Label prawaLiczbaLbl;
        private System.Windows.Forms.Label rownaSieLbl;
        private System.Windows.Forms.NumericUpDown wynik1;
        private System.Windows.Forms.NumericUpDown wynik2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minus2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minus1;
        private System.Windows.Forms.NumericUpDown wynik3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label razy2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label razy1;
        private System.Windows.Forms.NumericUpDown wynik4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dzielenie2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dzielenie1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer stoper;
    }
}

