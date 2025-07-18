namespace WazRzeczny
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
            this.GuzikStart = new System.Windows.Forms.Button();
            this.Ramka = new System.Windows.Forms.PictureBox();
            this.WynikLabel = new System.Windows.Forms.Label();
            this.NwynikLabel = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ramka)).BeginInit();
            this.SuspendLayout();
            // 
            // GuzikStart
            // 
            this.GuzikStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GuzikStart.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuzikStart.Location = new System.Drawing.Point(636, 12);
            this.GuzikStart.Name = "GuzikStart";
            this.GuzikStart.Size = new System.Drawing.Size(100, 45);
            this.GuzikStart.TabIndex = 0;
            this.GuzikStart.Text = "Start";
            this.GuzikStart.UseVisualStyleBackColor = false;
            this.GuzikStart.Click += new System.EventHandler(this.StartGry);
            // 
            // Ramka
            // 
            this.Ramka.BackColor = System.Drawing.Color.Azure;
            this.Ramka.Location = new System.Drawing.Point(206, 148);
            this.Ramka.Name = "Ramka";
            this.Ramka.Size = new System.Drawing.Size(300, 300);
            this.Ramka.TabIndex = 1;
            this.Ramka.TabStop = false;
            this.Ramka.Paint += new System.Windows.Forms.PaintEventHandler(this.ZmienObrazek);
            // 
            // WynikLabel
            // 
            this.WynikLabel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.WynikLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WynikLabel.Location = new System.Drawing.Point(31, 12);
            this.WynikLabel.Name = "WynikLabel";
            this.WynikLabel.Size = new System.Drawing.Size(326, 48);
            this.WynikLabel.TabIndex = 2;
            this.WynikLabel.Text = "Wynik: ";
            // 
            // NwynikLabel
            // 
            this.NwynikLabel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.NwynikLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NwynikLabel.Location = new System.Drawing.Point(31, 45);
            this.NwynikLabel.Name = "NwynikLabel";
            this.NwynikLabel.Size = new System.Drawing.Size(326, 88);
            this.NwynikLabel.TabIndex = 2;
            this.NwynikLabel.Text = "Najwyzszy wynik: ";
            this.NwynikLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // czas
            // 
            this.czas.Interval = 120;
            this.czas.Tick += new System.EventHandler(this.CzasGry);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.NwynikLabel);
            this.Controls.Add(this.WynikLabel);
            this.Controls.Add(this.Ramka);
            this.Controls.Add(this.GuzikStart);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ku);
            ((System.ComponentModel.ISupportInitialize)(this.Ramka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuzikStart;
        private System.Windows.Forms.PictureBox Ramka;
        private System.Windows.Forms.Label WynikLabel;
        private System.Windows.Forms.Label NwynikLabel;
        private System.Windows.Forms.Timer czas;
    }
}

