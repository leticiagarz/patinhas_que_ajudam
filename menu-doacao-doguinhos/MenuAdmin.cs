using System;
namespace menu_doacao_doguinhos
{
    public class MenuAdmin
    {
        public int Codigo { get; set; }
        public int Senha { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Castracao { get; set; }
        public char Sexo { get; set; }
        public char Porte { get; set; }

        public void OpcaoMenuAdmin()
        {
            Console.WriteLine("Selecione umas das opções do menu:");
            Console.WriteLine("1 - Login\n 2 - Cadastrar como administador\n 3 - Voltar ao menu principal\n");
            string opcaoMenuAdmin = Console.ReadLine();

            if (opcaoMenuAdmin == "1")
            {
                Logar();
            }
            if (opcaoMenuAdmin == "2")
            {
                CadastrarAdmin();
            }
        }
        public void Logar()
        {
            if (Codigo == null)
            {
                Console.WriteLine("Se cadastre para realizar um login");
            }
            else
            {
                Console.WriteLine("Digite seu número de user");
                int UserDigitado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite sua senha");
                int senhaDigitada = Convert.ToInt32(Console.ReadLine());

                if (UserDigitado != Codigo || senhaDigitada != Senha)
                {
                    Console.WriteLine("Acesso não autorizado");
                }
                else
                {
                    Console.WriteLine("Bem-vindo ao sistema");
                }
            }
        }
        public void CadastrarAdmin()
        {

        }
        public void CadastrarCaes()
        {

        }
    }
}
