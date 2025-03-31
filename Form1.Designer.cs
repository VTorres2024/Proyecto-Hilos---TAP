namespace ProyectoTAP___Carreritas_de_F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Pausa = new System.Windows.Forms.Button();
            this.btn_Reanudar = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Pausa
            // 
            this.btn_Pausa.Location = new System.Drawing.Point(398, 659);
            this.btn_Pausa.Name = "btn_Pausa";
            this.btn_Pausa.Size = new System.Drawing.Size(177, 69);
            this.btn_Pausa.TabIndex = 4;
            this.btn_Pausa.Text = "Pausar Carrera";
            this.btn_Pausa.UseVisualStyleBackColor = true;
            this.btn_Pausa.Click += new System.EventHandler(this.btn_Pausa_Click);
            // 
            // btn_Reanudar
            // 
            this.btn_Reanudar.Location = new System.Drawing.Point(581, 659);
            this.btn_Reanudar.Name = "btn_Reanudar";
            this.btn_Reanudar.Size = new System.Drawing.Size(177, 69);
            this.btn_Reanudar.TabIndex = 5;
            this.btn_Reanudar.Text = "Reanudar Carrera";
            this.btn_Reanudar.UseVisualStyleBackColor = true;
            this.btn_Reanudar.Click += new System.EventHandler(this.btn_Reanudar_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(764, 659);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(177, 69);
            this.btn_Restart.TabIndex = 6;
            this.btn_Restart.Text = "Reiniciar Carrera";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ptb4
            // 
            this.ptb4.BackColor = System.Drawing.Color.Transparent;
            this.ptb4.Image = global::ProyectoTAP___Carreritas_de_F1.Properties.Resources.morado;
            this.ptb4.Location = new System.Drawing.Point(3, 203);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(90, 57);
            this.ptb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb4.TabIndex = 9;
            this.ptb4.TabStop = false;
            // 
            // ptb3
            // 
            this.ptb3.BackColor = System.Drawing.Color.Transparent;
            this.ptb3.Image = global::ProyectoTAP___Carreritas_de_F1.Properties.Resources.verde;
            this.ptb3.Location = new System.Drawing.Point(3, 49);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(90, 57);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb3.TabIndex = 8;
            this.ptb3.TabStop = false;
            // 
            // ptb2
            // 
            this.ptb2.BackColor = System.Drawing.Color.Transparent;
            this.ptb2.Image = ((System.Drawing.Image)(resources.GetObject("ptb2.Image")));
            this.ptb2.Location = new System.Drawing.Point(3, 206);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(90, 57);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 2;
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.BackColor = System.Drawing.Color.Transparent;
            this.ptb1.Image = global::ProyectoTAP___Carreritas_de_F1.Properties.Resources.azul;
            this.ptb1.Location = new System.Drawing.Point(3, 52);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(90, 57);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 1;
            this.ptb1.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoTAP___Carreritas_de_F1.Properties.Resources.pista;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ptb1);
            this.panel1.Controls.Add(this.ptb2);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 302);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProyectoTAP___Carreritas_de_F1.Properties.Resources.pista;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.ptb3);
            this.panel3.Controls.Add(this.ptb4);
            this.panel3.Location = new System.Drawing.Point(14, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 302);
            this.panel3.TabIndex = 12;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(215, 659);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(177, 69);
            this.btn_Iniciar.TabIndex = 3;
            this.btn_Iniciar.Text = "Iniciar Carrera";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1165, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Reanudar);
            this.Controls.Add(this.btn_Pausa);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form1";
            this.Text = "Proyecto Hilos - Topicos Avanzados de Programacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.Button btn_Pausa;
        private System.Windows.Forms.Button btn_Reanudar;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Iniciar;
    }
}

