namespace ListaDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAdd = new System.Windows.Forms.Button();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.txbInserir = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.libLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(52, 214);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(171, 33);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lblIndicador
            // 
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.Location = new System.Drawing.Point(49, 172);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(93, 13);
            this.lblIndicador.TabIndex = 1;
            this.lblIndicador.Text = "Nome do Produto:";
            // 
            // txbInserir
            // 
            this.txbInserir.Location = new System.Drawing.Point(52, 188);
            this.txbInserir.Name = "txbInserir";
            this.txbInserir.Size = new System.Drawing.Size(171, 20);
            this.txbInserir.TabIndex = 2;
            this.txbInserir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbInserir_KeyDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(265, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lista de Compras";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(314, 395);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(171, 33);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir Item";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(491, 395);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(171, 33);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar Lista";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(158, 9);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(101, 82);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 7;
            this.pbIcon.TabStop = false;
            // 
            // libLista
            // 
            this.libLista.FormattingEnabled = true;
            this.libLista.Location = new System.Drawing.Point(265, 74);
            this.libLista.Name = "libLista";
            this.libLista.Size = new System.Drawing.Size(407, 290);
            this.libLista.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.libLista);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbInserir);
            this.Controls.Add(this.lblIndicador);
            this.Controls.Add(this.btAdd);
            this.Name = "Form1";
            this.Text = "Lista de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblIndicador;
        private System.Windows.Forms.TextBox txbInserir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ListBox libLista;
    }
}

