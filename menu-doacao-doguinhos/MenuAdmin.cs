using System;
namespace menu_doacao_doguinhos
{
    public class MenuAdmin
    {
        

        public int Admins { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Castracao { get; set; }
        public char Sexo { get; set; }
        public char Porte { get; set; }


        public void OpcaoMenuAdmin()
        {

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Selecione umas das opções do menu:");
                Console.WriteLine("1 - Login\n2 - Voltar ao menu principal\n");
                string opcaoMenuAdmin = Console.ReadLine();

                if (opcaoMenuAdmin == "1")
                {
                    Logar();
                }
                else if(opcaoMenuAdmin == "2")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Selecione uma opção válida");
                }
            }
        }
        public void Logar()
        {
                Console.WriteLine("Digite seu número de user");
                int UserDigitado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite sua senha");
                int senhaDigitada = Convert.ToInt32(Console.ReadLine());

                if (UserDigitado != 1021 || senhaDigitada != 1312)
                {
                    Console.Clear();
                    Console.WriteLine("Acesso não autorizado");
                }
                else
                {
                    Console.WriteLine("Bem-vindo ao sistema");
                    OpcaoLogin();

                }
            
            
        }
        public void OpcaoLogin()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Escolha uma ação para continuar:\n 1 - Ver Listagem \n 2 - Cadastrar cães\n 3 - Alterar Status\n 4 - Voltar para login ");
                string opcaoMenuLogin = Console.ReadLine();

                if(opcaoMenuLogin == "1")
                {
                    Listagem();
                }
                else if (opcaoMenuLogin == "2")
                {
                    CadastrarCaes();
                }
                else if (opcaoMenuLogin == "3")
                {
                    AlterarStatus();
                }
                else if(opcaoMenuLogin == "4")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Selecione uma opção válida");
                }
            }
        }
        public void Listagem()
        {

        }
        public void CadastrarCaes()
        {


        }
        public void AlterarStatus()
        {

        }
    }
}
