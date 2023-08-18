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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Location = new System.Drawing.Point(17, 89);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(69, 16);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "Descrição";
            // 
            // txtValidade
            // 
            this.txtValidade.AutoSize = true;
            this.txtValidade.Location = new System.Drawing.Point(17, 247);
            this.txtValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(62, 16);
            this.txtValidade.TabIndex = 2;
            this.txtValidade.Text = "Validade";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(116, 31);
            this.txtBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(277, 22);
            this.txtBoxCodigo.TabIndex = 3;
            this.txtBoxCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(116, 89);
            this.txtBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(277, 116);
            this.txtBoxDescricao.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(24, 450);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(368, 450);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
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
            this.dgvDados.Location = new System.Drawing.Point(521, 15);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1018, 524);
            this.dgvDados.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(17, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(51, 16);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Código";
            this.txtCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(198, 493);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(100, 46);
            this.btnGrafico.TabIndex = 9;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Location = new System.Drawing.Point(17, 303);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(43, 16);
            this.txtPreco.TabIndex = 10;
            this.txtPreco.Text = "Preco";
            // 
            // boxValidade
            // 
            this.boxValidade.Location = new System.Drawing.Point(116, 247);
            this.boxValidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxValidade.Name = "boxValidade";
            this.boxValidade.Size = new System.Drawing.Size(277, 22);
            this.boxValidade.TabIndex = 11;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(116, 303);
            this.txtBoxPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(277, 22);
            this.txtBoxPreco.TabIndex = 12;
            // 
            // txtLucro
            // 
            this.txtLucro.AutoSize = true;
            this.txtLucro.Location = new System.Drawing.Point(20, 356);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(40, 16);
            this.txtLucro.TabIndex = 13;
            this.txtLucro.Text = "Lucro";
            // 
            // txtBoxLucro
            // 
            this.txtBoxLucro.Location = new System.Drawing.Point(116, 356);
            this.txtBoxLucro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLucro.Name = "txtBoxLucro";
            this.txtBoxLucro.Size = new System.Drawing.Size(277, 22);
            this.txtBoxLucro.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.Location = new System.Drawing.Point(21, 406);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(68, 16);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.Text = "Pesquisar";
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Location = new System.Drawing.Point(116, 406);
            this.txtBoxPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(277, 22);
            this.txtBoxPesquisa.TabIndex = 16;
            this.txtBoxPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxPesquisa_KeyUp);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(141, 450);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 28);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(252, 450);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 28);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 558);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

