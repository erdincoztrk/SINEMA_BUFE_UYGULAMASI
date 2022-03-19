
namespace SİNEMA_BÜFE_UYGULAMASI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.btncikoeksi = new System.Windows.Forms.Button();
            this.btnmisireksi = new System.Windows.Forms.Button();
            this.btnkcipseksi = new System.Windows.Forms.Button();
            this.btnbcipseksi = new System.Windows.Forms.Button();
            this.btnkolaeksi = new System.Windows.Forms.Button();
            this.btnsueksi = new System.Windows.Forms.Button();
            this.btncikolataarti = new System.Windows.Forms.Button();
            this.btnmisirarti = new System.Windows.Forms.Button();
            this.btnkcipsarti = new System.Windows.Forms.Button();
            this.btnbcipsarti = new System.Windows.Forms.Button();
            this.btnkolaarti = new System.Windows.Forms.Button();
            this.btnSuarttır = new System.Windows.Forms.Button();
            this.txtBcips = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCikolata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMisir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKcips = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKola = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.btnhspduzen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnhspduzen);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnHesap);
            this.groupBox1.Controls.Add(this.lblToplam);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(729, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 324);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KASA:";
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(103, 155);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 97);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "BİTİR VE YENİ ADİSYON AÇ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(103, 41);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(105, 49);
            this.btnHesap.TabIndex = 4;
            this.btnHesap.Text = "HESAPLA";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Tekton Pro Ext", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(207, 14);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(29, 25);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(85, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "TOPLAM:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(395, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 324);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİYAT LİSTESİ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(121, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "SU: 2.50 TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(93, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "KOLA: 5 TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "BÜYÜK CİPS: 8 TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(30, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 27);
            this.label12.TabIndex = 9;
            this.label12.Text = "KÜÇÜK CİPS: 6 TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(93, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 27);
            this.label13.TabIndex = 10;
            this.label13.Text = "MISIR: 15 TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(45, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 27);
            this.label14.TabIndex = 11;
            this.label14.Text = "ÇİKOLATA: 4.50 TL";
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupbox.Controls.Add(this.btncikoeksi);
            this.groupbox.Controls.Add(this.btnmisireksi);
            this.groupbox.Controls.Add(this.btnkcipseksi);
            this.groupbox.Controls.Add(this.btnbcipseksi);
            this.groupbox.Controls.Add(this.btnkolaeksi);
            this.groupbox.Controls.Add(this.btnsueksi);
            this.groupbox.Controls.Add(this.btncikolataarti);
            this.groupbox.Controls.Add(this.btnmisirarti);
            this.groupbox.Controls.Add(this.btnkcipsarti);
            this.groupbox.Controls.Add(this.btnbcipsarti);
            this.groupbox.Controls.Add(this.btnkolaarti);
            this.groupbox.Controls.Add(this.btnSuarttır);
            this.groupbox.Controls.Add(this.txtBcips);
            this.groupbox.Controls.Add(this.label8);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.label7);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.txtCikolata);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.txtMisir);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.txtKcips);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.txtKola);
            this.groupbox.Controls.Add(this.txtSu);
            this.groupbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupbox.Location = new System.Drawing.Point(55, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(308, 328);
            this.groupbox.TabIndex = 17;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "BÜFE:";
            // 
            // btncikoeksi
            // 
            this.btncikoeksi.Location = new System.Drawing.Point(148, 297);
            this.btncikoeksi.Name = "btncikoeksi";
            this.btncikoeksi.Size = new System.Drawing.Size(28, 31);
            this.btncikoeksi.TabIndex = 25;
            this.btncikoeksi.Text = "-";
            this.btncikoeksi.UseVisualStyleBackColor = true;
            this.btncikoeksi.Click += new System.EventHandler(this.btncikoeksi_Click);
            // 
            // btnmisireksi
            // 
            this.btnmisireksi.Location = new System.Drawing.Point(148, 254);
            this.btnmisireksi.Name = "btnmisireksi";
            this.btnmisireksi.Size = new System.Drawing.Size(28, 28);
            this.btnmisireksi.TabIndex = 24;
            this.btnmisireksi.Text = "-";
            this.btnmisireksi.UseVisualStyleBackColor = true;
            this.btnmisireksi.Click += new System.EventHandler(this.btnmisireksi_Click);
            // 
            // btnkcipseksi
            // 
            this.btnkcipseksi.Location = new System.Drawing.Point(148, 206);
            this.btnkcipseksi.Name = "btnkcipseksi";
            this.btnkcipseksi.Size = new System.Drawing.Size(28, 29);
            this.btnkcipseksi.TabIndex = 23;
            this.btnkcipseksi.Text = "-";
            this.btnkcipseksi.UseVisualStyleBackColor = true;
            this.btnkcipseksi.Click += new System.EventHandler(this.btnkcipseksi_Click);
            // 
            // btnbcipseksi
            // 
            this.btnbcipseksi.Location = new System.Drawing.Point(148, 157);
            this.btnbcipseksi.Name = "btnbcipseksi";
            this.btnbcipseksi.Size = new System.Drawing.Size(28, 27);
            this.btnbcipseksi.TabIndex = 22;
            this.btnbcipseksi.Text = "-";
            this.btnbcipseksi.UseVisualStyleBackColor = true;
            this.btnbcipseksi.Click += new System.EventHandler(this.btnbcipseksi_Click);
            // 
            // btnkolaeksi
            // 
            this.btnkolaeksi.Location = new System.Drawing.Point(148, 109);
            this.btnkolaeksi.Name = "btnkolaeksi";
            this.btnkolaeksi.Size = new System.Drawing.Size(28, 29);
            this.btnkolaeksi.TabIndex = 21;
            this.btnkolaeksi.Text = "-";
            this.btnkolaeksi.UseVisualStyleBackColor = true;
            this.btnkolaeksi.Click += new System.EventHandler(this.btnkolaeksi_Click);
            // 
            // btnsueksi
            // 
            this.btnsueksi.Location = new System.Drawing.Point(148, 63);
            this.btnsueksi.Name = "btnsueksi";
            this.btnsueksi.Size = new System.Drawing.Size(28, 28);
            this.btnsueksi.TabIndex = 20;
            this.btnsueksi.Text = "-";
            this.btnsueksi.UseVisualStyleBackColor = true;
            this.btnsueksi.Click += new System.EventHandler(this.btnsueksi_Click);
            // 
            // btncikolataarti
            // 
            this.btncikolataarti.Location = new System.Drawing.Point(246, 298);
            this.btncikolataarti.Name = "btncikolataarti";
            this.btncikolataarti.Size = new System.Drawing.Size(28, 30);
            this.btncikolataarti.TabIndex = 19;
            this.btncikolataarti.Text = "+";
            this.btncikolataarti.UseVisualStyleBackColor = true;
            this.btncikolataarti.Click += new System.EventHandler(this.btncikolataarti_Click);
            // 
            // btnmisirarti
            // 
            this.btnmisirarti.Location = new System.Drawing.Point(246, 254);
            this.btnmisirarti.Name = "btnmisirarti";
            this.btnmisirarti.Size = new System.Drawing.Size(28, 28);
            this.btnmisirarti.TabIndex = 18;
            this.btnmisirarti.Text = "+";
            this.btnmisirarti.UseVisualStyleBackColor = true;
            this.btnmisirarti.Click += new System.EventHandler(this.btnmisirarti_Click);
            // 
            // btnkcipsarti
            // 
            this.btnkcipsarti.Location = new System.Drawing.Point(246, 206);
            this.btnkcipsarti.Name = "btnkcipsarti";
            this.btnkcipsarti.Size = new System.Drawing.Size(28, 29);
            this.btnkcipsarti.TabIndex = 17;
            this.btnkcipsarti.Text = "+";
            this.btnkcipsarti.UseVisualStyleBackColor = true;
            this.btnkcipsarti.Click += new System.EventHandler(this.btnkcipsarti_Click);
            // 
            // btnbcipsarti
            // 
            this.btnbcipsarti.Location = new System.Drawing.Point(246, 157);
            this.btnbcipsarti.Name = "btnbcipsarti";
            this.btnbcipsarti.Size = new System.Drawing.Size(28, 27);
            this.btnbcipsarti.TabIndex = 16;
            this.btnbcipsarti.Text = "+";
            this.btnbcipsarti.UseVisualStyleBackColor = true;
            this.btnbcipsarti.Click += new System.EventHandler(this.btnbcipsarti_Click);
            // 
            // btnkolaarti
            // 
            this.btnkolaarti.Location = new System.Drawing.Point(246, 109);
            this.btnkolaarti.Name = "btnkolaarti";
            this.btnkolaarti.Size = new System.Drawing.Size(28, 29);
            this.btnkolaarti.TabIndex = 15;
            this.btnkolaarti.Text = "+";
            this.btnkolaarti.UseVisualStyleBackColor = true;
            this.btnkolaarti.Click += new System.EventHandler(this.btnkolaarti_Click);
            // 
            // btnSuarttır
            // 
            this.btnSuarttır.Location = new System.Drawing.Point(246, 63);
            this.btnSuarttır.Name = "btnSuarttır";
            this.btnSuarttır.Size = new System.Drawing.Size(28, 28);
            this.btnSuarttır.TabIndex = 14;
            this.btnSuarttır.Text = "+";
            this.btnSuarttır.UseVisualStyleBackColor = true;
            this.btnSuarttır.Click += new System.EventHandler(this.btnSuarttır_Click);
            // 
            // txtBcips
            // 
            this.txtBcips.Location = new System.Drawing.Point(182, 157);
            this.txtBcips.Name = "txtBcips";
            this.txtBcips.Size = new System.Drawing.Size(58, 26);
            this.txtBcips.TabIndex = 8;
            this.txtBcips.Text = "0";
            this.txtBcips.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBcips_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(187, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "ADET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(102, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(117, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "TÜR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(74, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "KOLA";
            // 
            // txtCikolata
            // 
            this.txtCikolata.Location = new System.Drawing.Point(182, 298);
            this.txtCikolata.Name = "txtCikolata";
            this.txtCikolata.Size = new System.Drawing.Size(58, 26);
            this.txtCikolata.TabIndex = 11;
            this.txtCikolata.Text = "0";
            this.txtCikolata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCikolata_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "BÜYÜK CİPS";
            // 
            // txtMisir
            // 
            this.txtMisir.Location = new System.Drawing.Point(182, 255);
            this.txtMisir.Name = "txtMisir";
            this.txtMisir.Size = new System.Drawing.Size(58, 26);
            this.txtMisir.TabIndex = 10;
            this.txtMisir.Text = "0";
            this.txtMisir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMisir_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "KÜÇÜK CİPS";
            // 
            // txtKcips
            // 
            this.txtKcips.Location = new System.Drawing.Point(182, 208);
            this.txtKcips.Name = "txtKcips";
            this.txtKcips.Size = new System.Drawing.Size(58, 26);
            this.txtKcips.TabIndex = 9;
            this.txtKcips.Text = "0";
            this.txtKcips.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKcips_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(74, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "MISIR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÇİKOLATA";
            // 
            // txtKola
            // 
            this.txtKola.Location = new System.Drawing.Point(182, 111);
            this.txtKola.Name = "txtKola";
            this.txtKola.Size = new System.Drawing.Size(58, 26);
            this.txtKola.TabIndex = 7;
            this.txtKola.Text = "0";
            this.txtKola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKola_KeyPress);
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(182, 65);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(58, 26);
            this.txtSu.TabIndex = 6;
            this.txtSu.Text = "0";
            this.txtSu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSu_KeyPress);
            // 
            // btnhspduzen
            // 
            this.btnhspduzen.Enabled = false;
            this.btnhspduzen.Location = new System.Drawing.Point(103, 96);
            this.btnhspduzen.Name = "btnhspduzen";
            this.btnhspduzen.Size = new System.Drawing.Size(105, 57);
            this.btnhspduzen.TabIndex = 6;
            this.btnhspduzen.Text = "HESABI DÜZENLE";
            this.btnhspduzen.UseVisualStyleBackColor = true;
            this.btnhspduzen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(80, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "KASAYI KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BÜFE SATIŞ UYGULAMASI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Button btncikoeksi;
        private System.Windows.Forms.Button btnmisireksi;
        private System.Windows.Forms.Button btnkcipseksi;
        private System.Windows.Forms.Button btnbcipseksi;
        private System.Windows.Forms.Button btnkolaeksi;
        private System.Windows.Forms.Button btnsueksi;
        private System.Windows.Forms.Button btncikolataarti;
        private System.Windows.Forms.Button btnmisirarti;
        private System.Windows.Forms.Button btnkcipsarti;
        private System.Windows.Forms.Button btnbcipsarti;
        private System.Windows.Forms.Button btnkolaarti;
        private System.Windows.Forms.Button btnSuarttır;
        private System.Windows.Forms.TextBox txtBcips;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCikolata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMisir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKcips;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKola;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Button btnhspduzen;
        private System.Windows.Forms.Button button1;
    }
}

