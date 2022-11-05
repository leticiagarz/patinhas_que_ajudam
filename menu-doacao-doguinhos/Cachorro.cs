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
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Porte: {Porte}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Castrado: {Castrado}");
            Console.WriteLine($"Entrega em:{Entrega.ToString("dd/MM/yyyy hh:mm")}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine("\n");
        }
	}
}
