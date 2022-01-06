using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Order
{
    class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o Fichario criada com sucesso.";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }
        public void Incluir(string cpf, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + cpf + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o identificador já existe: " + cpf;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + cpf + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + cpf;

                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }
        public string Buscar(string cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + cpf + ".json")))
                {
                    status = false;
                    mensagem = "Identificador não existente: " + cpf;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + cpf + ".json");
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + cpf;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + cpf + ".json")))
                {
                    status = false;
                    mensagem = "Identificador não existente: " + cpf;
                }
                else
                {
                    File.Delete(diretorio + "\\" + cpf + ".json");
                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. Identificador: " + cpf;

                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }

        }

        public void Alterar(string cpf, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + cpf + ".json")))
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o identificador não existe: " + cpf;
                }
                else
                {
                    File.Delete(diretorio + "\\" + cpf + ".json");
                    File.WriteAllText(diretorio + "\\" + cpf + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + cpf;

                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }
    }
}
