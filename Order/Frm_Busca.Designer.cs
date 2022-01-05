
namespace Order
{
    partial class Frm_Busca
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
            this.Lst_Busca = new System.Windows.Forms.ListBox();
            this.Btn_Selecionar = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lst_Busca
            // 
            this.Lst_Busca.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lst_Busca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lst_Busca.FormattingEnabled = true;
            this.Lst_Busca.Location = new System.Drawing.Point(0, 0);
            this.Lst_Busca.Name = "Lst_Busca";
            this.Lst_Busca.Size = new System.Drawing.Size(345, 264);
            this.Lst_Busca.TabIndex = 1;
            // 
            // Btn_Selecionar
            // 
            this.Btn_Selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Selecionar.ForeColor = System.Drawing.Color.Salmon;
            this.Btn_Selecionar.Location = new System.Drawing.Point(39, 270);
            this.Btn_Selecionar.Name = "Btn_Selecionar";
            this.Btn_Selecionar.Size = new System.Drawing.Size(94, 36);
            this.Btn_Selecionar.TabIndex = 2;
            this.Btn_Selecionar.Text = "Selecionar";
            this.Btn_Selecionar.UseVisualStyleBackColor = false;
            this.Btn_Selecionar.Click += new System.EventHandler(this.Btn_Selecionar_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Fechar.ForeColor = System.Drawing.Color.Salmon;
            this.Btn_Fechar.Location = new System.Drawing.Point(198, 270);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(94, 36);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(345, 320);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Selecionar);
            this.Controls.Add(this.Lst_Busca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Busca";
            this.Text = "Busca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Busca;
        private System.Windows.Forms.Button Btn_Selecionar;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}