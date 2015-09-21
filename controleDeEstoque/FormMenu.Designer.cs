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
            this.vendaMenu = new System.Windows.Forms.Button();
            this.opMenu = new System.Windows.Forms.Button();
            this.prodMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendaMenu
            // 
            this.vendaMenu.Location = new System.Drawing.Point(13, 35);
            this.vendaMenu.Name = "vendaMenu";
            this.vendaMenu.Size = new System.Drawing.Size(75, 23);
            this.vendaMenu.TabIndex = 0;
            this.vendaMenu.Text = "Vender";
            this.vendaMenu.UseVisualStyleBackColor = true;
            this.vendaMenu.Click += new System.EventHandler(this.opMenu_Click);
            // 
            // opMenu
            // 
            this.opMenu.Location = new System.Drawing.Point(13, 89);
            this.opMenu.Name = "opMenu";
            this.opMenu.Size = new System.Drawing.Size(75, 23);
            this.opMenu.TabIndex = 1;
            this.opMenu.Text = "Operador";
            this.opMenu.UseVisualStyleBackColor = true;
            this.opMenu.Click += new System.EventHandler(this.vendaMenu_Click);
            // 
            // prodMenu
            // 
            this.prodMenu.Location = new System.Drawing.Point(13, 138);
            this.prodMenu.Name = "prodMenu";
            this.prodMenu.Size = new System.Drawing.Size(75, 23);
            this.prodMenu.TabIndex = 2;
            this.prodMenu.Text = "Produto";
            this.prodMenu.UseVisualStyleBackColor = true;
            this.prodMenu.Click += new System.EventHandler(this.prodMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.prodMenu);
            this.Controls.Add(this.opMenu);
            this.Controls.Add(this.vendaMenu);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vendaMenu;
        private System.Windows.Forms.Button opMenu;
        private System.Windows.Forms.Button prodMenu;
    }
}