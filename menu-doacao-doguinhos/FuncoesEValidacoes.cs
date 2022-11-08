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
            cao.Idade = int.Parse(Console.ReadLine());
            //ValidarEmBranco(cao);

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

            cao.Status = "À caminho";

            var ultimoCao = Caes.LastOrDefault();
            cao.Id = ultimoCao is null ? 0 : ultimoCao.Id + 1;

            Console.Clear();
            Caes.Add(cao);
            Console.WriteLine("Cão cadastrado");
        }
        public void VerListagem()
        {
            foreach (var item in Caes)
            {
                item.Listagem();
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
            var pesquisas = Caes.Where(x => x.Nome == str || x.Porte == str || x.Sexo == str).ToList();
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
            Console.WriteLine("(1) Á caminho (2) Disponível (3) Em processo de adoção (4) Adotado");
            int statusASerDefinido = int.Parse(Console.ReadLine());
            var alterarStatus = Caes.Where(x => x.Id == caoATerStatusAlterado);
            Console.Clear();

            var statusACaminho = "Á caminho";
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
                }
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
            Console.Clear();
            Console.WriteLine("Status alterado");
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
                }
                if (cao.Porte == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
                    cao.Porte = Console.ReadLine();
                }
                if (cao.Sexo == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
                    cao.Sexo = Console.ReadLine();
                }
                //if (cao.Idade == 0)
                //{
                //    cao.Idade.ToString("Não informado");
                //}
                if (cao.Castrado == "")
                {
                    cao.Castrado = "-";
                }
                else
                {
                    loopingDoValidarBranco = false;
                    break;
                }

            }

        }
    }
}
