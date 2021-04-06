namespace Relogio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Opcões = new System.Windows.Forms.GroupBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnreninciar = new System.Windows.Forms.Button();
            this.Tempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.painelTopo = new System.Windows.Forms.Panel();
            this.painelRelogio = new System.Windows.Forms.Panel();
            this.painelRodape = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Opcões.SuspendLayout();
            this.painelTopo.SuspendLayout();
            this.painelRelogio.SuspendLayout();
            this.painelRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Opcões
            // 
            this.Opcões.Controls.Add(this.btniniciar);
            this.Opcões.Controls.Add(this.btnreninciar);
            this.Opcões.Controls.Add(this.Tempo);
            this.Opcões.Controls.Add(this.label1);
            this.Opcões.ForeColor = System.Drawing.Color.Snow;
            this.Opcões.Location = new System.Drawing.Point(44, 24);
            this.Opcões.Name = "Opcões";
            this.Opcões.Size = new System.Drawing.Size(292, 92);
            this.Opcões.TabIndex = 3;
            this.Opcões.TabStop = false;
            this.Opcões.Text = "Opções";
            this.Opcões.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btniniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.ForeColor = System.Drawing.Color.White;
            this.btniniciar.Location = new System.Drawing.Point(178, 22);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(91, 27);
            this.btniniciar.TabIndex = 6;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnreninciar
            // 
            this.btnreninciar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnreninciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreninciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreninciar.ForeColor = System.Drawing.Color.White;
            this.btnreninciar.Location = new System.Drawing.Point(178, 54);
            this.btnreninciar.Name = "btnreninciar";
            this.btnreninciar.Size = new System.Drawing.Size(91, 27);
            this.btnreninciar.TabIndex = 5;
            this.btnreninciar.Text = "Reiniciar";
            this.btnreninciar.UseVisualStyleBackColor = false;
            this.btnreninciar.Click += new System.EventHandler(this.Btnreninciar_Click);
            // 
            // Tempo
            // 
            this.Tempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tempo.Location = new System.Drawing.Point(116, 40);
            this.Tempo.MaxLength = 3;
            this.Tempo.Name = "Tempo";
            this.Tempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tempo.Size = new System.Drawing.Size(41, 20);
            this.Tempo.TabIndex = 4;
            this.Tempo.Text = "15";
            this.Tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tempo.UseWaitCursor = true;
            this.Tempo.TextChanged += new System.EventHandler(this.Tempo_TextChanged);
            this.Tempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tempo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo em minutos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // temporizador
            // 
            this.temporizador.AutoSize = true;
            this.temporizador.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporizador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temporizador.Location = new System.Drawing.Point(28, 14);
            this.temporizador.Name = "temporizador";
            this.temporizador.Size = new System.Drawing.Size(253, 68);
            this.temporizador.TabIndex = 4;
            this.temporizador.Text = "00:00:00";
            this.temporizador.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // painelTopo
            // 
            this.painelTopo.Controls.Add(this.pictureBox1);
            this.painelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopo.Location = new System.Drawing.Point(0, 0);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new System.Drawing.Size(803, 100);
            this.painelTopo.TabIndex = 5;
            // 
            // painelRelogio
            // 
            this.painelRelogio.Controls.Add(this.temporizador);
            this.painelRelogio.Location = new System.Drawing.Point(55, 137);
            this.painelRelogio.Name = "painelRelogio";
            this.painelRelogio.Size = new System.Drawing.Size(338, 100);
            this.painelRelogio.TabIndex = 6;
            this.painelRelogio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // painelRodape
            // 
            this.painelRodape.Controls.Add(this.Opcões);
            this.painelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelRodape.Location = new System.Drawing.Point(0, 626);
            this.painelRodape.Name = "painelRodape";
            this.painelRodape.Size = new System.Drawing.Size(803, 160);
            this.painelRodape.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(803, 786);
            this.Controls.Add(this.painelRodape);
            this.Controls.Add(this.painelRelogio);
            this.Controls.Add(this.painelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Relógio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Opcões.ResumeLayout(false);
            this.Opcões.PerformLayout();
            this.painelTopo.ResumeLayout(false);
            this.painelRelogio.ResumeLayout(false);
            this.painelRelogio.PerformLayout();
            this.painelRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Opcões;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreninciar;
        private System.Windows.Forms.Label temporizador;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.TextBox Tempo;
        private System.Windows.Forms.Panel painelTopo;
        private System.Windows.Forms.Panel painelRelogio;
        private System.Windows.Forms.Panel painelRodape;
    }
}

