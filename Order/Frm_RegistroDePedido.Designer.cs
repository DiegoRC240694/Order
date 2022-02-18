
namespace Order
{
    partial class Frm_RegistroDePedido
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
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.Lbl_RegistroDePedido = new System.Windows.Forms.Label();
            this.Dg_Clientes = new System.Windows.Forms.DataGridView();
            this.Dg_Produtos = new System.Windows.Forms.DataGridView();
            this.Txt_Quantidade = new System.Windows.Forms.TextBox();
            this.Txt_ValorTotal = new System.Windows.Forms.TextBox();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.Lbl_ValorTotal = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Dg_Pedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(486, 62);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 0;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(579, 62);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 1;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(12, 64);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeCliente.ForeColor = System.Drawing.Color.White;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(9, 45);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(88, 16);
            this.Lbl_NomeCliente.TabIndex = 3;
            this.Lbl_NomeCliente.Text = "Nome Cliente";
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.AutoSize = true;
            this.Lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descricao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Descricao.Location = new System.Drawing.Point(128, 45);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(54, 16);
            this.Lbl_Descricao.TabIndex = 5;
            this.Lbl_Descricao.Text = "Produto";
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Location = new System.Drawing.Point(131, 64);
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(100, 20);
            this.Txt_Descricao.TabIndex = 4;
            // 
            // Lbl_RegistroDePedido
            // 
            this.Lbl_RegistroDePedido.AutoSize = true;
            this.Lbl_RegistroDePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl_RegistroDePedido.ForeColor = System.Drawing.Color.White;
            this.Lbl_RegistroDePedido.Location = new System.Drawing.Point(293, 9);
            this.Lbl_RegistroDePedido.Name = "Lbl_RegistroDePedido";
            this.Lbl_RegistroDePedido.Size = new System.Drawing.Size(201, 26);
            this.Lbl_RegistroDePedido.TabIndex = 6;
            this.Lbl_RegistroDePedido.Text = "Registro De Pedido";
            // 
            // Dg_Clientes
            // 
            this.Dg_Clientes.AllowUserToAddRows = false;
            this.Dg_Clientes.AllowUserToDeleteRows = false;
            this.Dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clientes.Location = new System.Drawing.Point(396, 232);
            this.Dg_Clientes.Name = "Dg_Clientes";
            this.Dg_Clientes.ReadOnly = true;
            this.Dg_Clientes.Size = new System.Drawing.Size(397, 206);
            this.Dg_Clientes.TabIndex = 7;
            this.Dg_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Clientes_CellClick);
            // 
            // Dg_Produtos
            // 
            this.Dg_Produtos.AllowUserToAddRows = false;
            this.Dg_Produtos.AllowUserToDeleteRows = false;
            this.Dg_Produtos.AllowUserToOrderColumns = true;
            this.Dg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Produtos.Location = new System.Drawing.Point(12, 232);
            this.Dg_Produtos.Name = "Dg_Produtos";
            this.Dg_Produtos.ReadOnly = true;
            this.Dg_Produtos.Size = new System.Drawing.Size(378, 206);
            this.Dg_Produtos.TabIndex = 8;
            this.Dg_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Produtos_CellClick);
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Location = new System.Drawing.Point(248, 64);
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Quantidade.TabIndex = 9;
            // 
            // Txt_ValorTotal
            // 
            this.Txt_ValorTotal.Location = new System.Drawing.Point(367, 64);
            this.Txt_ValorTotal.Name = "Txt_ValorTotal";
            this.Txt_ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.Txt_ValorTotal.TabIndex = 10;
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.AutoSize = true;
            this.Lbl_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Quantidade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Quantidade.Location = new System.Drawing.Point(245, 45);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(77, 16);
            this.Lbl_Quantidade.TabIndex = 11;
            this.Lbl_Quantidade.Text = "Quantidade";
            // 
            // Lbl_ValorTotal
            // 
            this.Lbl_ValorTotal.AutoSize = true;
            this.Lbl_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValorTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_ValorTotal.Location = new System.Drawing.Point(364, 45);
            this.Lbl_ValorTotal.Name = "Lbl_ValorTotal";
            this.Lbl_ValorTotal.Size = new System.Drawing.Size(73, 16);
            this.Lbl_ValorTotal.TabIndex = 12;
            this.Lbl_ValorTotal.Text = "Valor Total";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(676, 61);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 13;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Dg_Pedido
            // 
            this.Dg_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Pedido.Location = new System.Drawing.Point(8, 91);
            this.Dg_Pedido.Name = "Dg_Pedido";
            this.Dg_Pedido.Size = new System.Drawing.Size(785, 133);
            this.Dg_Pedido.TabIndex = 14;
            this.Dg_Pedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Pedido_CellClick);
            // 
            // Frm_RegistroDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dg_Pedido);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Lbl_ValorTotal);
            this.Controls.Add(this.Lbl_Quantidade);
            this.Controls.Add(this.Txt_ValorTotal);
            this.Controls.Add(this.Txt_Quantidade);
            this.Controls.Add(this.Dg_Produtos);
            this.Controls.Add(this.Dg_Clientes);
            this.Controls.Add(this.Lbl_RegistroDePedido);
            this.Controls.Add(this.Lbl_Descricao);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RegistroDePedido";
            this.Text = "Registro De Pedido";
            this.Load += new System.EventHandler(this.Frm_RegistroDePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_Descricao;
        private System.Windows.Forms.TextBox Txt_Descricao;
        private System.Windows.Forms.Label Lbl_RegistroDePedido;
        private System.Windows.Forms.DataGridView Dg_Clientes;
        private System.Windows.Forms.DataGridView Dg_Produtos;
        private System.Windows.Forms.TextBox Txt_Quantidade;
        private System.Windows.Forms.TextBox Txt_ValorTotal;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private System.Windows.Forms.Label Lbl_ValorTotal;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.DataGridView Dg_Pedido;
    }
}