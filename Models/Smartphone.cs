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
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Apresentacao()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Modelo: {Modelo}");
            System.Console.WriteLine($"Número de celular {Numero}");
            System.Console.WriteLine($"Armazenamento: {Memoria} Gb");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}