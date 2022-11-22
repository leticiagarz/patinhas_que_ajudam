namespace menu_doacao_doguinhos
{
    public class MenuUsuario
    {
        public void OpcaoMenuUsuario(FuncoesEvalidacoes funcoesEValidacoes)
        {
            bool loopingMenuUsuario = true;

            while (loopingMenuUsuario)
            {
                Console.WriteLine("(1) Ver listagem (2) Pesquisar (3) Adotar (4) Enviar cão (5) Voltar");
                var opcaoMenuUsuario = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoMenuUsuario)
                {
                    case 1:
                        funcoesEValidacoes.VerListagem();
                        break;
                    case 2:
                        funcoesEValidacoes.Pesquisar();
                        break;
                    case 3:
                        funcoesEValidacoes.Adotar();
                        break;
                    case 4:
                        funcoesEValidacoes.CadastrarCao();
                        break;
                    case 5:
                        loopingMenuUsuario = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
