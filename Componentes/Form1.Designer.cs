
namespace Componentes
{
    partial class frmFrutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrutas));
            this.cbbFrutasListadas = new System.Windows.Forms.ComboBox();
            this.ltbFrutas = new System.Windows.Forms.ListBox();
            this.gpbFrutas = new System.Windows.Forms.GroupBox();
            this.lblBanana = new System.Windows.Forms.Label();
            this.lblMaca = new System.Windows.Forms.Label();
            this.lblPera = new System.Windows.Forms.Label();
            this.lblMelancia = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.txtFrutaSelecionada = new System.Windows.Forms.TextBox();
            this.lblFrutaSelecionada = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFrutasListadas = new System.Windows.Forms.Label();
            this.lblFrutaCombo = new System.Windows.Forms.Label();
            this.txtSelecione = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gpbFrutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbFrutasListadas
            // 
            this.cbbFrutasListadas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFrutasListadas.FormattingEnabled = true;
            this.cbbFrutasListadas.Location = new System.Drawing.Point(481, 341);
            this.cbbFrutasListadas.Name = "cbbFrutasListadas";
            this.cbbFrutasListadas.Size = new System.Drawing.Size(121, 24);
            this.cbbFrutasListadas.TabIndex = 6;
            // 
            // ltbFrutas
            // 
            this.ltbFrutas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbFrutas.FormattingEnabled = true;
            this.ltbFrutas.ItemHeight = 16;
            this.ltbFrutas.Location = new System.Drawing.Point(478, 86);
            this.ltbFrutas.Name = "ltbFrutas";
            this.ltbFrutas.Size = new System.Drawing.Size(239, 148);
            this.ltbFrutas.TabIndex = 7;
            // 
            // gpbFrutas
            // 
            this.gpbFrutas.Controls.Add(this.lblSair);
            this.gpbFrutas.Controls.Add(this.lblMelancia);
            this.gpbFrutas.Controls.Add(this.lblPera);
            this.gpbFrutas.Controls.Add(this.lblMaca);
            this.gpbFrutas.Controls.Add(this.lblBanana);
            this.gpbFrutas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFrutas.Location = new System.Drawing.Point(84, 86);
            this.gpbFrutas.Name = "gpbFrutas";
            this.gpbFrutas.Size = new System.Drawing.Size(254, 220);
            this.gpbFrutas.TabIndex = 2;
            this.gpbFrutas.TabStop = false;
            this.gpbFrutas.Text = "Frutas";
            // 
            // lblBanana
            // 
            this.lblBanana.AutoSize = true;
            this.lblBanana.Location = new System.Drawing.Point(38, 43);
            this.lblBanana.Name = "lblBanana";
            this.lblBanana.Size = new System.Drawing.Size(61, 16);
            this.lblBanana.TabIndex = 0;
            this.lblBanana.Text = "1 - Banana";
            // 
            // lblMaca
            // 
            this.lblMaca.AutoSize = true;
            this.lblMaca.Location = new System.Drawing.Point(38, 69);
            this.lblMaca.Name = "lblMaca";
            this.lblMaca.Size = new System.Drawing.Size(50, 16);
            this.lblMaca.TabIndex = 1;
            this.lblMaca.Text = "2 - Maçã";
            // 
            // lblPera
            // 
            this.lblPera.AutoSize = true;
            this.lblPera.Location = new System.Drawing.Point(38, 95);
            this.lblPera.Name = "lblPera";
            this.lblPera.Size = new System.Drawing.Size(47, 16);
            this.lblPera.TabIndex = 2;
            this.lblPera.Text = "3 - Pêra";
            // 
            // lblMelancia
            // 
            this.lblMelancia.AutoSize = true;
            this.lblMelancia.Location = new System.Drawing.Point(38, 121);
            this.lblMelancia.Name = "lblMelancia";
            this.lblMelancia.Size = new System.Drawing.Size(66, 16);
            this.lblMelancia.TabIndex = 3;
            this.lblMelancia.Text = "4 - Melância";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(38, 146);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(43, 16);
            this.lblSair.TabIndex = 4;
            this.lblSair.Text = "5 - Sair";
            // 
            // txtFrutaSelecionada
            // 
            this.txtFrutaSelecionada.Enabled = false;
            this.txtFrutaSelecionada.Location = new System.Drawing.Point(84, 345);
            this.txtFrutaSelecionada.MaxLength = 50;
            this.txtFrutaSelecionada.Name = "txtFrutaSelecionada";
            this.txtFrutaSelecionada.Size = new System.Drawing.Size(254, 20);
            this.txtFrutaSelecionada.TabIndex = 1;
            // 
            // lblFrutaSelecionada
            // 
            this.lblFrutaSelecionada.AutoSize = true;
            this.lblFrutaSelecionada.Location = new System.Drawing.Point(81, 324);
            this.lblFrutaSelecionada.Name = "lblFrutaSelecionada";
            this.lblFrutaSelecionada.Size = new System.Drawing.Size(94, 13);
            this.lblFrutaSelecionada.TabIndex = 4;
            this.lblFrutaSelecionada.Text = "Fruta selecionada:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(81, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Digite o número para selecionar a fruta:";
            // 
            // lblFrutasListadas
            // 
            this.lblFrutasListadas.AutoSize = true;
            this.lblFrutasListadas.Location = new System.Drawing.Point(478, 67);
            this.lblFrutasListadas.Name = "lblFrutasListadas";
            this.lblFrutasListadas.Size = new System.Drawing.Size(77, 13);
            this.lblFrutasListadas.TabIndex = 6;
            this.lblFrutasListadas.Text = "Frutas listadas:";
            // 
            // lblFrutaCombo
            // 
            this.lblFrutaCombo.AutoSize = true;
            this.lblFrutaCombo.Location = new System.Drawing.Point(478, 324);
            this.lblFrutaCombo.Name = "lblFrutaCombo";
            this.lblFrutaCombo.Size = new System.Drawing.Size(77, 13);
            this.lblFrutaCombo.TabIndex = 7;
            this.lblFrutaCombo.Text = "Frutas listadas:";
            // 
            // txtSelecione
            // 
            this.txtSelecione.Location = new System.Drawing.Point(84, 50);
            this.txtSelecione.MaxLength = 50;
            this.txtSelecione.Name = "txtSelecione";
            this.txtSelecione.Size = new System.Drawing.Size(189, 20);
            this.txtSelecione.TabIndex = 0;
            this.txtSelecione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelecione_KeyDown);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(207, 411);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(76, 33);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(388, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 33);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(482, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 33);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(295, 411);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(76, 33);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtSelecione);
            this.Controls.Add(this.lblFrutaCombo);
            this.Controls.Add(this.lblFrutasListadas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFrutaSelecionada);
            this.Controls.Add(this.txtFrutaSelecionada);
            this.Controls.Add(this.gpbFrutas);
            this.Controls.Add(this.ltbFrutas);
            this.Controls.Add(this.cbbFrutasListadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmFrutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frutas";
            this.gpbFrutas.ResumeLayout(false);
            this.gpbFrutas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFrutasListadas;
        private System.Windows.Forms.ListBox ltbFrutas;
        private System.Windows.Forms.GroupBox gpbFrutas;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblMelancia;
        private System.Windows.Forms.Label lblPera;
        private System.Windows.Forms.Label lblMaca;
        private System.Windows.Forms.Label lblBanana;
        private System.Windows.Forms.TextBox txtFrutaSelecionada;
        private System.Windows.Forms.Label lblFrutaSelecionada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFrutasListadas;
        private System.Windows.Forms.Label lblFrutaCombo;
        private System.Windows.Forms.TextBox txtSelecione;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInserir;
    }
}

