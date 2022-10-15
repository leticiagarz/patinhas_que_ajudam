namespace menu_doacao_doguinhos
{
    public class MenuUsuario
    {
        public void EscolherOpcao()
        {
            bool l2 = true;
            while (l2)
            {
                Console.WriteLine("(1) Ver listagem (2) Enviar cão");
                string opcaoMenuUsuario = Console.ReadLine();
                if (opcaoMenuUsuario == "1")
                {

                }
                else if (opcaoMenuUsuario == "2")
                {

                }
                else
                {
                    Console.WriteLine("Opção não autorizada");
                    l2 = false;
                }
            }
            
        }
    }
}
