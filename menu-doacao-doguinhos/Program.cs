using menu_doacao_doguinhos;
MenuUsuario menuUsuario = new();
MenuAdmin menuAdmin = new();
bool loopingMenuPrincipal = true;
while (loopingMenuPrincipal)
{
    Console.WriteLine("(1) Usuário (2) Admnistrador");
    var opcaoMenuPrincipal = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcaoMenuPrincipal)
    {
        case 1:
            menuUsuario.OpcaoMenuUsuario();
            break;
        case 2:
            menuAdmin.OpcaoMenuAdmin();
            break;
        default:
            Console.WriteLine("Opcão inválida");
            break;
    }
}
