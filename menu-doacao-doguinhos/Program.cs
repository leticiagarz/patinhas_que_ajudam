﻿using menu_doacao_doguinhos;

MenuUsuario menuUsuario = new MenuUsuario();

Console.WriteLine("(1) Usuário (2) Admnistrador");
string opcaoMenu = Console.ReadLine();
bool l1 = true;
while(l1)
if (opcaoMenu == "1")
{
    menuUsuario.EscolherOpcao();
}
else if (opcaoMenu == "2")
{
    // metodo cecilia
}
else
{
    Console.WriteLine("Opção não autorizada");
    l1 = false;
}
