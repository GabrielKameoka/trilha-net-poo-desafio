namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            System.Console.WriteLine();
            Console.WriteLine("Ligando...");
            System.Console.WriteLine();
        }

        public void ReceberLigacao()
        {
            System.Console.WriteLine();
            Console.WriteLine("Recebendo ligação...");
            System.Console.WriteLine();
        }

        public void Apresentacao()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Modelo: {Modelo}");
            System.Console.WriteLine($"Número de celular: {Numero}");
            System.Console.WriteLine($"Armazenamento: {Memoria} Gb");
            System.Console.WriteLine();
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}