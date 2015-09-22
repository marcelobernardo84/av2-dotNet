namespace controleDeEstoque
{
    partial class FormCadastroProduto
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
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCod = new System.Windows.Forms.TextBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textIdFor = new System.Windows.Forms.TextBox();
            this.textValorUni = new System.Windows.Forms.TextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(287, 9);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(60, 23);
            this.buttonPesquisar.TabIndex = 0;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // textCod
            // 
            this.textCod.BackColor = System.Drawing.SystemColors.Control;
            this.textCod.Location = new System.Drawing.Point(63, 13);
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(100, 20);
            this.textCod.TabIndex = 2;
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(181, 12);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(100, 20);
            this.textPesquisa.TabIndex = 3;
            this.textPesquisa.Text = "Nome do Produto";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(16, 74);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(294, 20);
            this.textName.TabIndex = 4;
            // 
            // textIdFor
            // 
            this.textIdFor.Location = new System.Drawing.Point(16, 119);
            this.textIdFor.Name = "textIdFor";
            this.textIdFor.Size = new System.Drawing.Size(100, 20);
            this.textIdFor.TabIndex = 5;
            // 
            // textValorUni
            // 
            this.textValorUni.Location = new System.Drawing.Point(16, 173);
            this.textValorUni.Name = "textValorUni";
            this.textValorUni.Size = new System.Drawing.Size(100, 20);
            this.textValorUni.TabIndex = 6;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(154, 173);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID do Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade em estoque";
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(19, 219);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 31);
            this.buttonNovo.TabIndex = 12;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(100, 219);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 31);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(181, 219);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 31);
            this.buttonAlterar.TabIndex = 14;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(262, 219);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 31);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textValorUni);
            this.Controls.Add(this.textIdFor);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.textCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPesquisar);
            this.Name = "FormCadastroProduto";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textIdFor;
        private System.Windows.Forms.TextBox textValorUni;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}