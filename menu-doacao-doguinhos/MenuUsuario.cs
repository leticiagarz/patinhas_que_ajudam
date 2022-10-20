namespace menu_doacao_doguinhos
{
	public class MenuUsuario
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }
		public char Porte { get; set; }
		public char Sexo { get; set; }
		public string Castrado { get; set; }
		//ver isso
		public DateTime Entrega { get; set; }
		public string Status { get; set; }
		public void CadastrarUsuario()
		{ 
			Console.WriteLine("Nome:");
			Nome = Console.ReadLine();
			Console.WriteLine("Idade:");
			Idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Porte:");
			Porte = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Sexo:");
			Sexo = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Castrado:");
			Castrado = Console.ReadLine();
			Console.WriteLine("Data e hora de entrega:");
			Entrega = Convert.ToDateTime(Console.ReadLine());
		}
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
		public void VerListagem()
        {
            //for (int i = 0; i < Id; i++)
            //{
            //    Console.WriteLine(arrayUsuario[i]);
            //}
        }
		public void Adotar()
        {
			Console.WriteLine("Digite o código do cão que você deseja adotar ou (A) Voltar ");
            string opcaoMenuUsuario = Console.ReadLine();
            if (opcaoMenuUsuario == "A")
            {
				
            }
            else
			{
				
            }
        }
        public void Pesquisar()
        {
                //		Console.WriteLine("Digite o que você deseja pesquisar:");
                //		string opcaoPesquisar = Console.ReadLine();
                //for?
        }
	}
}