namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ParantezAc = new System.Windows.Forms.Button();
            this.ParantezKapa = new System.Windows.Forms.Button();
            this.SıfırButonu = new System.Windows.Forms.Button();
            this.virgulButonu = new System.Windows.Forms.Button();
            this.esittirButonu = new System.Windows.Forms.Button();
            this.FaktoriyelButonu = new System.Windows.Forms.Button();
            this.PiSayisiButon = new System.Windows.Forms.Button();
            this.BirButonu = new System.Windows.Forms.Button();
            this.IkiButonu = new System.Windows.Forms.Button();
            this.UcButonu = new System.Windows.Forms.Button();
            this.DortButonu = new System.Windows.Forms.Button();
            this.BesButonu = new System.Windows.Forms.Button();
            this.AltıButonu = new System.Windows.Forms.Button();
            this.YediButonu = new System.Windows.Forms.Button();
            this.SekizButonu = new System.Windows.Forms.Button();
            this.DokuzButonu = new System.Windows.Forms.Button();
            this.BolmeButonu = new System.Windows.Forms.Button();
            this.CarpmaButonu = new System.Windows.Forms.Button();
            this.ToplamaButonu = new System.Windows.Forms.Button();
            this.CıkarmaButonu = new System.Windows.Forms.Button();
            this.CEButonu = new System.Windows.Forms.Button();
            this.C_Butonu = new System.Windows.Forms.Button();
            this.tanButonu = new System.Windows.Forms.Button();
            this.sinButonu = new System.Windows.Forms.Button();
            this.cosButonu = new System.Windows.Forms.Button();
            this.xKareButon = new System.Windows.Forms.Button();
            this.UssuButon = new System.Windows.Forms.Button();
            this.logButonu = new System.Windows.Forms.Button();
            this.karekokButonu = new System.Windows.Forms.Button();
            this.modButonu = new System.Windows.Forms.Button();
            this.GecmisLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParantezAc
            // 
            this.ParantezAc.Location = new System.Drawing.Point(2, 368);
            this.ParantezAc.Name = "ParantezAc";
            this.ParantezAc.Size = new System.Drawing.Size(46, 40);
            this.ParantezAc.TabIndex = 0;
            this.ParantezAc.Text = "e";
            this.ParantezAc.UseVisualStyleBackColor = true;
            this.ParantezAc.Click += new System.EventHandler(this.eSayisi_Click);
            // 
            // ParantezKapa
            // 
            this.ParantezKapa.Location = new System.Drawing.Point(54, 368);
            this.ParantezKapa.Name = "ParantezKapa";
            this.ParantezKapa.Size = new System.Drawing.Size(46, 40);
            this.ParantezKapa.TabIndex = 1;
            this.ParantezKapa.Text = "Ans";
            this.ParantezKapa.UseVisualStyleBackColor = true;
            this.ParantezKapa.Click += new System.EventHandler(this.Button2_Click);
            // 
            // SıfırButonu
            // 
            this.SıfırButonu.Location = new System.Drawing.Point(106, 368);
            this.SıfırButonu.Name = "SıfırButonu";
            this.SıfırButonu.Size = new System.Drawing.Size(46, 40);
            this.SıfırButonu.TabIndex = 2;
            this.SıfırButonu.Text = "0";
            this.SıfırButonu.UseVisualStyleBackColor = true;
            this.SıfırButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // virgulButonu
            // 
            this.virgulButonu.Location = new System.Drawing.Point(158, 368);
            this.virgulButonu.Name = "virgulButonu";
            this.virgulButonu.Size = new System.Drawing.Size(46, 40);
            this.virgulButonu.TabIndex = 3;
            this.virgulButonu.Text = ",";
            this.virgulButonu.UseVisualStyleBackColor = true;
            this.virgulButonu.Click += new System.EventHandler(this.VirgulButonu_Click);
            // 
            // esittirButonu
            // 
            this.esittirButonu.Location = new System.Drawing.Point(210, 368);
            this.esittirButonu.Name = "esittirButonu";
            this.esittirButonu.Size = new System.Drawing.Size(46, 40);
            this.esittirButonu.TabIndex = 4;
            this.esittirButonu.Text = "=";
            this.esittirButonu.UseVisualStyleBackColor = true;
            this.esittirButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // FaktoriyelButonu
            // 
            this.FaktoriyelButonu.Location = new System.Drawing.Point(2, 322);
            this.FaktoriyelButonu.Name = "FaktoriyelButonu";
            this.FaktoriyelButonu.Size = new System.Drawing.Size(46, 40);
            this.FaktoriyelButonu.TabIndex = 6;
            this.FaktoriyelButonu.Text = "n!";
            this.FaktoriyelButonu.UseVisualStyleBackColor = true;
            this.FaktoriyelButonu.Click += new System.EventHandler(this.FaktoriyelButonu_Click);
            // 
            // PiSayisiButon
            // 
            this.PiSayisiButon.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiSayisiButon.Location = new System.Drawing.Point(2, 276);
            this.PiSayisiButon.Name = "PiSayisiButon";
            this.PiSayisiButon.Size = new System.Drawing.Size(46, 40);
            this.PiSayisiButon.TabIndex = 7;
            this.PiSayisiButon.Text = "π";
            this.PiSayisiButon.UseVisualStyleBackColor = true;
            this.PiSayisiButon.Click += new System.EventHandler(this.PiSayisiButon_Click);
            // 
            // BirButonu
            // 
            this.BirButonu.Location = new System.Drawing.Point(54, 322);
            this.BirButonu.Name = "BirButonu";
            this.BirButonu.Size = new System.Drawing.Size(46, 40);
            this.BirButonu.TabIndex = 8;
            this.BirButonu.Text = "1";
            this.BirButonu.UseVisualStyleBackColor = true;
            this.BirButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // IkiButonu
            // 
            this.IkiButonu.Location = new System.Drawing.Point(106, 322);
            this.IkiButonu.Name = "IkiButonu";
            this.IkiButonu.Size = new System.Drawing.Size(46, 40);
            this.IkiButonu.TabIndex = 9;
            this.IkiButonu.Text = "2";
            this.IkiButonu.UseVisualStyleBackColor = true;
            this.IkiButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // UcButonu
            // 
            this.UcButonu.Location = new System.Drawing.Point(158, 322);
            this.UcButonu.Name = "UcButonu";
            this.UcButonu.Size = new System.Drawing.Size(46, 40);
            this.UcButonu.TabIndex = 10;
            this.UcButonu.Text = "3";
            this.UcButonu.UseVisualStyleBackColor = true;
            this.UcButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // DortButonu
            // 
            this.DortButonu.Location = new System.Drawing.Point(54, 276);
            this.DortButonu.Name = "DortButonu";
            this.DortButonu.Size = new System.Drawing.Size(46, 40);
            this.DortButonu.TabIndex = 11;
            this.DortButonu.Text = "4";
            this.DortButonu.UseVisualStyleBackColor = true;
            this.DortButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // BesButonu
            // 
            this.BesButonu.Location = new System.Drawing.Point(106, 276);
            this.BesButonu.Name = "BesButonu";
            this.BesButonu.Size = new System.Drawing.Size(46, 40);
            this.BesButonu.TabIndex = 12;
            this.BesButonu.Text = "5";
            this.BesButonu.UseVisualStyleBackColor = true;
            this.BesButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // AltıButonu
            // 
            this.AltıButonu.Location = new System.Drawing.Point(158, 276);
            this.AltıButonu.Name = "AltıButonu";
            this.AltıButonu.Size = new System.Drawing.Size(46, 40);
            this.AltıButonu.TabIndex = 13;
            this.AltıButonu.Text = "6";
            this.AltıButonu.UseVisualStyleBackColor = true;
            this.AltıButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // YediButonu
            // 
            this.YediButonu.Location = new System.Drawing.Point(54, 230);
            this.YediButonu.Name = "YediButonu";
            this.YediButonu.Size = new System.Drawing.Size(46, 40);
            this.YediButonu.TabIndex = 14;
            this.YediButonu.Text = "7";
            this.YediButonu.UseVisualStyleBackColor = true;
            this.YediButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // SekizButonu
            // 
            this.SekizButonu.Location = new System.Drawing.Point(106, 230);
            this.SekizButonu.Name = "SekizButonu";
            this.SekizButonu.Size = new System.Drawing.Size(46, 40);
            this.SekizButonu.TabIndex = 15;
            this.SekizButonu.Text = "8";
            this.SekizButonu.UseVisualStyleBackColor = true;
            this.SekizButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // DokuzButonu
            // 
            this.DokuzButonu.Location = new System.Drawing.Point(158, 230);
            this.DokuzButonu.Name = "DokuzButonu";
            this.DokuzButonu.Size = new System.Drawing.Size(46, 40);
            this.DokuzButonu.TabIndex = 16;
            this.DokuzButonu.Text = "9";
            this.DokuzButonu.UseVisualStyleBackColor = true;
            this.DokuzButonu.Click += new System.EventHandler(this.RakamOlay);
            // 
            // BolmeButonu
            // 
            this.BolmeButonu.Location = new System.Drawing.Point(210, 322);
            this.BolmeButonu.Name = "BolmeButonu";
            this.BolmeButonu.Size = new System.Drawing.Size(46, 40);
            this.BolmeButonu.TabIndex = 17;
            this.BolmeButonu.Text = "/";
            this.BolmeButonu.UseVisualStyleBackColor = true;
            this.BolmeButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // CarpmaButonu
            // 
            this.CarpmaButonu.Location = new System.Drawing.Point(210, 276);
            this.CarpmaButonu.Name = "CarpmaButonu";
            this.CarpmaButonu.Size = new System.Drawing.Size(46, 40);
            this.CarpmaButonu.TabIndex = 18;
            this.CarpmaButonu.Text = "x";
            this.CarpmaButonu.UseVisualStyleBackColor = true;
            this.CarpmaButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // ToplamaButonu
            // 
            this.ToplamaButonu.Location = new System.Drawing.Point(210, 230);
            this.ToplamaButonu.Name = "ToplamaButonu";
            this.ToplamaButonu.Size = new System.Drawing.Size(46, 40);
            this.ToplamaButonu.TabIndex = 19;
            this.ToplamaButonu.Text = "+";
            this.ToplamaButonu.UseVisualStyleBackColor = true;
            this.ToplamaButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // CıkarmaButonu
            // 
            this.CıkarmaButonu.Location = new System.Drawing.Point(210, 184);
            this.CıkarmaButonu.Name = "CıkarmaButonu";
            this.CıkarmaButonu.Size = new System.Drawing.Size(46, 40);
            this.CıkarmaButonu.TabIndex = 20;
            this.CıkarmaButonu.Text = "-";
            this.CıkarmaButonu.UseVisualStyleBackColor = true;
            this.CıkarmaButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // CEButonu
            // 
            this.CEButonu.Location = new System.Drawing.Point(158, 184);
            this.CEButonu.Name = "CEButonu";
            this.CEButonu.Size = new System.Drawing.Size(46, 40);
            this.CEButonu.TabIndex = 21;
            this.CEButonu.Text = "CE";
            this.CEButonu.UseVisualStyleBackColor = true;
            this.CEButonu.Click += new System.EventHandler(this.CEButonu_Click);
            // 
            // C_Butonu
            // 
            this.C_Butonu.Location = new System.Drawing.Point(106, 184);
            this.C_Butonu.Name = "C_Butonu";
            this.C_Butonu.Size = new System.Drawing.Size(46, 40);
            this.C_Butonu.TabIndex = 22;
            this.C_Butonu.Text = "C";
            this.C_Butonu.UseVisualStyleBackColor = true;
            this.C_Butonu.Click += new System.EventHandler(this.C_Butonu_Click);
            // 
            // tanButonu
            // 
            this.tanButonu.Location = new System.Drawing.Point(54, 184);
            this.tanButonu.Name = "tanButonu";
            this.tanButonu.Size = new System.Drawing.Size(46, 40);
            this.tanButonu.TabIndex = 23;
            this.tanButonu.Text = "tan";
            this.tanButonu.UseVisualStyleBackColor = true;
            this.tanButonu.Click += new System.EventHandler(this.TanButonu_Click);
            // 
            // sinButonu
            // 
            this.sinButonu.Location = new System.Drawing.Point(2, 230);
            this.sinButonu.Name = "sinButonu";
            this.sinButonu.Size = new System.Drawing.Size(46, 40);
            this.sinButonu.TabIndex = 24;
            this.sinButonu.Text = "sin";
            this.sinButonu.UseVisualStyleBackColor = true;
            this.sinButonu.Click += new System.EventHandler(this.SinButonu_Click);
            // 
            // cosButonu
            // 
            this.cosButonu.Location = new System.Drawing.Point(2, 184);
            this.cosButonu.Name = "cosButonu";
            this.cosButonu.Size = new System.Drawing.Size(46, 40);
            this.cosButonu.TabIndex = 25;
            this.cosButonu.Text = "cos";
            this.cosButonu.UseVisualStyleBackColor = true;
            this.cosButonu.Click += new System.EventHandler(this.CosButonu_Click);
            // 
            // xKareButon
            // 
            this.xKareButon.Location = new System.Drawing.Point(2, 138);
            this.xKareButon.Name = "xKareButon";
            this.xKareButon.Size = new System.Drawing.Size(46, 40);
            this.xKareButon.TabIndex = 26;
            this.xKareButon.Text = "x²";
            this.xKareButon.UseVisualStyleBackColor = true;
            this.xKareButon.Click += new System.EventHandler(this.XKareButon_Click);
            // 
            // UssuButon
            // 
            this.UssuButon.Location = new System.Drawing.Point(54, 138);
            this.UssuButon.Name = "UssuButon";
            this.UssuButon.Size = new System.Drawing.Size(46, 40);
            this.UssuButon.TabIndex = 27;
            this.UssuButon.Text = "^";
            this.UssuButon.UseVisualStyleBackColor = true;
            this.UssuButon.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // logButonu
            // 
            this.logButonu.Location = new System.Drawing.Point(106, 138);
            this.logButonu.Name = "logButonu";
            this.logButonu.Size = new System.Drawing.Size(46, 40);
            this.logButonu.TabIndex = 28;
            this.logButonu.Text = "log";
            this.logButonu.UseVisualStyleBackColor = true;
            this.logButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // karekokButonu
            // 
            this.karekokButonu.Location = new System.Drawing.Point(158, 138);
            this.karekokButonu.Name = "karekokButonu";
            this.karekokButonu.Size = new System.Drawing.Size(46, 40);
            this.karekokButonu.TabIndex = 29;
            this.karekokButonu.Text = "√";
            this.karekokButonu.UseVisualStyleBackColor = true;
            this.karekokButonu.Click += new System.EventHandler(this.KarekokButonu_Click);
            // 
            // modButonu
            // 
            this.modButonu.Location = new System.Drawing.Point(210, 138);
            this.modButonu.Name = "modButonu";
            this.modButonu.Size = new System.Drawing.Size(46, 40);
            this.modButonu.TabIndex = 30;
            this.modButonu.Text = "Mod";
            this.modButonu.UseVisualStyleBackColor = true;
            this.modButonu.Click += new System.EventHandler(this.OperatorIslem);
            // 
            // GecmisLabel
            // 
            this.GecmisLabel.AutoSize = true;
            this.GecmisLabel.Location = new System.Drawing.Point(12, 46);
            this.GecmisLabel.Name = "GecmisLabel";
            this.GecmisLabel.Size = new System.Drawing.Size(0, 13);
            this.GecmisLabel.TabIndex = 31;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(2, 62);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(254, 70);
            this.textBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "-Lütfen önce sayıyı girin sonra operatöre tıklayın-";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.GecmisLabel);
            this.Controls.Add(this.modButonu);
            this.Controls.Add(this.karekokButonu);
            this.Controls.Add(this.logButonu);
            this.Controls.Add(this.UssuButon);
            this.Controls.Add(this.xKareButon);
            this.Controls.Add(this.cosButonu);
            this.Controls.Add(this.sinButonu);
            this.Controls.Add(this.tanButonu);
            this.Controls.Add(this.C_Butonu);
            this.Controls.Add(this.CEButonu);
            this.Controls.Add(this.CıkarmaButonu);
            this.Controls.Add(this.ToplamaButonu);
            this.Controls.Add(this.CarpmaButonu);
            this.Controls.Add(this.BolmeButonu);
            this.Controls.Add(this.DokuzButonu);
            this.Controls.Add(this.SekizButonu);
            this.Controls.Add(this.YediButonu);
            this.Controls.Add(this.AltıButonu);
            this.Controls.Add(this.BesButonu);
            this.Controls.Add(this.DortButonu);
            this.Controls.Add(this.UcButonu);
            this.Controls.Add(this.IkiButonu);
            this.Controls.Add(this.BirButonu);
            this.Controls.Add(this.PiSayisiButon);
            this.Controls.Add(this.FaktoriyelButonu);
            this.Controls.Add(this.esittirButonu);
            this.Controls.Add(this.virgulButonu);
            this.Controls.Add(this.SıfırButonu);
            this.Controls.Add(this.ParantezKapa);
            this.Controls.Add(this.ParantezAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParantezAc;
        private System.Windows.Forms.Button ParantezKapa;
        private System.Windows.Forms.Button SıfırButonu;
        private System.Windows.Forms.Button virgulButonu;
        private System.Windows.Forms.Button esittirButonu;
        private System.Windows.Forms.Button FaktoriyelButonu;
        private System.Windows.Forms.Button PiSayisiButon;
        private System.Windows.Forms.Button BirButonu;
        private System.Windows.Forms.Button IkiButonu;
        private System.Windows.Forms.Button UcButonu;
        private System.Windows.Forms.Button DortButonu;
        private System.Windows.Forms.Button BesButonu;
        private System.Windows.Forms.Button AltıButonu;
        private System.Windows.Forms.Button YediButonu;
        private System.Windows.Forms.Button SekizButonu;
        private System.Windows.Forms.Button DokuzButonu;
        private System.Windows.Forms.Button BolmeButonu;
        private System.Windows.Forms.Button CarpmaButonu;
        private System.Windows.Forms.Button ToplamaButonu;
        private System.Windows.Forms.Button CıkarmaButonu;
        private System.Windows.Forms.Button CEButonu;
        private System.Windows.Forms.Button C_Butonu;
        private System.Windows.Forms.Button tanButonu;
        private System.Windows.Forms.Button sinButonu;
        private System.Windows.Forms.Button cosButonu;
        private System.Windows.Forms.Button xKareButon;
        private System.Windows.Forms.Button UssuButon;
        private System.Windows.Forms.Button logButonu;
        private System.Windows.Forms.Button karekokButonu;
        private System.Windows.Forms.Button modButonu;
        private System.Windows.Forms.Label GecmisLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}

