namespace Aula_3___conexao_com_banco_de_dados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.plPrincipal = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Controls.Add(this.btnFornecedor);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 426);
            this.panel1.TabIndex = 0;
            // 
            // plPrincipal
            // 
            this.plPrincipal.Location = new System.Drawing.Point(198, 13);
            this.plPrincipal.Name = "plPrincipal";
            this.plPrincipal.Size = new System.Drawing.Size(590, 425);
            this.plPrincipal.TabIndex = 1;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(1, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(178, 91);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(0, 111);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(178, 91);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(1, 220);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(178, 91);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel plPrincipal;
    }
}

