using System;
namespace menu_doacao_doguinhos
{
    public class MenuAdmin
    {
        public void OpcaoLoginAdmin()
        {
            bool loopingLoginAdmin = true;
            while (loopingLoginAdmin)
            {
                Console.WriteLine("(1) Login (2) Voltar");
                var opcaoLoginAdmin = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcaoLoginAdmin)
                {
                    case 1:
                        Logar();
                        break;
                    case 2:
                        loopingLoginAdmin = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        public void Logar()
        {
                Console.WriteLine("Usuário: ");
                int usuarioDigitado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Senha: ");
                int senhaDigitada = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (usuarioDigitado != 1021 || senhaDigitada != 1312)
                {
                    
                    Console.WriteLine("Acesso não autorizado");
                }
                else
                {
                    OpcaoMenuAdmin();
                }
        }
        public void OpcaoMenuAdmin()
        {
            MenuUsuario menuUsuario = new MenuUsuario();
            bool loopingMenuAdmin = true;
            while (loopingMenuAdmin)
            {
                Console.WriteLine("(1) Ver Listagem (2) Pesquisar (3) Alterar status (4) Excluir (5) Cadastrar cão (6) Voltar");
                var opcaoMenuAdmin = int.Parse(Console.ReadLine());
                switch (opcaoMenuAdmin)
                {
                    case 1:
                        menuUsuario.VerListagem();
                        break;
                    case 2:
                        menuUsuario.Pesquisar();
                        break;
                    case 3:
                        AlterarStatus();
                        break;
                    case 4:
                        ExcluirCao();
                        break;
                    case 5:
                       // menuUsuario.CadastarCao();
                        break;
                    case 6:
                        loopingMenuAdmin = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        public void AlterarStatus()
        {

        }
        public void ExcluirCao()
        {

        }
    }
}
