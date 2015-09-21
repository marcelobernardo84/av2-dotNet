namespace controleDeEstoque
{
    partial class FormVendas
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listCarrinho = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new controleDeEstoque.northwindDataSet();
            this.productsTableAdapter = new controleDeEstoque.northwindDataSetTableAdapters.ProductsTableAdapter();
            this.buttonListEstoque = new System.Windows.Forms.Button();
            this.buttonAdCarrinho = new System.Windows.Forms.Button();
            this.buttonFimVenda = new System.Windows.Forms.Button();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new controleDeEstoque.northwindDataSet();
            this.gridEstoque = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produto:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(92, 13);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.Text = "00000";
            this.textBoxCodigo.Enter += new System.EventHandler(this.textBoxCodigo_Enter);
            this.textBoxCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyUp);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(433, 10);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.Text = "1";
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            this.textBoxQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantidade_KeyUp);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(9, 146);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(478, 20);
            this.textBoxDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição: ";
            // 
            // listCarrinho
            // 
            this.listCarrinho.FormattingEnabled = true;
            this.listCarrinho.Location = new System.Drawing.Point(9, 212);
            this.listCarrinho.Name = "listCarrinho";
            this.listCarrinho.Size = new System.Drawing.Size(475, 95);
            this.listCarrinho.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrinho:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "northwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonListEstoque
            // 
            this.buttonListEstoque.Location = new System.Drawing.Point(16, 51);
            this.buttonListEstoque.Name = "buttonListEstoque";
            this.buttonListEstoque.Size = new System.Drawing.Size(96, 38);
            this.buttonListEstoque.TabIndex = 9;
            this.buttonListEstoque.Text = "Lista Estoque";
            this.buttonListEstoque.UseVisualStyleBackColor = true;
            this.buttonListEstoque.Click += new System.EventHandler(this.buttonListEstoque_Click);
            // 
            // buttonAdCarrinho
            // 
            this.buttonAdCarrinho.Location = new System.Drawing.Point(193, 51);
            this.buttonAdCarrinho.Name = "buttonAdCarrinho";
            this.buttonAdCarrinho.Size = new System.Drawing.Size(96, 38);
            this.buttonAdCarrinho.TabIndex = 10;
            this.buttonAdCarrinho.Text = "Adicionar ao Carrinho";
            this.buttonAdCarrinho.UseVisualStyleBackColor = true;
            this.buttonAdCarrinho.Click += new System.EventHandler(this.buttonAdCarrinho_Click);
            // 
            // buttonFimVenda
            // 
            this.buttonFimVenda.Location = new System.Drawing.Point(365, 51);
            this.buttonFimVenda.Name = "buttonFimVenda";
            this.buttonFimVenda.Size = new System.Drawing.Size(96, 38);
            this.buttonFimVenda.TabIndex = 11;
            this.buttonFimVenda.Text = "Finaliza Venda";
            this.buttonFimVenda.UseVisualStyleBackColor = true;
            this.buttonFimVenda.Click += new System.EventHandler(this.buttonFimVenda_Click);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "northwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridEstoque
            // 
            this.gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstoque.Location = new System.Drawing.Point(9, 353);
            this.gridEstoque.Name = "gridEstoque";
            this.gridEstoque.Size = new System.Drawing.Size(676, 150);
            this.gridEstoque.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estoque: ";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(523, 51);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(88, 38);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(656, 10);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(53, 23);
            this.buttonLogout.TabIndex = 15;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 527);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridEstoque);
            this.Controls.Add(this.buttonFimVenda);
            this.Controls.Add(this.buttonAdCarrinho);
            this.Controls.Add(this.buttonListEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listCarrinho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listCarrinho;
        private System.Windows.Forms.Label label4;
        private northwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private northwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button buttonListEstoque;
        private System.Windows.Forms.Button buttonAdCarrinho;
        private System.Windows.Forms.Button buttonFimVenda;
        private northwindDataSet northwindDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.DataGridView gridEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button buttonLogout;
    }
}