namespace Forms2
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
            this.malyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.zdjecieBox = new System.Windows.Forms.PictureBox();
            this.rozciagnijBtn = new System.Windows.Forms.CheckBox();
            this.duzyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.zamknijBtn = new System.Windows.Forms.Button();
            this.tloBtn = new System.Windows.Forms.Button();
            this.wyczyscBtn = new System.Windows.Forms.Button();
            this.wyswietlBtn = new System.Windows.Forms.Button();
            this.wybierzPlik = new System.Windows.Forms.OpenFileDialog();
            this.wybierzKolor = new System.Windows.Forms.ColorDialog();
            this.malyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecieBox)).BeginInit();
            this.duzyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // malyPanel
            // 
            this.malyPanel.ColumnCount = 2;
            this.malyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.malyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.malyPanel.Controls.Add(this.zdjecieBox, 0, 0);
            this.malyPanel.Controls.Add(this.rozciagnijBtn, 0, 1);
            this.malyPanel.Controls.Add(this.duzyPanel, 1, 1);
            this.malyPanel.Location = new System.Drawing.Point(2, 12);
            this.malyPanel.Name = "malyPanel";
            this.malyPanel.RowCount = 2;
            this.malyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.malyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.malyPanel.Size = new System.Drawing.Size(1130, 618);
            this.malyPanel.TabIndex = 0;
            // 
            // zdjecieBox
            // 
            this.zdjecieBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.malyPanel.SetColumnSpan(this.zdjecieBox, 2);
            this.zdjecieBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zdjecieBox.Location = new System.Drawing.Point(3, 3);
            this.zdjecieBox.Name = "zdjecieBox";
            this.zdjecieBox.Size = new System.Drawing.Size(1124, 550);
            this.zdjecieBox.TabIndex = 0;
            this.zdjecieBox.TabStop = false;
            // 
            // rozciagnijBtn
            // 
            this.rozciagnijBtn.AutoSize = true;
            this.rozciagnijBtn.Location = new System.Drawing.Point(3, 559);
            this.rozciagnijBtn.Name = "rozciagnijBtn";
            this.rozciagnijBtn.Size = new System.Drawing.Size(75, 17);
            this.rozciagnijBtn.TabIndex = 1;
            this.rozciagnijBtn.Text = "Rozciagnij";
            this.rozciagnijBtn.UseVisualStyleBackColor = true;
            this.rozciagnijBtn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // duzyPanel
            // 
            this.duzyPanel.Controls.Add(this.zamknijBtn);
            this.duzyPanel.Controls.Add(this.tloBtn);
            this.duzyPanel.Controls.Add(this.wyczyscBtn);
            this.duzyPanel.Controls.Add(this.wyswietlBtn);
            this.duzyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duzyPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.duzyPanel.Location = new System.Drawing.Point(172, 559);
            this.duzyPanel.Name = "duzyPanel";
            this.duzyPanel.Size = new System.Drawing.Size(955, 56);
            this.duzyPanel.TabIndex = 2;
            // 
            // zamknijBtn
            // 
            this.zamknijBtn.AutoSize = true;
            this.zamknijBtn.Location = new System.Drawing.Point(877, 3);
            this.zamknijBtn.Name = "zamknijBtn";
            this.zamknijBtn.Size = new System.Drawing.Size(75, 23);
            this.zamknijBtn.TabIndex = 0;
            this.zamknijBtn.Text = "Zamknij";
            this.zamknijBtn.UseVisualStyleBackColor = true;
            this.zamknijBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tloBtn
            // 
            this.tloBtn.AutoSize = true;
            this.tloBtn.Location = new System.Drawing.Point(796, 3);
            this.tloBtn.Name = "tloBtn";
            this.tloBtn.Size = new System.Drawing.Size(75, 23);
            this.tloBtn.TabIndex = 1;
            this.tloBtn.Text = "Tlo";
            this.tloBtn.UseVisualStyleBackColor = true;
            this.tloBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // wyczyscBtn
            // 
            this.wyczyscBtn.AutoSize = true;
            this.wyczyscBtn.Location = new System.Drawing.Point(715, 3);
            this.wyczyscBtn.Name = "wyczyscBtn";
            this.wyczyscBtn.Size = new System.Drawing.Size(75, 23);
            this.wyczyscBtn.TabIndex = 2;
            this.wyczyscBtn.Text = "Wyczysc";
            this.wyczyscBtn.UseVisualStyleBackColor = true;
            this.wyczyscBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // wyswietlBtn
            // 
            this.wyswietlBtn.AutoSize = true;
            this.wyswietlBtn.Location = new System.Drawing.Point(634, 3);
            this.wyswietlBtn.Name = "wyswietlBtn";
            this.wyswietlBtn.Size = new System.Drawing.Size(75, 23);
            this.wyswietlBtn.TabIndex = 3;
            this.wyswietlBtn.Text = "Wyswietl";
            this.wyswietlBtn.UseVisualStyleBackColor = true;
            this.wyswietlBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // wybierzPlik
            // 
            this.wybierzPlik.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 633);
            this.Controls.Add(this.malyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.malyPanel.ResumeLayout(false);
            this.malyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecieBox)).EndInit();
            this.duzyPanel.ResumeLayout(false);
            this.duzyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel malyPanel;
        private System.Windows.Forms.PictureBox zdjecieBox;
        private System.Windows.Forms.CheckBox rozciagnijBtn;
        private System.Windows.Forms.FlowLayoutPanel duzyPanel;
        private System.Windows.Forms.Button zamknijBtn;
        private System.Windows.Forms.Button tloBtn;
        private System.Windows.Forms.Button wyczyscBtn;
        private System.Windows.Forms.Button wyswietlBtn;
        private System.Windows.Forms.OpenFileDialog wybierzPlik;
        private System.Windows.Forms.ColorDialog wybierzKolor;
    }
}

