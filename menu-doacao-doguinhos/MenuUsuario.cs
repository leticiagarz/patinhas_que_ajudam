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
            bool l2 = true;
            while (l2)
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
                        CadastrarUsuario();
                        break;
                    case 5:
                        l2 = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        public void CadastrarUsuario()
        {
            var cachorro = new Cachorro();

            Console.WriteLine("Nome: ");
            cachorro.Nome = Console.ReadLine();
            cachorro.Nome = cachorro.Nome.First().ToString().ToUpper() + cachorro.Nome.Substring(1);

            Console.WriteLine("Idade: ");
            cachorro.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
            cachorro.Porte = Console.ReadLine();
            cachorro.Porte = cachorro.Porte[0].ToString().ToUpper();
            ValidarNomePorte(cachorro);

            Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
            cachorro.Sexo = Console.ReadLine();
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

        }
        public void Pesquisar()
        {
            Console.WriteLine("Pesquise aqui: ");
            var str = Console.ReadLine();
            var pesquisa = Cachocaos.Find(x => x.Nome == str || x.Castrado == str);
            pesquisa.Listagem();
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
    }
}