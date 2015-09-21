namespace controleDeEstoque
{
    partial class FormMenu
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
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonOperador = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(28, 39);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(75, 23);
            this.buttonVender.TabIndex = 0;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // buttonOperador
            // 
            this.buttonOperador.Location = new System.Drawing.Point(31, 100);
            this.buttonOperador.Name = "buttonOperador";
            this.buttonOperador.Size = new System.Drawing.Size(75, 23);
            this.buttonOperador.TabIndex = 1;
            this.buttonOperador.Text = "Operador";
            this.buttonOperador.UseVisualStyleBackColor = true;
            this.buttonOperador.Click += new System.EventHandler(this.buttonOperador_Click);
            // 
            // buttonProduto
            // 
            this.buttonProduto.Location = new System.Drawing.Point(35, 162);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonProduto.TabIndex = 2;
            this.buttonProduto.Text = "Produto";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonOperador);
            this.Controls.Add(this.buttonVender);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Button buttonOperador;
        private System.Windows.Forms.Button buttonProduto;

    }
}