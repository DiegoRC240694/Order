﻿
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
            this.Txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.Lbl_NumeroCliente = new System.Windows.Forms.Label();
            this.Lbl_NumeroProduto = new System.Windows.Forms.Label();
            this.Txt_NumeroProduto = new System.Windows.Forms.TextBox();
            this.Lbl_RegistroDePedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(254, 329);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 0;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(414, 329);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 1;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Txt_NumeroCliente
            // 
            this.Txt_NumeroCliente.Location = new System.Drawing.Point(331, 135);
            this.Txt_NumeroCliente.Name = "Txt_NumeroCliente";
            this.Txt_NumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_NumeroCliente.TabIndex = 2;
            // 
            // Lbl_NumeroCliente
            // 
            this.Lbl_NumeroCliente.AutoSize = true;
            this.Lbl_NumeroCliente.Location = new System.Drawing.Point(328, 101);
            this.Lbl_NumeroCliente.Name = "Lbl_NumeroCliente";
            this.Lbl_NumeroCliente.Size = new System.Drawing.Size(94, 13);
            this.Lbl_NumeroCliente.TabIndex = 3;
            this.Lbl_NumeroCliente.Text = "Numero de Cliente";
            // 
            // Lbl_NumeroProduto
            // 
            this.Lbl_NumeroProduto.AutoSize = true;
            this.Lbl_NumeroProduto.Location = new System.Drawing.Point(328, 188);
            this.Lbl_NumeroProduto.Name = "Lbl_NumeroProduto";
            this.Lbl_NumeroProduto.Size = new System.Drawing.Size(99, 13);
            this.Lbl_NumeroProduto.TabIndex = 5;
            this.Lbl_NumeroProduto.Text = "Numero de Produto";
            // 
            // Txt_NumeroProduto
            // 
            this.Txt_NumeroProduto.Location = new System.Drawing.Point(327, 220);
            this.Txt_NumeroProduto.Name = "Txt_NumeroProduto";
            this.Txt_NumeroProduto.Size = new System.Drawing.Size(100, 20);
            this.Txt_NumeroProduto.TabIndex = 4;
            // 
            // Lbl_RegistroDePedido
            // 
            this.Lbl_RegistroDePedido.AutoSize = true;
            this.Lbl_RegistroDePedido.Location = new System.Drawing.Point(328, 32);
            this.Lbl_RegistroDePedido.Name = "Lbl_RegistroDePedido";
            this.Lbl_RegistroDePedido.Size = new System.Drawing.Size(99, 13);
            this.Lbl_RegistroDePedido.TabIndex = 6;
            this.Lbl_RegistroDePedido.Text = "Registro De Pedido";
            // 
            // Frm_RegistroDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_RegistroDePedido);
            this.Controls.Add(this.Lbl_NumeroProduto);
            this.Controls.Add(this.Txt_NumeroProduto);
            this.Controls.Add(this.Lbl_NumeroCliente);
            this.Controls.Add(this.Txt_NumeroCliente);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Salvar);
            this.Name = "Frm_RegistroDePedido";
            this.Text = "Registro De Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_NumeroCliente;
        private System.Windows.Forms.Label Lbl_NumeroCliente;
        private System.Windows.Forms.Label Lbl_NumeroProduto;
        private System.Windows.Forms.TextBox Txt_NumeroProduto;
        private System.Windows.Forms.Label Lbl_RegistroDePedido;
    }
}