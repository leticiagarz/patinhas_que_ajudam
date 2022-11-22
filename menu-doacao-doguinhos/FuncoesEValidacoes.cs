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
            ValidarInputNome(cao);

            Console.WriteLine("Idade: ");
            ValidarInputIdade(cao);

            Console.WriteLine("* Porte: (P) Pequeno (M) Médio (G) Grande");
            cao.Porte = Console.ReadLine();
            ValidarInputPorte(cao);

            Console.WriteLine("* Sexo: (F) Fêmea (M) Macho");
            cao.Sexo = Console.ReadLine();
            ValidarInputSexo(cao);

            Console.WriteLine("Castrado: (S) Sim (N) Não");
            cao.Castrado = Console.ReadLine();
            ValidarInputCastrado(cao);

            Console.WriteLine("Data de entrega:");
            Console.WriteLine("Selecione ENTER para a data de hoje ou digite no formato dd/mm/aaaa");
            ValidarInputEntrega(cao);

            cao.Status = "À caminho";

            var ultimoCao = Caes.LastOrDefault();
            cao.Id = ultimoCao is null ? 0 : ultimoCao.Id + 1;

            Console.Clear();
            Caes.Add(cao);
            Console.WriteLine("Cão cadastrado");
        }
        public void VerListagem()
        {
            if (Caes.Any())
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
            if (Caes.Any())
            {
                Console.WriteLine("Digite o código do cão que você deseja adotar: ");
                int caoASerAdotado = int.Parse(Console.ReadLine());
                var adotarCao = Caes.Where(x => x.Id == caoASerAdotado && x.Status == "Disponível");
                Console.Clear();

                if (adotarCao != null && adotarCao.Any())
                {
                    foreach (var item in adotarCao)
                    {
                        item.Status = "Em processo de adoção";
                    }
                    Console.WriteLine("Dirija-se ao canil para completar a adoção");
                }
                else
                {
                    Console.WriteLine("Não encontrado ou indisponível para adoção");
                }
            }
            else
            {
                Console.WriteLine("Não há cães cadastrados");
            }
        }
        public void Pesquisar()
        {
            if (Caes.Any())
            {
                Console.WriteLine("Pesquise aqui através do ID, nome, porte, sexo, status ou data de entrega do cão: ");
                var str = Console.ReadLine();
                str = str.First().ToString().ToUpper() + str.Substring(1);
                var pesquisas = Caes.Where(x => x.Id.ToString() == str || x.Nome == str || x.Porte == str || x.Sexo == str || x.Status == str || x.Entrega.ToString("dd/MM/yyyy") == str).ToList();
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
            else
            {
                Console.WriteLine("Não há cães cadastrados");
            }
        }
        public void AlterarStatus()
        {
            if (Caes.Any())
            {
                Console.WriteLine("Digite o código do cão que você deseja alterar status: ");
                int caoATerStatusAlterado = int.Parse(Console.ReadLine());
                Console.Clear();
                var alterarStatus = Caes.Where(x => x.Id == caoATerStatusAlterado);

                if (alterarStatus != null && alterarStatus.Any())
                {
                    Console.WriteLine("(1) À caminho (2) Disponível (3) Em processo de adoção (4) Adotado");
                    int statusASerDefinido = int.Parse(Console.ReadLine());
                    Console.Clear();

                    var statusACaminho = "À caminho";
                    var statusDisponivel = "Disponível";
                    var statusEmProcessoDeAdocao = "Em processo de adoção";
                    var statusAdotado = "Adotado";

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
                    Console.WriteLine("Status alterado");
                }
                else
                {
                    Console.WriteLine("Não encontrado");
                }
            }
            else
            {
                Console.WriteLine("Não há cães cadastrados");
            }
        }
        public void ExcluirCao()
        {
            if (Caes.Any())
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
            else
            {
                Console.WriteLine("Não há cães cadastrados");
            }
        }
        public void ValidarInputNome(Cao cao)
        {
            while (cao.Nome == "")
            {
                Console.WriteLine("O preenchimento é obrigatório");
                Console.WriteLine("Nome: ");
                cao.Nome = Console.ReadLine();
            }
            cao.Nome = cao.Nome.First().ToString().ToUpper() + cao.Nome.Substring(1);
        }
        public void ValidarInputIdade(Cao cao)
        {
            var idade = Console.ReadLine();
            var conseguiuConverter = int.TryParse(idade, out var result);

            if (!conseguiuConverter)
            {
                cao.Idade = 0;
            }
            else
            {
                conseguiuConverter = int.TryParse(idade, out result);
                cao.Idade = result;
            }
        }
        public void ValidarInputPorte(Cao cao)
        {
            while (cao.Porte == "")
            {
                Console.WriteLine("O preenchimento é obrigatório");
                Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
                cao.Porte = Console.ReadLine();
            }
            cao.Porte = cao.Porte[0].ToString().ToUpper();

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
        public void ValidarInputSexo(Cao cao)
        {
            while (cao.Sexo == "")
            {
                Console.WriteLine("O preenchimento é obrigatório");
                Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
                cao.Sexo = Console.ReadLine();
            }
            cao.Sexo = cao.Sexo[0].ToString().ToUpper();

            if (cao.Sexo == "M")
            {
                cao.Sexo = "Macho";
            }
            else if (cao.Sexo == "F")
            {
                cao.Sexo = "Fêmea";
            }
        }
        public void ValidarInputCastrado(Cao cao)
        {
            if (cao.Castrado == "")
            {
                cao.Castrado = "Não informado";
            }
            else
            {
                cao.Castrado = cao.Castrado[0].ToString().ToUpper();

                if (cao.Castrado == "S")
                {
                    cao.Castrado = "Sim";
                }
                else if (cao.Castrado == "N")
                {
                    cao.Castrado = "Não";
                }
                else
                {
                    cao.Castrado = "Não informado";
                }
            }
        }
        public void ValidarInputEntrega(Cao cao)
        {
            var entrega = Console.ReadLine();
            var conseguiuConverter = DateTime.TryParse(entrega, out var result);

            if (!conseguiuConverter)
            {
                cao.Entrega = DateTime.Today;
            }
            else
            {
                conseguiuConverter = DateTime.TryParse(entrega, out result);
                cao.Entrega = result;
            }
        }
    }
}
