using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();
        public string idSelect { get; set; }

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            preencherLista();
            Lst_Busca.Sorted = true;
        }

        private void preencherLista()
        {
            Lst_Busca.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.PrimeiroNome = _ListaBusca[i][1];
                X.Sobrenome = _ListaBusca[i][2];
                Lst_Busca.Items.Add(X);

            }
        }

        class ItemBox
        {
            public string id { get; set; }
            public string PrimeiroNome { get; set; }
            public string Sobrenome { get; set; }

            public override string ToString()
            {
                return PrimeiroNome;

            }
        }

        private void Btn_Selecionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];
            idSelect = ItemSelecionado.id;
            this.Close();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
