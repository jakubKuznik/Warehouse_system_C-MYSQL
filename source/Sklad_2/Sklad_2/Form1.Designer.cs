namespace Sklad_2
{
    partial class Sklad
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
            this.sirka_skladu_label = new System.Windows.Forms.Label();
            this.vyska_skladu_label = new System.Windows.Forms.Label();
            this.sirka_skladu_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.vyska_skladu_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.m1 = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.Label();
            this.sklad_groupbox = new System.Windows.Forms.GroupBox();
            this.sirka_police_label = new System.Windows.Forms.Label();
            this.vyska_police_label = new System.Windows.Forms.Label();
            this.pocet_polic_label = new System.Windows.Forms.Label();
            this.sirka_police_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.vyska_police_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.pocet_polic_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.police_groupbox = new System.Windows.Forms.GroupBox();
            this.sirka_krabice_label = new System.Windows.Forms.Label();
            this.vyska_krabice_label = new System.Windows.Forms.Label();
            this.sirka_krabice_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.vyska_krabice_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.krabice_groupbox = new System.Windows.Forms.GroupBox();
            this.vypocet_poctu_krabic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pocet_krabic_vertikalne_label = new System.Windows.Forms.Label();
            this.pocet_krabic_horizontalne_label = new System.Windows.Forms.Label();
            this.pocet_krabic_celkem_label = new System.Windows.Forms.Label();
            this.pocet_krabic_v_jednotlive_polici_label = new System.Windows.Forms.Label();
            this.celkova_plocha_skladu_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sirka_skladu_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_skladu_numeric_updown)).BeginInit();
            this.sklad_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirka_police_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_police_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocet_polic_numeric_updown)).BeginInit();
            this.police_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirka_krabice_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_krabice_numeric_updown)).BeginInit();
            this.krabice_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sirka_skladu_label
            // 
            this.sirka_skladu_label.AutoSize = true;
            this.sirka_skladu_label.Location = new System.Drawing.Point(14, 26);
            this.sirka_skladu_label.Name = "sirka_skladu_label";
            this.sirka_skladu_label.Size = new System.Drawing.Size(68, 13);
            this.sirka_skladu_label.TabIndex = 0;
            this.sirka_skladu_label.Text = "Šířka skladu";
            // 
            // vyska_skladu_label
            // 
            this.vyska_skladu_label.AutoSize = true;
            this.vyska_skladu_label.Location = new System.Drawing.Point(14, 53);
            this.vyska_skladu_label.Name = "vyska_skladu_label";
            this.vyska_skladu_label.Size = new System.Drawing.Size(70, 13);
            this.vyska_skladu_label.TabIndex = 1;
            this.vyska_skladu_label.Text = "Výška skladu";
            // 
            // sirka_skladu_numeric_updown
            // 
            this.sirka_skladu_numeric_updown.Location = new System.Drawing.Point(90, 24);
            this.sirka_skladu_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sirka_skladu_numeric_updown.Name = "sirka_skladu_numeric_updown";
            this.sirka_skladu_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.sirka_skladu_numeric_updown.TabIndex = 2;
            this.sirka_skladu_numeric_updown.ValueChanged += new System.EventHandler(this.sirka_skladu_numeric_updown_ValueChanged);
            // 
            // vyska_skladu_numeric_updown
            // 
            this.vyska_skladu_numeric_updown.Location = new System.Drawing.Point(90, 51);
            this.vyska_skladu_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vyska_skladu_numeric_updown.Name = "vyska_skladu_numeric_updown";
            this.vyska_skladu_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.vyska_skladu_numeric_updown.TabIndex = 3;
            this.vyska_skladu_numeric_updown.ValueChanged += new System.EventHandler(this.vyska_skladu_numeric_updown_ValueChanged);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(179, 26);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(15, 13);
            this.m1.TabIndex = 4;
            this.m1.Text = "m";
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Location = new System.Drawing.Point(179, 53);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(15, 13);
            this.m2.TabIndex = 5;
            this.m2.Text = "m";
            // 
            // sklad_groupbox
            // 
            this.sklad_groupbox.Controls.Add(this.m2);
            this.sklad_groupbox.Controls.Add(this.m1);
            this.sklad_groupbox.Controls.Add(this.vyska_skladu_numeric_updown);
            this.sklad_groupbox.Controls.Add(this.sirka_skladu_numeric_updown);
            this.sklad_groupbox.Controls.Add(this.vyska_skladu_label);
            this.sklad_groupbox.Controls.Add(this.sirka_skladu_label);
            this.sklad_groupbox.Location = new System.Drawing.Point(12, 26);
            this.sklad_groupbox.Name = "sklad_groupbox";
            this.sklad_groupbox.Size = new System.Drawing.Size(209, 89);
            this.sklad_groupbox.TabIndex = 8;
            this.sklad_groupbox.TabStop = false;
            this.sklad_groupbox.Text = "Sklad";
            // 
            // sirka_police_label
            // 
            this.sirka_police_label.AutoSize = true;
            this.sirka_police_label.Location = new System.Drawing.Point(12, 27);
            this.sirka_police_label.Name = "sirka_police_label";
            this.sirka_police_label.Size = new System.Drawing.Size(65, 13);
            this.sirka_police_label.TabIndex = 11;
            this.sirka_police_label.Text = "Šířka police";
            // 
            // vyska_police_label
            // 
            this.vyska_police_label.AutoSize = true;
            this.vyska_police_label.Location = new System.Drawing.Point(12, 51);
            this.vyska_police_label.Name = "vyska_police_label";
            this.vyska_police_label.Size = new System.Drawing.Size(67, 13);
            this.vyska_police_label.TabIndex = 12;
            this.vyska_police_label.Text = "Výška police";
            // 
            // pocet_polic_label
            // 
            this.pocet_polic_label.AutoSize = true;
            this.pocet_polic_label.Location = new System.Drawing.Point(12, 76);
            this.pocet_polic_label.Name = "pocet_polic_label";
            this.pocet_polic_label.Size = new System.Drawing.Size(60, 13);
            this.pocet_polic_label.TabIndex = 13;
            this.pocet_polic_label.Text = "Počet polic";
            // 
            // sirka_police_numeric_updown
            // 
            this.sirka_police_numeric_updown.DecimalPlaces = 1;
            this.sirka_police_numeric_updown.Location = new System.Drawing.Point(88, 23);
            this.sirka_police_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sirka_police_numeric_updown.Name = "sirka_police_numeric_updown";
            this.sirka_police_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.sirka_police_numeric_updown.TabIndex = 14;
            this.sirka_police_numeric_updown.ValueChanged += new System.EventHandler(this.sirka_police_numeric_updown_ValueChanged);
            // 
            // vyska_police_numeric_updown
            // 
            this.vyska_police_numeric_updown.DecimalPlaces = 1;
            this.vyska_police_numeric_updown.Location = new System.Drawing.Point(88, 49);
            this.vyska_police_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vyska_police_numeric_updown.Name = "vyska_police_numeric_updown";
            this.vyska_police_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.vyska_police_numeric_updown.TabIndex = 15;
            this.vyska_police_numeric_updown.ValueChanged += new System.EventHandler(this.vyska_police_numeric_updown_ValueChanged);
            // 
            // pocet_polic_numeric_updown
            // 
            this.pocet_polic_numeric_updown.Location = new System.Drawing.Point(88, 74);
            this.pocet_polic_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pocet_polic_numeric_updown.Name = "pocet_polic_numeric_updown";
            this.pocet_polic_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.pocet_polic_numeric_updown.TabIndex = 16;
            this.pocet_polic_numeric_updown.ValueChanged += new System.EventHandler(this.pocet_polic_numeric_updown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "cm";
            // 
            // police_groupbox
            // 
            this.police_groupbox.Controls.Add(this.label7);
            this.police_groupbox.Controls.Add(this.label6);
            this.police_groupbox.Controls.Add(this.pocet_polic_numeric_updown);
            this.police_groupbox.Controls.Add(this.vyska_police_numeric_updown);
            this.police_groupbox.Controls.Add(this.sirka_police_numeric_updown);
            this.police_groupbox.Controls.Add(this.pocet_polic_label);
            this.police_groupbox.Controls.Add(this.vyska_police_label);
            this.police_groupbox.Controls.Add(this.sirka_police_label);
            this.police_groupbox.Location = new System.Drawing.Point(14, 126);
            this.police_groupbox.Name = "police_groupbox";
            this.police_groupbox.Size = new System.Drawing.Size(207, 110);
            this.police_groupbox.TabIndex = 20;
            this.police_groupbox.TabStop = false;
            this.police_groupbox.Text = "Police";
            // 
            // sirka_krabice_label
            // 
            this.sirka_krabice_label.AutoSize = true;
            this.sirka_krabice_label.Location = new System.Drawing.Point(12, 32);
            this.sirka_krabice_label.Name = "sirka_krabice_label";
            this.sirka_krabice_label.Size = new System.Drawing.Size(72, 13);
            this.sirka_krabice_label.TabIndex = 21;
            this.sirka_krabice_label.Text = "Šířka krabice";
            // 
            // vyska_krabice_label
            // 
            this.vyska_krabice_label.AutoSize = true;
            this.vyska_krabice_label.Location = new System.Drawing.Point(12, 58);
            this.vyska_krabice_label.Name = "vyska_krabice_label";
            this.vyska_krabice_label.Size = new System.Drawing.Size(74, 13);
            this.vyska_krabice_label.TabIndex = 22;
            this.vyska_krabice_label.Text = "Výška krabice";
            // 
            // sirka_krabice_numeric_updown
            // 
            this.sirka_krabice_numeric_updown.DecimalPlaces = 1;
            this.sirka_krabice_numeric_updown.Location = new System.Drawing.Point(88, 30);
            this.sirka_krabice_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sirka_krabice_numeric_updown.Name = "sirka_krabice_numeric_updown";
            this.sirka_krabice_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.sirka_krabice_numeric_updown.TabIndex = 23;
            this.sirka_krabice_numeric_updown.ValueChanged += new System.EventHandler(this.sirka_krabice_numeric_updown_ValueChanged);
            // 
            // vyska_krabice_numeric_updown
            // 
            this.vyska_krabice_numeric_updown.DecimalPlaces = 1;
            this.vyska_krabice_numeric_updown.Location = new System.Drawing.Point(88, 56);
            this.vyska_krabice_numeric_updown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vyska_krabice_numeric_updown.Name = "vyska_krabice_numeric_updown";
            this.vyska_krabice_numeric_updown.Size = new System.Drawing.Size(82, 20);
            this.vyska_krabice_numeric_updown.TabIndex = 24;
            this.vyska_krabice_numeric_updown.ValueChanged += new System.EventHandler(this.vyska_krabice_numeric_updown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "cm";
            // 
            // krabice_groupbox
            // 
            this.krabice_groupbox.Controls.Add(this.label9);
            this.krabice_groupbox.Controls.Add(this.label5);
            this.krabice_groupbox.Controls.Add(this.vyska_krabice_numeric_updown);
            this.krabice_groupbox.Controls.Add(this.sirka_krabice_numeric_updown);
            this.krabice_groupbox.Controls.Add(this.vyska_krabice_label);
            this.krabice_groupbox.Controls.Add(this.sirka_krabice_label);
            this.krabice_groupbox.Location = new System.Drawing.Point(14, 242);
            this.krabice_groupbox.Name = "krabice_groupbox";
            this.krabice_groupbox.Size = new System.Drawing.Size(206, 88);
            this.krabice_groupbox.TabIndex = 27;
            this.krabice_groupbox.TabStop = false;
            this.krabice_groupbox.Text = "Krabice";
            // 
            // vypocet_poctu_krabic
            // 
            this.vypocet_poctu_krabic.Location = new System.Drawing.Point(46, 350);
            this.vypocet_poctu_krabic.Name = "vypocet_poctu_krabic";
            this.vypocet_poctu_krabic.Size = new System.Drawing.Size(138, 23);
            this.vypocet_poctu_krabic.TabIndex = 28;
            this.vypocet_poctu_krabic.Text = "Vypočítat počet krabic";
            this.vypocet_poctu_krabic.UseVisualStyleBackColor = true;
            this.vypocet_poctu_krabic.Click += new System.EventHandler(this.vypocet_poctu_krabic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Počet krabic vertikálně";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Počet krabic hotizontálně";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Počet krabic celkem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Počet krabic v jednotlivé polici";
            // 
            // pocet_krabic_vertikalne_label
            // 
            this.pocet_krabic_vertikalne_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pocet_krabic_vertikalne_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_krabic_vertikalne_label.Location = new System.Drawing.Point(179, 451);
            this.pocet_krabic_vertikalne_label.Name = "pocet_krabic_vertikalne_label";
            this.pocet_krabic_vertikalne_label.Size = new System.Drawing.Size(43, 22);
            this.pocet_krabic_vertikalne_label.TabIndex = 33;
            // 
            // pocet_krabic_horizontalne_label
            // 
            this.pocet_krabic_horizontalne_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pocet_krabic_horizontalne_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_krabic_horizontalne_label.Location = new System.Drawing.Point(179, 422);
            this.pocet_krabic_horizontalne_label.Name = "pocet_krabic_horizontalne_label";
            this.pocet_krabic_horizontalne_label.Size = new System.Drawing.Size(43, 22);
            this.pocet_krabic_horizontalne_label.TabIndex = 34;
            // 
            // pocet_krabic_celkem_label
            // 
            this.pocet_krabic_celkem_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pocet_krabic_celkem_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_krabic_celkem_label.Location = new System.Drawing.Point(179, 392);
            this.pocet_krabic_celkem_label.Name = "pocet_krabic_celkem_label";
            this.pocet_krabic_celkem_label.Size = new System.Drawing.Size(43, 22);
            this.pocet_krabic_celkem_label.TabIndex = 35;
            // 
            // pocet_krabic_v_jednotlive_polici_label
            // 
            this.pocet_krabic_v_jednotlive_polici_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pocet_krabic_v_jednotlive_polici_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_krabic_v_jednotlive_polici_label.Location = new System.Drawing.Point(179, 478);
            this.pocet_krabic_v_jednotlive_polici_label.Name = "pocet_krabic_v_jednotlive_polici_label";
            this.pocet_krabic_v_jednotlive_polici_label.Size = new System.Drawing.Size(43, 22);
            this.pocet_krabic_v_jednotlive_polici_label.TabIndex = 36;
            // 
            // celkova_plocha_skladu_label
            // 
            this.celkova_plocha_skladu_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.celkova_plocha_skladu_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celkova_plocha_skladu_label.Location = new System.Drawing.Point(178, 509);
            this.celkova_plocha_skladu_label.Name = "celkova_plocha_skladu_label";
            this.celkova_plocha_skladu_label.Size = new System.Drawing.Size(43, 22);
            this.celkova_plocha_skladu_label.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 510);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Celková plocha skladu (m2)";
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 570);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.celkova_plocha_skladu_label);
            this.Controls.Add(this.pocet_krabic_v_jednotlive_polici_label);
            this.Controls.Add(this.pocet_krabic_celkem_label);
            this.Controls.Add(this.pocet_krabic_horizontalne_label);
            this.Controls.Add(this.pocet_krabic_vertikalne_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vypocet_poctu_krabic);
            this.Controls.Add(this.krabice_groupbox);
            this.Controls.Add(this.police_groupbox);
            this.Controls.Add(this.sklad_groupbox);
            this.Name = "Sklad";
            this.Text = "Sklad 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.sirka_skladu_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_skladu_numeric_updown)).EndInit();
            this.sklad_groupbox.ResumeLayout(false);
            this.sklad_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirka_police_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_police_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocet_polic_numeric_updown)).EndInit();
            this.police_groupbox.ResumeLayout(false);
            this.police_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirka_krabice_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyska_krabice_numeric_updown)).EndInit();
            this.krabice_groupbox.ResumeLayout(false);
            this.krabice_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sirka_skladu_label;
        private System.Windows.Forms.Label vyska_skladu_label;
        private System.Windows.Forms.NumericUpDown sirka_skladu_numeric_updown;
        private System.Windows.Forms.NumericUpDown vyska_skladu_numeric_updown;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.Label m2;
        private System.Windows.Forms.GroupBox sklad_groupbox;
        private System.Windows.Forms.Label sirka_police_label;
        private System.Windows.Forms.Label vyska_police_label;
        private System.Windows.Forms.Label pocet_polic_label;
        private System.Windows.Forms.NumericUpDown sirka_police_numeric_updown;
        private System.Windows.Forms.NumericUpDown vyska_police_numeric_updown;
        private System.Windows.Forms.NumericUpDown pocet_polic_numeric_updown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox police_groupbox;
        private System.Windows.Forms.Label sirka_krabice_label;
        private System.Windows.Forms.Label vyska_krabice_label;
        private System.Windows.Forms.NumericUpDown sirka_krabice_numeric_updown;
        private System.Windows.Forms.NumericUpDown vyska_krabice_numeric_updown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox krabice_groupbox;
        private System.Windows.Forms.Button vypocet_poctu_krabic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pocet_krabic_vertikalne_label;
        private System.Windows.Forms.Label pocet_krabic_horizontalne_label;
        private System.Windows.Forms.Label pocet_krabic_celkem_label;
        private System.Windows.Forms.Label pocet_krabic_v_jednotlive_polici_label;
        private System.Windows.Forms.Label celkova_plocha_skladu_label;
        private System.Windows.Forms.Label label14;
    }
}

