namespace Cliente
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
            this.txtDescricao = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.Label();
            this.boxValidade = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.Label();
            this.txtBoxLucro = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.Label();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Location = new System.Drawing.Point(13, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(55, 13);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "Descrição";
            // 
            // txtValidade
            // 
            this.txtValidade.AutoSize = true;
            this.txtValidade.Location = new System.Drawing.Point(13, 201);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(48, 13);
            this.txtValidade.TabIndex = 2;
            this.txtValidade.Text = "Validade";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(87, 25);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtBoxCodigo.TabIndex = 3;
            this.txtBoxCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(87, 72);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(209, 95);
            this.txtBoxDescricao.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(18, 366);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(245, 366);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(348, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(806, 426);
            this.dgvDados.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(13, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 13);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Código";
            this.txtCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(137, 401);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 37);
            this.btnGrafico.TabIndex = 9;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Location = new System.Drawing.Point(13, 246);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(35, 13);
            this.txtPreco.TabIndex = 10;
            this.txtPreco.Text = "Preco";
            // 
            // boxValidade
            // 
            this.boxValidade.Location = new System.Drawing.Point(87, 201);
            this.boxValidade.Margin = new System.Windows.Forms.Padding(2);
            this.boxValidade.Name = "boxValidade";
            this.boxValidade.Size = new System.Drawing.Size(209, 20);
            this.boxValidade.TabIndex = 11;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(87, 246);
            this.txtBoxPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(151, 20);
            this.txtBoxPreco.TabIndex = 12;
            // 
            // txtLucro
            // 
            this.txtLucro.AutoSize = true;
            this.txtLucro.Location = new System.Drawing.Point(15, 289);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(34, 13);
            this.txtLucro.TabIndex = 13;
            this.txtLucro.Text = "Lucro";
            // 
            // txtBoxLucro
            // 
            this.txtBoxLucro.Location = new System.Drawing.Point(87, 289);
            this.txtBoxLucro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLucro.Name = "txtBoxLucro";
            this.txtBoxLucro.Size = new System.Drawing.Size(151, 20);
            this.txtBoxLucro.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.Location = new System.Drawing.Point(16, 330);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(53, 13);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.Text = "Pesquisar";
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Location = new System.Drawing.Point(87, 330);
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(209, 20);
            this.txtBoxPesquisa.TabIndex = 16;
            this.txtBoxPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxPesquisa_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 453);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtBoxLucro);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.boxValidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.Label txtValidade;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.DateTimePicker boxValidade;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.Label txtLucro;
        private System.Windows.Forms.TextBox txtBoxLucro;
        private System.Windows.Forms.Label txtPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
    }
}

