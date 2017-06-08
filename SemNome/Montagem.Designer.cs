namespace SemNome
{
    partial class Montagem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeixa1 = new System.Windows.Forms.TextBox();
            this.txtRotina1 = new System.Windows.Forms.TextBox();
            this.txtRecompensa1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureRotina = new System.Windows.Forms.PictureBox();
            this.pictureDeixa = new System.Windows.Forms.PictureBox();
            this.pictureRecompensa = new System.Windows.Forms.PictureBox();
            this.timer12h = new System.Windows.Forms.Timer(this.components);
            this.timer24h = new System.Windows.Forms.Timer(this.components);
            this.timer8h = new System.Windows.Forms.Timer(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRotina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecompensa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recompensa";
            // 
            // txtDeixa1
            // 
            this.txtDeixa1.Location = new System.Drawing.Point(87, 260);
            this.txtDeixa1.Multiline = true;
            this.txtDeixa1.Name = "txtDeixa1";
            this.txtDeixa1.Size = new System.Drawing.Size(98, 70);
            this.txtDeixa1.TabIndex = 3;
            // 
            // txtRotina1
            // 
            this.txtRotina1.Location = new System.Drawing.Point(310, 167);
            this.txtRotina1.Multiline = true;
            this.txtRotina1.Name = "txtRotina1";
            this.txtRotina1.Size = new System.Drawing.Size(83, 72);
            this.txtRotina1.TabIndex = 4;
            // 
            // txtRecompensa1
            // 
            this.txtRecompensa1.Location = new System.Drawing.Point(527, 130);
            this.txtRecompensa1.Multiline = true;
            this.txtRecompensa1.Name = "txtRecompensa1";
            this.txtRecompensa1.Size = new System.Drawing.Size(85, 74);
            this.txtRecompensa1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.cmbPeriodo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDias);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.txtRotina1);
            this.panel1.Controls.Add(this.txtDeixa1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRecompensa1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureRotina);
            this.panel1.Controls.Add(this.pictureDeixa);
            this.panel1.Controls.Add(this.pictureRecompensa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 460);
            this.panel1.TabIndex = 9;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "8",
            "12",
            "24"});
            this.cmbPeriodo.Location = new System.Drawing.Point(442, 389);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(113, 21);
            this.cmbPeriodo.TabIndex = 21;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 47);
            this.label7.TabIndex = 20;
            this.label7.Text = "Monte seu novo hábito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Período (Ex: a cada 24 horas)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quando? (Quant. em Dias)";
            // 
            // cmbDias
            // 
            this.cmbDias.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDias.Location = new System.Drawing.Point(283, 388);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(121, 21);
            this.cmbDias.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lembrete";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(591, 388);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureRotina
            // 
            this.pictureRotina.Image = global::SemNome.Properties.Resources.rotina;
            this.pictureRotina.Location = new System.Drawing.Point(248, 93);
            this.pictureRotina.Name = "pictureRotina";
            this.pictureRotina.Size = new System.Drawing.Size(206, 188);
            this.pictureRotina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRotina.TabIndex = 9;
            this.pictureRotina.TabStop = false;
            // 
            // pictureDeixa
            // 
            this.pictureDeixa.Image = global::SemNome.Properties.Resources.deixa;
            this.pictureDeixa.Location = new System.Drawing.Point(36, 193);
            this.pictureDeixa.Name = "pictureDeixa";
            this.pictureDeixa.Size = new System.Drawing.Size(206, 193);
            this.pictureDeixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDeixa.TabIndex = 8;
            this.pictureDeixa.TabStop = false;
            // 
            // pictureRecompensa
            // 
            this.pictureRecompensa.Image = global::SemNome.Properties.Resources.recompensa;
            this.pictureRecompensa.Location = new System.Drawing.Point(470, 51);
            this.pictureRecompensa.Name = "pictureRecompensa";
            this.pictureRecompensa.Size = new System.Drawing.Size(206, 188);
            this.pictureRecompensa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRecompensa.TabIndex = 10;
            this.pictureRecompensa.TabStop = false;
            // 
            // timer12h
            // 
            this.timer12h.Interval = 12000;
            this.timer12h.Tick += new System.EventHandler(this.timer12h_Tick);
            // 
            // timer24h
            // 
            this.timer24h.Interval = 24000;
            this.timer24h.Tick += new System.EventHandler(this.timer24h_Tick);
            // 
            // timer8h
            // 
            this.timer8h.Interval = 8000;
            this.timer8h.Tick += new System.EventHandler(this.timer8h_Tick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(591, 417);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Montagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Montagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLife - Monte seu novo hábito :)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRotina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecompensa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeixa1;
        private System.Windows.Forms.TextBox txtRotina1;
        private System.Windows.Forms.TextBox txtRecompensa1;
        private System.Windows.Forms.PictureBox pictureDeixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureRotina;
        private System.Windows.Forms.PictureBox pictureRecompensa;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer12h;
        private System.Windows.Forms.Timer timer24h;
        private System.Windows.Forms.Timer timer8h;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Button btnLimpar;
    }
}