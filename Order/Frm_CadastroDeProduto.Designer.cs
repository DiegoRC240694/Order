
namespace Order
{
    partial class Frm_CadastroDeProduto
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
            this.Lbl_DescricaoDoProduto = new System.Windows.Forms.Label();
            this.Txt_DescricaoDoProduto = new System.Windows.Forms.TextBox();
            this.Txt_QuantidadeDisponivel = new System.Windows.Forms.TextBox();
            this.Lbl_QuantidadeDisponivel = new System.Windows.Forms.Label();
            this.Txt_ValorUnitarioDoProduto = new System.Windows.Forms.TextBox();
            this.Lbl_ValorUnitarioDoProduto = new System.Windows.Forms.Label();
            this.Lbl_CadastroDeProduto = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_DescricaoDoProduto
            // 
            this.Lbl_DescricaoDoProduto.AutoSize = true;
            this.Lbl_DescricaoDoProduto.Location = new System.Drawing.Point(321, 104);
            this.Lbl_DescricaoDoProduto.Name = "Lbl_DescricaoDoProduto";
            this.Lbl_DescricaoDoProduto.Size = new System.Drawing.Size(110, 13);
            this.Lbl_DescricaoDoProduto.TabIndex = 0;
            this.Lbl_DescricaoDoProduto.Text = "Descrição do Produto";
            // 
            // Txt_DescricaoDoProduto
            // 
            this.Txt_DescricaoDoProduto.Location = new System.Drawing.Point(324, 121);
            this.Txt_DescricaoDoProduto.Name = "Txt_DescricaoDoProduto";
            this.Txt_DescricaoDoProduto.Size = new System.Drawing.Size(113, 20);
            this.Txt_DescricaoDoProduto.TabIndex = 1;
            // 
            // Txt_QuantidadeDisponivel
            // 
            this.Txt_QuantidadeDisponivel.Location = new System.Drawing.Point(324, 181);
            this.Txt_QuantidadeDisponivel.Name = "Txt_QuantidadeDisponivel";
            this.Txt_QuantidadeDisponivel.Size = new System.Drawing.Size(113, 20);
            this.Txt_QuantidadeDisponivel.TabIndex = 3;
            // 
            // Lbl_QuantidadeDisponivel
            // 
            this.Lbl_QuantidadeDisponivel.AutoSize = true;
            this.Lbl_QuantidadeDisponivel.Location = new System.Drawing.Point(321, 164);
            this.Lbl_QuantidadeDisponivel.Name = "Lbl_QuantidadeDisponivel";
            this.Lbl_QuantidadeDisponivel.Size = new System.Drawing.Size(116, 13);
            this.Lbl_QuantidadeDisponivel.TabIndex = 2;
            this.Lbl_QuantidadeDisponivel.Text = "Quantidade Disponível";
            // 
            // Txt_ValorUnitarioDoProduto
            // 
            this.Txt_ValorUnitarioDoProduto.Location = new System.Drawing.Point(324, 241);
            this.Txt_ValorUnitarioDoProduto.Name = "Txt_ValorUnitarioDoProduto";
            this.Txt_ValorUnitarioDoProduto.Size = new System.Drawing.Size(113, 20);
            this.Txt_ValorUnitarioDoProduto.TabIndex = 5;
            // 
            // Lbl_ValorUnitarioDoProduto
            // 
            this.Lbl_ValorUnitarioDoProduto.AutoSize = true;
            this.Lbl_ValorUnitarioDoProduto.Location = new System.Drawing.Point(321, 224);
            this.Lbl_ValorUnitarioDoProduto.Name = "Lbl_ValorUnitarioDoProduto";
            this.Lbl_ValorUnitarioDoProduto.Size = new System.Drawing.Size(125, 13);
            this.Lbl_ValorUnitarioDoProduto.TabIndex = 4;
            this.Lbl_ValorUnitarioDoProduto.Text = "Valor Unitário do Produto";
            // 
            // Lbl_CadastroDeProduto
            // 
            this.Lbl_CadastroDeProduto.AutoSize = true;
            this.Lbl_CadastroDeProduto.Location = new System.Drawing.Point(321, 27);
            this.Lbl_CadastroDeProduto.Name = "Lbl_CadastroDeProduto";
            this.Lbl_CadastroDeProduto.Size = new System.Drawing.Size(106, 13);
            this.Lbl_CadastroDeProduto.TabIndex = 6;
            this.Lbl_CadastroDeProduto.Text = "Cadastro De Produto";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(259, 316);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(395, 316);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.Lbl_CadastroDeProduto);
            this.Controls.Add(this.Txt_ValorUnitarioDoProduto);
            this.Controls.Add(this.Lbl_ValorUnitarioDoProduto);
            this.Controls.Add(this.Txt_QuantidadeDisponivel);
            this.Controls.Add(this.Lbl_QuantidadeDisponivel);
            this.Controls.Add(this.Txt_DescricaoDoProduto);
            this.Controls.Add(this.Lbl_DescricaoDoProduto);
            this.Name = "Frm_CadastroDeProduto";
            this.Text = "Frm_CadastroDeProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DescricaoDoProduto;
        private System.Windows.Forms.TextBox Txt_DescricaoDoProduto;
        private System.Windows.Forms.TextBox Txt_QuantidadeDisponivel;
        private System.Windows.Forms.Label Lbl_QuantidadeDisponivel;
        private System.Windows.Forms.TextBox Txt_ValorUnitarioDoProduto;
        private System.Windows.Forms.Label Lbl_ValorUnitarioDoProduto;
        private System.Windows.Forms.Label Lbl_CadastroDeProduto;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}