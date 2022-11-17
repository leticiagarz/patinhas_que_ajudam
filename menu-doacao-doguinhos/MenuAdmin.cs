using System;
namespace menu_doacao_doguinhos
{
    public class MenuAdmin
    {
        public int Usuario { get; set; } = 2411;
        public int Senha { get; set; } = 1501;
        public void OpcaoLoginAdmin(FuncoesEvalidacoes funcoesEValidacoes)
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
                        Logar(funcoesEValidacoes);
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
        public void Logar(FuncoesEvalidacoes funcoesEValidacoes)
        {
            Console.WriteLine("Usuário: ");
            int usuarioDigitado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Senha: ");
            int senhaDigitada = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (usuarioDigitado != Usuario || senhaDigitada != Senha)
            {
                Console.WriteLine("Acesso não autorizado");
            }
            else
            {
                OpcaoMenuAdmin(funcoesEValidacoes);
            }
        }
        public void OpcaoMenuAdmin(FuncoesEvalidacoes funcoesEValidacoes)
        {
            bool loopingMenuAdmin = true;

            while (loopingMenuAdmin)
            {
                Console.WriteLine("(1) Ver Listagem (2) Pesquisar (3) Alterar status (4) Excluir (5) Cadastrar cão (6) Voltar");
                var opcaoMenuAdmin = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoMenuAdmin)
                {
                    case 1:
                        funcoesEValidacoes.VerListagem();
                        break;
                    case 2:
                        funcoesEValidacoes.Pesquisar();
                        break;
                    case 3:
                        funcoesEValidacoes.AlterarStatus();
                        break;
                    case 4:
                        funcoesEValidacoes.ExcluirCao();
                        break;
                    case 5:
                        funcoesEValidacoes.CadastrarCao();
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
    }
}
