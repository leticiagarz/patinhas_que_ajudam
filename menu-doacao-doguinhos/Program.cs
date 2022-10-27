using menu_doacao_doguinhos;
MenuUsuario menuUsuario = new();
MenuAdmin menuAdmin = new();
bool l1 = true;
while (l1)
{
    Console.WriteLine("(1) Usuário (2) Admnistrador");
    var opcaoMenu = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcaoMenu)
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
