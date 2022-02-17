
namespace Order
{
    partial class Frm_CadastroDeClientes
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
            this.Lbl_CadastroDeClientes = new System.Windows.Forms.Label();
            this.Lbl_NomeDoCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_SobrenomeDoCliente = new System.Windows.Forms.Label();
            this.Txt_SobrenomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Mask_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_DataDeNascimento = new System.Windows.Forms.Label();
            this.Date_DataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.Btn_SalvarNovoCliente = new System.Windows.Forms.Button();
            this.Btn_ApagarCliente = new System.Windows.Forms.Button();
            this.Btn_LimparTela = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_BuscaCPF = new System.Windows.Forms.Button();
            this.Dg_Clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CadastroDeClientes
            // 
            this.Lbl_CadastroDeClientes.AutoSize = true;
            this.Lbl_CadastroDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroDeClientes.ForeColor = System.Drawing.Color.White;
            this.Lbl_CadastroDeClientes.Location = new System.Drawing.Point(345, 18);
            this.Lbl_CadastroDeClientes.Name = "Lbl_CadastroDeClientes";
            this.Lbl_CadastroDeClientes.Size = new System.Drawing.Size(215, 26);
            this.Lbl_CadastroDeClientes.TabIndex = 1;
            this.Lbl_CadastroDeClientes.Text = "Cadastro de Clientes";
            // 
            // Lbl_NomeDoCliente
            // 
            this.Lbl_NomeDoCliente.AutoSize = true;
            this.Lbl_NomeDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeDoCliente.ForeColor = System.Drawing.Color.White;
            this.Lbl_NomeDoCliente.Location = new System.Drawing.Point(18, 65);
            this.Lbl_NomeDoCliente.Name = "Lbl_NomeDoCliente";
            this.Lbl_NomeDoCliente.Size = new System.Drawing.Size(56, 16);
            this.Lbl_NomeDoCliente.TabIndex = 2;
            this.Lbl_NomeDoCliente.Text = "Nome :";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(89, 65);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(148, 20);
            this.Txt_NomeCliente.TabIndex = 3;
            // 
            // Lbl_SobrenomeDoCliente
            // 
            this.Lbl_SobrenomeDoCliente.AutoSize = true;
            this.Lbl_SobrenomeDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SobrenomeDoCliente.ForeColor = System.Drawing.Color.White;
            this.Lbl_SobrenomeDoCliente.Location = new System.Drawing.Point(249, 65);
            this.Lbl_SobrenomeDoCliente.Name = "Lbl_SobrenomeDoCliente";
            this.Lbl_SobrenomeDoCliente.Size = new System.Drawing.Size(95, 16);
            this.Lbl_SobrenomeDoCliente.TabIndex = 4;
            this.Lbl_SobrenomeDoCliente.Text = "Sobrenome :";
            // 
            // Txt_SobrenomeCliente
            // 
            this.Txt_SobrenomeCliente.Location = new System.Drawing.Point(351, 64);
            this.Txt_SobrenomeCliente.Name = "Txt_SobrenomeCliente";
            this.Txt_SobrenomeCliente.Size = new System.Drawing.Size(148, 20);
            this.Txt_SobrenomeCliente.TabIndex = 5;
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CPF.ForeColor = System.Drawing.Color.White;
            this.Lbl_CPF.Location = new System.Drawing.Point(523, 66);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(44, 16);
            this.Lbl_CPF.TabIndex = 6;
            this.Lbl_CPF.Text = "CPF :";
            // 
            // Mask_CPF
            // 
            this.Mask_CPF.Location = new System.Drawing.Point(582, 65);
            this.Mask_CPF.Mask = "000.000.000-00";
            this.Mask_CPF.Name = "Mask_CPF";
            this.Mask_CPF.Size = new System.Drawing.Size(148, 20);
            this.Mask_CPF.TabIndex = 8;
            this.Mask_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(89, 100);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(148, 20);
            this.Txt_Email.TabIndex = 10;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.ForeColor = System.Drawing.Color.White;
            this.Lbl_Email.Location = new System.Drawing.Point(20, 101);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(54, 16);
            this.Lbl_Email.TabIndex = 9;
            this.Lbl_Email.Text = "Email :";
            // 
            // Lbl_DataDeNascimento
            // 
            this.Lbl_DataDeNascimento.AutoSize = true;
            this.Lbl_DataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataDeNascimento.ForeColor = System.Drawing.Color.White;
            this.Lbl_DataDeNascimento.Location = new System.Drawing.Point(253, 104);
            this.Lbl_DataDeNascimento.Name = "Lbl_DataDeNascimento";
            this.Lbl_DataDeNascimento.Size = new System.Drawing.Size(158, 16);
            this.Lbl_DataDeNascimento.TabIndex = 11;
            this.Lbl_DataDeNascimento.Text = "Data De Nascimento :";
            // 
            // Date_DataDeNascimento
            // 
            this.Date_DataDeNascimento.CustomFormat = "00/00/0000";
            this.Date_DataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataDeNascimento.Location = new System.Drawing.Point(410, 104);
            this.Date_DataDeNascimento.MaxDate = new System.DateTime(9000, 1, 1, 0, 0, 0, 0);
            this.Date_DataDeNascimento.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Date_DataDeNascimento.Name = "Date_DataDeNascimento";
            this.Date_DataDeNascimento.Size = new System.Drawing.Size(97, 20);
            this.Date_DataDeNascimento.TabIndex = 13;
            this.Date_DataDeNascimento.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            // 
            // Btn_SalvarNovoCliente
            // 
            this.Btn_SalvarNovoCliente.Location = new System.Drawing.Point(526, 100);
            this.Btn_SalvarNovoCliente.Name = "Btn_SalvarNovoCliente";
            this.Btn_SalvarNovoCliente.Size = new System.Drawing.Size(58, 23);
            this.Btn_SalvarNovoCliente.TabIndex = 14;
            this.Btn_SalvarNovoCliente.Text = "Salvar";
            this.Btn_SalvarNovoCliente.UseVisualStyleBackColor = true;
            this.Btn_SalvarNovoCliente.Click += new System.EventHandler(this.Btn_SalvarNovoCliente_Click);
            // 
            // Btn_ApagarCliente
            // 
            this.Btn_ApagarCliente.Location = new System.Drawing.Point(656, 100);
            this.Btn_ApagarCliente.Name = "Btn_ApagarCliente";
            this.Btn_ApagarCliente.Size = new System.Drawing.Size(65, 23);
            this.Btn_ApagarCliente.TabIndex = 15;
            this.Btn_ApagarCliente.Text = "Apagar";
            this.Btn_ApagarCliente.UseVisualStyleBackColor = true;
            this.Btn_ApagarCliente.Click += new System.EventHandler(this.Btn_ApagarCliente_Click);
            // 
            // Btn_LimparTela
            // 
            this.Btn_LimparTela.Location = new System.Drawing.Point(590, 100);
            this.Btn_LimparTela.Name = "Btn_LimparTela";
            this.Btn_LimparTela.Size = new System.Drawing.Size(60, 23);
            this.Btn_LimparTela.TabIndex = 16;
            this.Btn_LimparTela.Text = "Limpar";
            this.Btn_LimparTela.UseVisualStyleBackColor = true;
            this.Btn_LimparTela.Click += new System.EventHandler(this.Btn_LimparTela_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(758, 41);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(131, 23);
            this.Btn_Buscar.TabIndex = 18;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_BuscaCPF
            // 
            this.Btn_BuscaCPF.Location = new System.Drawing.Point(758, 80);
            this.Btn_BuscaCPF.Name = "Btn_BuscaCPF";
            this.Btn_BuscaCPF.Size = new System.Drawing.Size(131, 23);
            this.Btn_BuscaCPF.TabIndex = 19;
            this.Btn_BuscaCPF.Text = "Busca CPF";
            this.Btn_BuscaCPF.UseVisualStyleBackColor = true;
            this.Btn_BuscaCPF.Click += new System.EventHandler(this.Btn_BuscaCPF_Click);
            // 
            // Dg_Clientes
            // 
            this.Dg_Clientes.AllowUserToAddRows = false;
            this.Dg_Clientes.AllowUserToDeleteRows = false;
            this.Dg_Clientes.AllowUserToOrderColumns = true;
            this.Dg_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clientes.Location = new System.Drawing.Point(21, 194);
            this.Dg_Clientes.MultiSelect = false;
            this.Dg_Clientes.Name = "Dg_Clientes";
            this.Dg_Clientes.ReadOnly = true;
            this.Dg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Clientes.Size = new System.Drawing.Size(868, 406);
            this.Dg_Clientes.TabIndex = 20;
            this.Dg_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Clientes_CellClick);
            // 
            // Frm_CadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(912, 612);
            this.Controls.Add(this.Dg_Clientes);
            this.Controls.Add(this.Btn_BuscaCPF);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_LimparTela);
            this.Controls.Add(this.Btn_ApagarCliente);
            this.Controls.Add(this.Btn_SalvarNovoCliente);
            this.Controls.Add(this.Date_DataDeNascimento);
            this.Controls.Add(this.Lbl_DataDeNascimento);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Mask_CPF);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Txt_SobrenomeCliente);
            this.Controls.Add(this.Lbl_SobrenomeDoCliente);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.Lbl_NomeDoCliente);
            this.Controls.Add(this.Lbl_CadastroDeClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastroDeClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Frm_CadastroDeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CadastroDeClientes;
        private System.Windows.Forms.Label Lbl_NomeDoCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lbl_SobrenomeDoCliente;
        private System.Windows.Forms.TextBox Txt_SobrenomeCliente;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.MaskedTextBox Mask_CPF;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_DataDeNascimento;
        private System.Windows.Forms.DateTimePicker Date_DataDeNascimento;
        private System.Windows.Forms.Button Btn_SalvarNovoCliente;
        private System.Windows.Forms.Button Btn_ApagarCliente;
        private System.Windows.Forms.Button Btn_LimparTela;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_BuscaCPF;
        private System.Windows.Forms.DataGridView Dg_Clientes;
    }
}