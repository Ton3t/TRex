namespace rexFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.suelo = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.obs1 = new System.Windows.Forms.PictureBox();
            this.obs2 = new System.Windows.Forms.PictureBox();
            this.lblpuntos = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.suelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).BeginInit();
            this.SuspendLayout();
            // 
            // suelo
            // 
            this.suelo.BackColor = System.Drawing.Color.Black;
            this.suelo.Location = new System.Drawing.Point(-4, 421);
            this.suelo.Name = "suelo";
            this.suelo.Size = new System.Drawing.Size(810, 50);
            this.suelo.TabIndex = 0;
            this.suelo.TabStop = false;
            // 
            // trex
            // 
            this.trex.Image = global::rexFinal.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(81, 367);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // obs1
            // 
            this.obs1.Image = global::rexFinal.Properties.Resources.obstacle_1;
            this.obs1.Location = new System.Drawing.Point(436, 361);
            this.obs1.Name = "obs1";
            this.obs1.Size = new System.Drawing.Size(23, 46);
            this.obs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obs1.TabIndex = 2;
            this.obs1.TabStop = false;
            this.obs1.Tag = "obstacle";
            // 
            // obs2
            // 
            this.obs2.Image = global::rexFinal.Properties.Resources.obstacle_2;
            this.obs2.Location = new System.Drawing.Point(665, 375);
            this.obs2.Name = "obs2";
            this.obs2.Size = new System.Drawing.Size(32, 33);
            this.obs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obs2.TabIndex = 3;
            this.obs2.TabStop = false;
            this.obs2.Tag = "obstacle";
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.Location = new System.Drawing.Point(12, 9);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(150, 33);
            this.lblpuntos.TabIndex = 4;
            this.lblpuntos.Text = "Puntos: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 539);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.lblpuntos);
            this.Controls.Add(this.obs2);
            this.Controls.Add(this.suelo);
            this.Controls.Add(this.obs1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex El juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventoCerrar);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.suelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox suelo;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obs1;
        private System.Windows.Forms.PictureBox obs2;
        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.Timer gameTimer;
    }
}

