namespace menu_doacao_doguinhos
{
	public class MenuUsuario
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Porte { get; set; }
		public string Sexo { get; set; }
		public string Castrado { get; set; }
		//ver isso
		public DateTime Entrega { get; set; }
		public string Status { get; set; }
		public void OpcaoMenuUsuario()
		{
			bool l2 = true;
			while (l2)
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
						CadastrarUsuario();
						break;
					case 4:
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
			Console.WriteLine("Nome: ");
			Nome = Console.ReadLine();
			Console.WriteLine("Idade: ");
			Idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
			Porte = Console.ReadLine();
			Porte = Porte[0].ToString().ToUpper();
			Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
			Sexo = Console.ReadLine();
			Sexo = Sexo.Substring(0, 1);
			Sexo.ToUpper();
			Console.WriteLine("Castrado: (S) Sim (N) Não");
			Castrado = Console.ReadLine();
			Castrado = Castrado.Substring(0, 1);
			Castrado.ToUpper();
			Console.WriteLine("Data e hora de entrega: ");
			Entrega = Convert.ToDateTime(Console.ReadLine());
			Status = "À caminho";
			Id++;
			Console.Clear();
			Console.WriteLine("Doguinho cadastrado");
			
        }
		public void VerListagem()
        {
            //for (int i = 0; i < Id; i++)
            //{
            //    Console.WriteLine(arrayUsuario[i]);
            //}
            Console.WriteLine($"Id: {Id} - Nome: {Nome} - Idade: {Idade} - Porte: {Porte} - Sexo: {Sexo} - Castração: {Castrado} - Entrega: {Entrega} - Status: {Status}");
        }
		public void Adotar()
        {
			//Console.WriteLine("Digite o código do cão que você deseja adotar ou (A) Voltar ");
   //         string opcaoMenuUsuario = Console.ReadLine();
   //         if (opcaoMenuUsuario == "A")
   //         {
				
   //         }
   //         else
			//{
				
   //         }
        }
        public void Pesquisar()
        {
                //		Console.WriteLine("Digite o que você deseja pesquisar:");
                //		string opcaoPesquisar = Console.ReadLine();
                //for?
        }
		public void ValidarSexo()
        {
			if (Sexo == "M")
			{
				Sexo = "Macho";
			}
			else if (Sexo == "F")
			{
				Sexo = "Fêmea";
			}
			else
			{
				Console.WriteLine("Opção inválida");
			}
		}
		public void ValidarPorte()
        {
			if (Porte == "P")
			{
				Porte = "Pequeno";
			}
			else if (Porte == "M")
			{
				Porte = "Médio";
			}
			else if (Porte == "G")
			{
				Porte = "Grande";
			}
			else
			{
				Console.WriteLine("Opção inválida");
			}
		}
		public void ValidarCastracao()
        {
			if (Castrado == "S")
            {
				Castrado = "Sim";
            }
			else if (Castrado == "N")
            {
				Castrado = "Não";
            }
			else
            {
				Console.WriteLine("Opção inválida");
			}
			
        }
	}
}