using DesafioPOO.Models;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Qual marca de celular você deseja comprar?");
        System.Console.WriteLine("1 - Nokia");
        System.Console.WriteLine("2 - Iphone");
        string escolha = Console.ReadLine();

        if (escolha == "Nokia" || escolha == "1")
        {
            System.Console.WriteLine($"Escolha algum modelo. Aqui estão alguns modelos de celulares da {escolha}: ");
            System.Console.WriteLine("1 - Nokia 5.4");
            System.Console.WriteLine("2 - Nokia 5.3");
            string escolhaModelo = Console.ReadLine();

            if (escolhaModelo == "1" || escolhaModelo == "Nokia 5.4")
            {
                if (escolhaModelo == "1")
                {
                    escolhaModelo = "Nokia 5.4";
                }
                System.Console.WriteLine("Qual vai ser o armazenamento? ");
                System.Console.WriteLine("8 16 64 124");
                int escolhaMemoria = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o seu número?");
                string numero = Console.ReadLine();

                Smartphone nokia = new Nokia(numero, escolhaModelo, "9821347", escolhaMemoria);

                nokia.Apresentacao();

                System.Console.WriteLine("Iremos te ligar para testar o seu número de celular.");
                nokia.Ligar();

                System.Console.WriteLine("Digite o nome do aplicativo para instalar");
                string nomeApp = Console.ReadLine();

                nokia.InstalarAplicativo(nomeApp);
            }

            if (escolhaModelo == "2" || escolha == "Nokia 5.3")
            {
                if (escolhaModelo == "2")
                {
                    escolhaModelo = "Nokia 5.3";
                }
                System.Console.WriteLine("Qual vai ser o armazenamento? ");
                System.Console.WriteLine("8 16 64 124 248");
                int escolhaMemoria = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o seu número?");
                string numero = Console.ReadLine();

                Smartphone nokia = new Nokia(numero, escolhaModelo, "79014238", escolhaMemoria);

                nokia.Apresentacao();

                System.Console.WriteLine("Iremos te ligar para testar o seu número de celular.");
                nokia.Ligar();

                System.Console.WriteLine("Digite o nome do aplicativo para instalar");
                string nomeApp = Console.ReadLine();

                nokia.InstalarAplicativo(nomeApp);
            }
        }

        if (escolha == "Iphone" || escolha == "2")
        {
            System.Console.WriteLine($"Escolha algum modelo. Aqui estão alguns modelos de celulares da {escolha}: ");
            System.Console.WriteLine("1 - Iphone X");
            System.Console.WriteLine("2 - Iphone 13");
            string escolhaModelo = Console.ReadLine();

            if (escolhaModelo == "1" || escolha == "Iphone X")
            {
                if (escolhaModelo == "1")
                {
                    escolhaModelo = "Iphone x";
                }

                System.Console.WriteLine("Qual vai ser o armazenamento? ");
                System.Console.WriteLine("8 16 64 124");
                int escolhaMemoria = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o seu número?");
                string numero = Console.ReadLine();

                Smartphone iphone = new Iphone(numero, escolhaModelo, "9821347", escolhaMemoria);

                iphone.Apresentacao();

                System.Console.WriteLine("Iremos te ligar para testar o seu número de celular.");
                iphone.Ligar();

                System.Console.WriteLine("Digite o nome do aplicativo para instalar");
                string nomeApp = Console.ReadLine();

                iphone.InstalarAplicativo(nomeApp);
            }

            if (escolhaModelo == "2" || escolha == "Iphone 13")
            {
                if (escolhaModelo == "2")
                {
                    escolhaModelo = "Iphone 13";
                }

                System.Console.WriteLine("Qual vai ser o armazenamento? ");
                System.Console.WriteLine("8 16 64 124 248");
                int escolhaMemoria = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Qual o seu número?");
                string numero = Console.ReadLine();

                Smartphone iphone = new Iphone(numero, escolhaModelo, "79014238", escolhaMemoria);

                iphone.Apresentacao();

                System.Console.WriteLine("Iremos te ligar para testar o seu número de celular.");
                iphone.Ligar();

                System.Console.WriteLine("Digite o nome do aplicativo para instalar");
                string nomeApp = Console.ReadLine();

                iphone.InstalarAplicativo(nomeApp);
            }
        }
    }
}