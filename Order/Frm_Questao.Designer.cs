
namespace Order
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Lbl_Questão = new System.Windows.Forms.Label();
            this.Btm_OK = new System.Windows.Forms.Button();
            this.Btm_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questão
            // 
            this.Lbl_Questão.AutoSize = true;
            this.Lbl_Questão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Questão.Location = new System.Drawing.Point(26, 9);
            this.Lbl_Questão.Name = "Lbl_Questão";
            this.Lbl_Questão.Size = new System.Drawing.Size(230, 20);
            this.Lbl_Questão.TabIndex = 2;
            this.Lbl_Questão.Text = "Você quer excluir o cliente?";
            // 
            // Btm_OK
            // 
            this.Btm_OK.Location = new System.Drawing.Point(141, 41);
            this.Btm_OK.Name = "Btm_OK";
            this.Btm_OK.Size = new System.Drawing.Size(115, 23);
            this.Btm_OK.TabIndex = 3;
            this.Btm_OK.Text = "Sim. Continue";
            this.Btm_OK.UseVisualStyleBackColor = true;
            this.Btm_OK.Click += new System.EventHandler(this.Btm_OK_Click);
            // 
            // Btm_Cancel
            // 
            this.Btm_Cancel.Location = new System.Drawing.Point(141, 85);
            this.Btm_Cancel.Name = "Btm_Cancel";
            this.Btm_Cancel.Size = new System.Drawing.Size(115, 23);
            this.Btm_Cancel.TabIndex = 4;
            this.Btm_Cancel.Text = "Não. Pare";
            this.Btm_Cancel.UseVisualStyleBackColor = true;
            this.Btm_Cancel.Click += new System.EventHandler(this.Btm_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btm_Cancel);
            this.Controls.Add(this.Btm_OK);
            this.Controls.Add(this.Lbl_Questão);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questão;
        private System.Windows.Forms.Button Btm_OK;
        private System.Windows.Forms.Button Btm_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}