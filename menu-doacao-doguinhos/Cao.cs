namespace menu_doacao_doguinhos
{
	public class Cao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Porte { get; set; }
		public string Sexo { get; set; }
		public string Castrado { get; set; }
		public DateTime Entrega { get; set; }
		public string Status { get; set; }
        public List<Cao> ListaCaes { get; set; } = new List<Cao>()
        {
            
        };
        public Cao()
		{

		}
		public Cao(int id, string nome, int idade, string porte, string sexo, string castrado, DateTime entrega, string status)
		{
            Id = 0;
			Nome = nome;
			Idade = idade;
			Porte = porte;
			Sexo = sexo;
			Castrado = castrado;
			Entrega = entrega;
			Status = status;
        }

        public void OpcaoMenuUsuario()
		{
            bool loopMenuUsuario = true;
            while (loopMenuUsuario)
            {
                Console.WriteLine("(1) Ver listagem (2) Adotar (3) Enviar cão (4) Voltar");
                var opcaoMenuUsuario = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcaoMenuUsuario)
                {
                    case 1:
                        VerListagem();
                        break;
                    case 2:
                        Adotar();
                        break;
                    case 3:
                        CadastrarCao();
                        break;
                    case 4:
                        loopMenuUsuario = false;
                        break;
                }
            }
        }
		public void CadastrarCao()
		{
          //  if (ListaCaes.Count < 100)
          //  {
            for (int i = 0; i < 100; i++)
            {
                if (ListaCaes[i].Id == 0)
                {
                    ListaCaes[i].Id = i++;
                    Console.WriteLine("Nome: ");
                    Nome = Console.ReadLine();
                    ListaCaes[i].Nome = Nome.First().ToString().ToUpper() + Nome.Substring(1);
                    Console.WriteLine("Idade: ");
                    ListaCaes[i].Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
                    Porte = Console.ReadLine();
                    ListaCaes[i].Porte = Porte[0].ToString().ToUpper();
                    ValidarPorte();
                    Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
                    Sexo = Console.ReadLine();
                    ListaCaes[i].Sexo = Sexo[0].ToString().ToUpper();
                    ValidarSexo();
                    Console.WriteLine("Castrado: (S) Sim (N) Não");
                    Castrado = Console.ReadLine();
                    ListaCaes[i].Castrado = Castrado[0].ToString().ToUpper();
                    ValidarCastracao();
                    Console.WriteLine("Data e hora de entrega: ");
                    ListaCaes[i].Entrega = Convert.ToDateTime(Console.ReadLine());
                    ListaCaes[i].Status = "À caminho";
                    Console.Clear();
                    ListaCaes.Add(new Cao(Id, Nome, Idade, Porte, Sexo, Castrado, Entrega, Status));
                    Console.WriteLine("Doguinho cadastrado");
                    break;
                }
            }
            foreach (Cao cao in ListaCaes)
            {
                    Console.WriteLine(cao);
            }
            //}
            //else
            //{
            //    Console.WriteLine("Lotação máxima atingida.");
            //}
        }
		public void VerListagem()
		{
            //foreach (Cao cao in listaCaes)
            //{
            //    Console.WriteLine(cao);
            //}

        }
		public void Adotar()
		{
		//		//Console.WriteLine("Digite o código do cão que você deseja adotar ou (A) Voltar ");
		//  //         string opcaoMenuUsuario = Console.ReadLine();
		//  //         if (opcaoMenuUsuario == "A")
		//  //         {

		//  //         }
		//  //         else
		//		//{

		//  //         }
		}
		public void Pesquisar()
        {
            //               //		Console.WriteLine("Digite o que você deseja pesquisar:");
            //               //		string opcaoPesquisar = Console.ReadLine();
            //               //for?
        }
        public void ValidarSexo()
        {
            //		if (Sexo == "M")
            //		{
            //			Sexo = "Macho";
            //		}
            //		else if (Sexo == "F")
            //		{
            //			Sexo = "Fêmea";
            //		}
        }
        public void ValidarPorte()
        {
            //		if (Porte == "P")
            //		{
            //			Porte = "Pequeno";
            //		}
            //		else if (Porte == "M")
            //		{
            //			Porte = "Médio";
            //		}
            //		else if (Porte == "G")
            //		{
            //			Porte = "Grande";
            //		}
        }
        public void ValidarCastracao()
        {
            //		if (Castrado == "S")
            //           {
            //			Castrado = "Sim";
            //           }
            //		else if (Castrado == "N")
            //           {
            //			Castrado = "Não";
            //           }

            //       }
        }
    }
}