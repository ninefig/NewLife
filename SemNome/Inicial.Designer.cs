namespace SemNome
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.lblTextoCentral = new System.Windows.Forms.Label();
            this.lblTopo = new System.Windows.Forms.Label();
            this.btnVamosLa = new System.Windows.Forms.Button();
            this.pictureBoxPlanb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoCentral
            // 
            this.lblTextoCentral.AutoSize = true;
            this.lblTextoCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCentral.Location = new System.Drawing.Point(9, 89);
            this.lblTextoCentral.Name = "lblTextoCentral";
            this.lblTextoCentral.Size = new System.Drawing.Size(696, 180);
            this.lblTextoCentral.TabIndex = 0;
            this.lblTextoCentral.Text = resources.GetString("lblTextoCentral.Text");
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.Location = new System.Drawing.Point(162, 22);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(219, 51);
            this.lblTopo.TabIndex = 1;
            this.lblTopo.Text = "Novos hábitos";
            // 
            // btnVamosLa
            // 
            this.btnVamosLa.BackColor = System.Drawing.Color.Green;
            this.btnVamosLa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVamosLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVamosLa.ForeColor = System.Drawing.Color.White;
            this.btnVamosLa.Location = new System.Drawing.Point(278, 335);
            this.btnVamosLa.Name = "btnVamosLa";
            this.btnVamosLa.Size = new System.Drawing.Size(132, 38);
            this.btnVamosLa.TabIndex = 2;
            this.btnVamosLa.Text = "Vamos lá! :)";
            this.btnVamosLa.UseVisualStyleBackColor = false;
            this.btnVamosLa.Click += new System.EventHandler(this.btnVamosLa_Click);
            // 
            // pictureBoxPlanb
            // 
            this.pictureBoxPlanb.Image = global::SemNome.Properties.Resources.novos_habitos;
            this.pictureBoxPlanb.Location = new System.Drawing.Point(479, 22);
            this.pictureBoxPlanb.Name = "pictureBoxPlanb";
            this.pictureBoxPlanb.Size = new System.Drawing.Size(226, 114);
            this.pictureBoxPlanb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlanb.TabIndex = 3;
            this.pictureBoxPlanb.TabStop = false;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 391);
            this.Controls.Add(this.pictureBoxPlanb);
            this.Controls.Add(this.btnVamosLa);
            this.Controls.Add(this.lblTopo);
            this.Controls.Add(this.lblTextoCentral);
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLife - Novos hábitos para uma vida melhor!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoCentral;
        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.Button btnVamosLa;
        private System.Windows.Forms.PictureBox pictureBoxPlanb;
    }
}

