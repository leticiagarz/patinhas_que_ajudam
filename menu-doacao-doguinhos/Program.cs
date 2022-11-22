using menu_doacao_doguinhos;
MenuUsuario menuUsuario = new();
MenuAdmin menuAdmin = new();
FuncoesEvalidacoes funcoesEValidacoes = new();
bool loopingMenuPrincipal = true;

while (loopingMenuPrincipal)
{
    Console.WriteLine("(1) Usuário (2) Admnistrador");
    var opcaoMenuPrincipal = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcaoMenuPrincipal)
    {
        case 1:
            menuUsuario.OpcaoMenuUsuario(funcoesEValidacoes);
            break;
        case 2:
            menuAdmin.OpcaoLoginAdmin(funcoesEValidacoes);
            break;
        default:
            Console.WriteLine("Opcão inválida");
            break;
    }
} 