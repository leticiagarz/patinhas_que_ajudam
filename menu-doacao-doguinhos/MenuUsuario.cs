namespace menu_doacao_doguinhos
{
    public class MenuUsuario
    {
        public List<Cachorro> Cachocaos { get; set; }

        public MenuUsuario()
        {
            Cachocaos = new List<Cachorro>();
        }

        public void OpcaoMenuUsuario()
        {
            bool loopingMenuUsuario = true;
            while (loopingMenuUsuario)
            {
                Console.WriteLine("(1) Ver listagem (2) Pesquisar (3) Adotar (4) Enviar cão (5) Voltar");
                var opcaoMenuUsuario = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcaoMenuUsuario)
                {
                    case 1:
                        VerListagem();
                        break;
                    case 2:
                        Pesquisar();
                        break;
                    case 3:
                        Adotar();
                        break;
                    case 4:
                        CadastrarCao();
                        break;
                    case 5:
                        loopingMenuUsuario = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        public void CadastrarCao()
        {
            var cachorro = new Cachorro();

            Console.WriteLine("Nome: ");
            cachorro.Nome = Console.ReadLine();
            ValidarEmBranco(cachorro);
            cachorro.Nome = cachorro.Nome.First().ToString().ToUpper() + cachorro.Nome.Substring(1);

            Console.WriteLine("Idade: ");
            cachorro.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
            cachorro.Porte = Console.ReadLine();
            ValidarEmBranco(cachorro);
            cachorro.Porte = cachorro.Porte[0].ToString().ToUpper();
            ValidarNomePorte(cachorro);

            Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
            cachorro.Sexo = Console.ReadLine();
            ValidarEmBranco(cachorro);
            cachorro.Sexo = cachorro.Sexo[0].ToString().ToUpper();
            ValidarNomeSexo(cachorro);

            Console.WriteLine("Castrado: (S) Sim (N) Não");
            cachorro.Castrado = Console.ReadLine();
            cachorro.Castrado = cachorro.Castrado[0].ToString().ToUpper();
            ValidarNomeCastracao(cachorro);

            Console.WriteLine("Data e hora de entrega: ");
            cachorro.Entrega = Convert.ToDateTime(Console.ReadLine());

            cachorro.Status = "À caminho";

            var ultimoCachorro = Cachocaos.LastOrDefault();
            cachorro.Id = ultimoCachorro is null ? 0 : ultimoCachorro.Id + 1;

            Console.Clear();
            Cachocaos.Add(cachorro);
            Console.WriteLine("Doguinho cadastrado");
        }
        public void VerListagem()
        {
            foreach (var item in Cachocaos)
            {
                item.Listagem();
            }
        }
        public void Adotar()
        {
            Console.WriteLine("Digite o código do cachorro que você deseja adotar: ");
            int cachorroASerAdotado = int.Parse(Console.ReadLine());
            var adotarCachorro = Cachocaos.Where(x => x.Id == cachorroASerAdotado);
            if (adotarCachorro != null && adotarCachorro.Any())
            {
                foreach (var item in adotarCachorro)
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
            var pesquisas = Cachocaos.Where(x => x.Nome == str || x.Porte == str || x.Sexo == str).ToList();

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
        public void ValidarNomeSexo(Cachorro cachorro)
        {
            if (cachorro.Sexo == "M")
            {
                cachorro.Sexo = "Macho";
            }
            else if (cachorro.Sexo == "F")
            {
                cachorro.Sexo = "Fêmea";
            }
        }
        public void ValidarNomePorte(Cachorro cachorro)
        {
            if (cachorro.Porte == "P")
            {
                cachorro.Porte = "Pequeno";
            }
            else if (cachorro.Porte == "M")
            {
                cachorro.Porte = "Médio";
            }
            else if (cachorro.Porte == "G")
            {
                cachorro.Porte = "Grande";
            }
        }
        public void ValidarNomeCastracao(Cachorro cachorro)
        {
            if (cachorro.Castrado == "S")
            {
                cachorro.Castrado = "Sim";
            }
            else if (cachorro.Castrado == "N")
            {
                cachorro.Castrado = "Não";
            }
        }
        public void ValidarEmBranco(Cachorro cachorro)
        {
            var loopingDoValidarBranco = true;
            while (loopingDoValidarBranco)
            {
                if (cachorro.Nome == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Nome: ");
                    cachorro.Nome = Console.ReadLine();
                }
                else if (cachorro.Porte == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
                    cachorro.Porte = Console.ReadLine();
                }
                else if (cachorro.Sexo == "")
                {
                    Console.WriteLine("O preenchimento é obrigatório");
                    Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
                    cachorro.Sexo = Console.ReadLine();
                }
                else
                {
                    loopingDoValidarBranco = false;
                }
            }

        }
    }
}