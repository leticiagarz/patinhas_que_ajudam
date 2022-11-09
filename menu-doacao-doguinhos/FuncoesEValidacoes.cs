using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_doacao_doguinhos
{
    public class FuncoesEvalidacoes
    {
        public List<Cao> Caes { get; set; }

        public FuncoesEvalidacoes()
        {
            Caes = new List<Cao>();
        }
        public void CadastrarCao()
        {
            var cao = new Cao();
            Console.WriteLine("Os itens marcados com * são obrigatórios");
            Console.WriteLine("* Nome: ");
            cao.Nome = Console.ReadLine();
            ValidarEmBranco(cao);
            cao.Nome = cao.Nome.First().ToString().ToUpper() + cao.Nome.Substring(1);

            Console.WriteLine("Idade: ");
            cao.Idade = Convert.ToInt32(Console.ReadLine());
            ValidarEmBranco(cao);

            Console.WriteLine("* Porte: (P) Pequeno (M) Médio (G) Grande");
            cao.Porte = Console.ReadLine();
            ValidarEmBranco(cao);
            cao.Porte = cao.Porte[0].ToString().ToUpper();
            ValidarPalavraPorte(cao);

            Console.WriteLine("* Sexo: (F) Fêmea (M) Macho");
            cao.Sexo = Console.ReadLine();
            ValidarEmBranco(cao);
            cao.Sexo = cao.Sexo[0].ToString().ToUpper();
            ValidarPalavraSexo(cao);

            Console.WriteLine("Castrado: (S) Sim (N) Não");
            cao.Castrado = Console.ReadLine();
            ValidarEmBranco(cao);
            cao.Castrado = cao.Castrado[0].ToString().ToUpper();
            ValidarPalavraCastracao(cao);

            Console.WriteLine("Data de entrega: ");
            cao.Entrega = Convert.ToDateTime(Console.ReadLine());
            ValidarEmBranco(cao);

            cao.Status = "À caminho";

            var ultimoCao = Caes.LastOrDefault();
            cao.Id = ultimoCao is null ? 0 : ultimoCao.Id + 1;

            Console.Clear();
            Caes.Add(cao);
            Console.WriteLine("Cão cadastrado");
        }
        public void VerListagem()
        {
            if (Caes.Count > 0)
            {
                foreach (var item in Caes)
                {
                    item.Listagem();
                }
            }
            else
            {
                Console.WriteLine("Não há cães cadastrados");
            }
        }
        public void Adotar()
        {
            Console.WriteLine("Digite o código do cão que você deseja adotar: ");
            int caoASerAdotado = int.Parse(Console.ReadLine());
            var caoDisponivel = Caes.Where(x => x.Status == "Disponível");
            var adotarCao = Caes.Where(x => x.Id == caoASerAdotado);
            Console.Clear();

            if (adotarCao != null && adotarCao.Any() && caoDisponivel.Any())
            {
                foreach (var item in adotarCao)
                {
                    item.Status = "Em processo de adoção";
                }
                Console.WriteLine("Dirija-se ao canil para completar a adoção");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
        }
        public void Pesquisar()
        {
            Console.WriteLine("Pesquise aqui: ");
            var str = Console.ReadLine();
            str = str.First().ToString().ToUpper() + str.Substring(1);
            var pesquisas = Caes.Where(x => x.Nome == str || x.Porte == str || x.Sexo == str || x.Status == str).ToList();
            Console.Clear();

            if (pesquisas != null && pesquisas.Any())
            {
                foreach (var item in pesquisas)
                {
                    item.Listagem();
                }
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
        }
        public void AlterarStatus()
        {
            Console.WriteLine("Digite o código do cão que você deseja alterar status: ");
            int caoATerStatusAlterado = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("(1) À caminho (2) Disponível (3) Em processo de adoção (4) Adotado");
            int statusASerDefinido = int.Parse(Console.ReadLine());
            var alterarStatus = Caes.Where(x => x.Id == caoATerStatusAlterado);
            Console.Clear();

            var statusACaminho = "À caminho";
            var statusDisponivel = "Disponível";
            var statusEmProcessoDeAdocao = "Em processo de adoção";
            var statusAdotado = "Adotado";

            if (alterarStatus != null && alterarStatus.Any())
            {
                foreach (var item in alterarStatus)
                {
                    if (statusASerDefinido == 1)
                    {
                        item.Status = statusACaminho;
                    }
                    else if (statusASerDefinido == 2)
                    {
                        item.Status = statusDisponivel;
                    }
                    else if (statusASerDefinido == 3)
                    {
                        item.Status = statusEmProcessoDeAdocao;
                    }
                    else
                    {
                        item.Status = statusAdotado;
                    }
                    Console.WriteLine("Status alterado");
                }
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
            Console.Clear();
        }
        public void ExcluirCao()
        {
            Console.WriteLine("Digite o código do cão que você deseja excluir: ");
            int caoASerExcluido = int.Parse(Console.ReadLine());
            Console.Clear();
            var excluirCao = Caes.Where(x => x.Id == caoASerExcluido);
            Console.Clear();

            if (excluirCao != null && excluirCao.Any())
            {
                foreach (var item in excluirCao)
                {
                    Caes.Remove(item);
                    break;
                }
                Console.WriteLine("Cão excluído");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
        }
        public void ValidarPalavraSexo(Cao cao)
        {
            if (cao.Sexo == "M")
            {
                cao.Sexo = "Macho";
            }
            else if (cao.Sexo == "F")
            {
                cao.Sexo = "Fêmea";
            }
        }
        public void ValidarPalavraPorte(Cao cao)
        {
            if (cao.Porte == "P")
            {
                cao.Porte = "Pequeno";
            }
            else if (cao.Porte == "M")
            {
                cao.Porte = "Médio";
            }
            else if (cao.Porte == "G")
            {
                cao.Porte = "Grande";
            }
        }
        public void ValidarPalavraCastracao(Cao cao)
        {
            if (cao.Castrado == "S")
            {
                cao.Castrado = "Sim";
            }
            else if (cao.Castrado == "N")
            {
                cao.Castrado = "Não";
            }
        }
        public void ValidarEmBranco(Cao cao)
        {
            var loopingDoValidarBranco = true;
            while (loopingDoValidarBranco)
            {
                if (cao.Nome == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Nome: ");
                    cao.Nome = Console.ReadLine();
                    ValidarEmBranco(cao);
                }
                if (cao.Porte == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
                    cao.Porte = Console.ReadLine();
                    ValidarEmBranco(cao);
                }
                if (cao.Sexo == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
                    cao.Sexo = Console.ReadLine();
                    ValidarEmBranco(cao);
                }
                //if (cao.Idade.ToString(""))
                //{
                //    cao.Idade.ToString("Não informado");
                //}
                if (cao.Castrado == "")
                {
                    cao.Castrado = "Não informado";
                    ValidarEmBranco(cao);
                }
                //if (cao.Entrega == )
                //{
                //    cao.Entrega.ToString("Não informado");
                //}
                else
                {
                    loopingDoValidarBranco = false;
                    break;
                }
            }
        }
    }
}
