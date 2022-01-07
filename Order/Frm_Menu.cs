using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Order
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      


        private void AbrirFormNoPainel(object formfilho)
        {
            if(this.Painel_Recipiente.Controls.Count > 0)
            {
                this.Painel_Recipiente.Controls.RemoveAt(0);
            }
            Form ff = formfilho as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.Painel_Recipiente.Controls.Add(ff);
            this.Painel_Recipiente.Tag = ff;
            ff.Show();

        }

       

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Btn_Inicio_Click(null, e);
        }

     

        

        

       

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btn_Minimizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void hideSubMenu()
        {
           // Painel_Insivel_Cliente.Visible = false;
           // panelPlaylistSubMenu.Visible = false;
           // panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        

        private void Btn_CadastroDeClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Frm_CadastroDeClientes());
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Frm_Inicio());
        }

        private void Btn_CadastroDeVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Frm_RegistroDePedido());
        }

        private void Btn_CadastroDeProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Frm_CadastroDeProduto());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
