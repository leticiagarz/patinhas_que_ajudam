﻿namespace menu_doacao_doguinhos
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
		public MenuUsuario()
		{
			string[] MenUsuario = new string[100];
			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine("Nome:");
				Nome[i] = Console.ReadLine();
				Console.WriteLine("Idade:");
				Idade[i] = int.Parse(Console.ReadLine());
				Console.WriteLine("Porte:");
				Porte[i] = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Sexo:");
				Sexo[i] = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Castrado:");
				Castrado[i] = Console.ReadLine();
				Console.WriteLine("Data e hora de entrega:");
				Entrega[i] = Convert.ToDateTime(Console.ReadLine());
				break;
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
		public void CadastrarUsuario()
		{
			string[] array = new string[1];
			for (int i = 0; i < 2; i++)
            {
				Console.WriteLine("Nome:");
                Nome[i] = Console.ReadLine();
				Console.WriteLine("Idade:");
                Idade[i] = int.Parse(Console.ReadLine());
				Console.WriteLine("Porte:");
                Porte[i] = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Sexo:");
                Sexo[i] = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Castrado:");
                Castrado[i] = Console.ReadLine();
				Console.WriteLine("Data e hora de entrega:");
                Entrega[i] = Convert.ToDateTime(Console.ReadLine());
				break;
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
			//		Console.WriteLine("Digite o código do cão que você deseja adotar ou (A) Voltar ");
			//		string escolha = Console.ReadLine();
			//		if (escolha == "A")
			//		{
			//voltar 
			//		}
			//		else
			//		{
			//for p/ array?
			//		}
			//	}

			//	public void Pesquisar()
			//	{
			//		Console.WriteLine("Digite o que você deseja pesquisar:");
			//		string opcaoPesquisar = Console.ReadLine();
			//for?
		}
	}
}