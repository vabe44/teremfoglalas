namespace teremfoglalas
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
            this.chProjektor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSzeminarium = new System.Windows.Forms.RadioButton();
            this.numKapacitas = new System.Windows.Forms.NumericUpDown();
            this.rbGep = new System.Windows.Forms.RadioButton();
            this.numSzgepSzam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFilces = new System.Windows.Forms.RadioButton();
            this.rbKretas = new System.Windows.Forms.RadioButton();
            this.lbSzgepSzam = new System.Windows.Forms.Label();
            this.rbEloado = new System.Windows.Forms.RadioButton();
            this.btKeres = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTeremOsszKapacitas = new System.Windows.Forms.Label();
            this.lbTeremValosOsszKapacitas = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTalalat = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKapacitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSzgepSzam)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chProjektor
            // 
            this.chProjektor.AutoSize = true;
            this.chProjektor.Location = new System.Drawing.Point(119, 60);
            this.chProjektor.Name = "chProjektor";
            this.chProjektor.Size = new System.Drawing.Size(67, 17);
            this.chProjektor.TabIndex = 7;
            this.chProjektor.Text = "projektor";
            this.chProjektor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSzeminarium);
            this.groupBox1.Controls.Add(this.numKapacitas);
            this.groupBox1.Controls.Add(this.rbGep);
            this.groupBox1.Controls.Add(this.numSzgepSzam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbSzgepSzam);
            this.groupBox1.Controls.Add(this.chProjektor);
            this.groupBox1.Controls.Add(this.rbEloado);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terem típusa és jellemzői";
            // 
            // rbSzeminarium
            // 
            this.rbSzeminarium.AutoSize = true;
            this.rbSzeminarium.Location = new System.Drawing.Point(6, 169);
            this.rbSzeminarium.Name = "rbSzeminarium";
            this.rbSzeminarium.Size = new System.Drawing.Size(113, 17);
            this.rbSzeminarium.TabIndex = 2;
            this.rbSzeminarium.Text = "Szeminárium terem";
            this.rbSzeminarium.UseVisualStyleBackColor = true;
            this.rbSzeminarium.CheckedChanged += new System.EventHandler(this.teremtipus_valtozas);
            // 
            // numKapacitas
            // 
            this.numKapacitas.Location = new System.Drawing.Point(75, 21);
            this.numKapacitas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKapacitas.Name = "numKapacitas";
            this.numKapacitas.Size = new System.Drawing.Size(44, 20);
            this.numKapacitas.TabIndex = 10;
            this.numKapacitas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rbGep
            // 
            this.rbGep.AutoSize = true;
            this.rbGep.Location = new System.Drawing.Point(6, 114);
            this.rbGep.Name = "rbGep";
            this.rbGep.Size = new System.Drawing.Size(71, 17);
            this.rbGep.TabIndex = 1;
            this.rbGep.Text = "Gépterem";
            this.rbGep.UseVisualStyleBackColor = true;
            this.rbGep.CheckedChanged += new System.EventHandler(this.teremtipus_valtozas);
            // 
            // numSzgepSzam
            // 
            this.numSzgepSzam.Enabled = false;
            this.numSzgepSzam.Location = new System.Drawing.Point(234, 114);
            this.numSzgepSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSzgepSzam.Name = "numSzgepSzam";
            this.numSzgepSzam.Size = new System.Drawing.Size(35, 20);
            this.numSzgepSzam.TabIndex = 12;
            this.numSzgepSzam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kapacitás:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFilces);
            this.groupBox2.Controls.Add(this.rbKretas);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(125, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 48);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tábla típusa";
            // 
            // rbFilces
            // 
            this.rbFilces.AutoSize = true;
            this.rbFilces.Location = new System.Drawing.Point(85, 19);
            this.rbFilces.Name = "rbFilces";
            this.rbFilces.Size = new System.Drawing.Size(52, 17);
            this.rbFilces.TabIndex = 1;
            this.rbFilces.Text = "Filces";
            this.rbFilces.UseVisualStyleBackColor = true;
            // 
            // rbKretas
            // 
            this.rbKretas.AutoSize = true;
            this.rbKretas.Checked = true;
            this.rbKretas.Location = new System.Drawing.Point(24, 19);
            this.rbKretas.Name = "rbKretas";
            this.rbKretas.Size = new System.Drawing.Size(55, 17);
            this.rbKretas.TabIndex = 0;
            this.rbKretas.TabStop = true;
            this.rbKretas.Text = "Krétás";
            this.rbKretas.UseVisualStyleBackColor = true;
            // 
            // lbSzgepSzam
            // 
            this.lbSzgepSzam.AutoSize = true;
            this.lbSzgepSzam.Location = new System.Drawing.Point(116, 116);
            this.lbSzgepSzam.Name = "lbSzgepSzam";
            this.lbSzgepSzam.Size = new System.Drawing.Size(112, 13);
            this.lbSzgepSzam.TabIndex = 11;
            this.lbSzgepSzam.Text = "Számítógépek száma:";
            // 
            // rbEloado
            // 
            this.rbEloado.AutoSize = true;
            this.rbEloado.Checked = true;
            this.rbEloado.Location = new System.Drawing.Point(6, 60);
            this.rbEloado.Name = "rbEloado";
            this.rbEloado.Size = new System.Drawing.Size(87, 17);
            this.rbEloado.TabIndex = 0;
            this.rbEloado.TabStop = true;
            this.rbEloado.Text = "Előadó terem";
            this.rbEloado.UseVisualStyleBackColor = true;
            this.rbEloado.CheckedChanged += new System.EventHandler(this.teremtipus_valtozas);
            // 
            // btKeres
            // 
            this.btKeres.Location = new System.Drawing.Point(15, 268);
            this.btKeres.Name = "btKeres";
            this.btKeres.Size = new System.Drawing.Size(321, 23);
            this.btKeres.TabIndex = 14;
            this.btKeres.Text = "Keresés";
            this.btKeres.UseVisualStyleBackColor = true;
            this.btKeres.Click += new System.EventHandler(this.btKeres_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Termek összkapacitása:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Termek valós összkapacitása:";
            // 
            // lbTeremOsszKapacitas
            // 
            this.lbTeremOsszKapacitas.AutoSize = true;
            this.lbTeremOsszKapacitas.Location = new System.Drawing.Point(131, 9);
            this.lbTeremOsszKapacitas.Name = "lbTeremOsszKapacitas";
            this.lbTeremOsszKapacitas.Size = new System.Drawing.Size(16, 13);
            this.lbTeremOsszKapacitas.TabIndex = 19;
            this.lbTeremOsszKapacitas.Text = "...";
            // 
            // lbTeremValosOsszKapacitas
            // 
            this.lbTeremValosOsszKapacitas.AutoSize = true;
            this.lbTeremValosOsszKapacitas.Location = new System.Drawing.Point(308, 9);
            this.lbTeremValosOsszKapacitas.Name = "lbTeremValosOsszKapacitas";
            this.lbTeremValosOsszKapacitas.Size = new System.Drawing.Size(16, 13);
            this.lbTeremValosOsszKapacitas.TabIndex = 20;
            this.lbTeremValosOsszKapacitas.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.lbTalalat);
            this.groupBox4.Location = new System.Drawing.Point(12, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 131);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Találati lista:";
            // 
            // lbTalalat
            // 
            this.lbTalalat.FormattingEnabled = true;
            this.lbTalalat.Location = new System.Drawing.Point(12, 23);
            this.lbTalalat.Name = "lbTalalat";
            this.lbTalalat.Size = new System.Drawing.Size(300, 95);
            this.lbTalalat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 444);
            this.Controls.Add(this.btKeres);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbTeremValosOsszKapacitas);
            this.Controls.Add(this.lbTeremOsszKapacitas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terem foglalás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKapacitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSzgepSzam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chProjektor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSzeminarium;
        private System.Windows.Forms.RadioButton rbGep;
        private System.Windows.Forms.RadioButton rbEloado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKapacitas;
        private System.Windows.Forms.Label lbSzgepSzam;
        private System.Windows.Forms.NumericUpDown numSzgepSzam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFilces;
        private System.Windows.Forms.RadioButton rbKretas;
        private System.Windows.Forms.Button btKeres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTeremOsszKapacitas;
        private System.Windows.Forms.Label lbTeremValosOsszKapacitas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbTalalat;

    }
}

