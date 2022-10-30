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
		public Cao()
        {

        }
		public Cao(int id, string nome, int idade, string porte, string sexo, string castrado, DateTime entrega, string status)
		{
			this.Id = id;
			Nome = nome;
			Idade = idade;
			Porte = porte;
			Sexo = sexo;
			Castrado = castrado;
			Entrega = entrega;
			Status = status;
		}
		public static List<Cao>ListaCaes(int id=0, int inicial =0, int limit=0)
        {
			List<Cao> listaCaes = new List<Cao>();
			return listaCaes;
			listaCaes.Add(new Cao
			{
				nome = Console.ReadLine();
		});
			
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
					default:
						Console.WriteLine("Opção inválida");
						break;
				}
			}
		}
		public void CadastrarCao()
		{
				Console.WriteLine("Nome: ");
                Nome = Console.ReadLine();
                Nome = Nome.First().ToString().ToUpper() + Nome.Substring(1);
				Console.WriteLine("Idade: ");
				Idade = int.Parse(Console.ReadLine());
				Console.WriteLine("Porte: (P) Pequeno (M) Médio (G) Grande");
				Porte = Console.ReadLine();
				Porte = Porte[0].ToString().ToUpper();
				ValidarPorte();
				Console.WriteLine("Sexo: (F) Fêmea (M) Macho");
				Sexo = Console.ReadLine();
				Sexo = Sexo[0].ToString().ToUpper();
				ValidarSexo();
				Console.WriteLine("Castrado: (S) Sim (N) Não");
				Castrado = Console.ReadLine();
				Castrado = Castrado[0].ToString().ToUpper();
				ValidarCastracao();
				Console.WriteLine("Data e hora de entrega: ");
				Entrega = Convert.ToDateTime(Console.ReadLine());
				Status = "À caminho";
				Console.Clear();
				Console.WriteLine("Doguinho cadastrado");
        }
		public void VerListagem()
        {
            
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
			
        }
	}
}