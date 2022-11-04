using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_doacao_doguinhos
{
    public class Cachorro
    {
		public int Id { get; set; }

		public string Nome { get; set; }

		public int Idade { get; set; }

		public string Porte { get; set; }

		public string Sexo { get; set; }

		public string Castrado { get; set; }

		public DateTime Entrega { get; set; }

		public string Status { get; set; }

		public void Listagem()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Nome);
            Console.WriteLine(Idade);
            Console.WriteLine(Porte);
            Console.WriteLine(Sexo);
            Console.WriteLine(Castrado);
            Console.WriteLine(Entrega.ToString("dd/MM/yyyy"));
            Console.WriteLine(Status);
            Console.WriteLine("\n");
        }
	}
}
