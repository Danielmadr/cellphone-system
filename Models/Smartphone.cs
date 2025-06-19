namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string Modelo;
        private string IMEI;
        private int Memoria;

        protected List<string> AplicativosInstalados;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            AplicativosInstalados = new List<string>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ListarAplicativos()
        {
            Console.WriteLine($"\nAplicativos instalados no {Modelo}:");
            if (AplicativosInstalados.Count == 0)
            {
                Console.WriteLine("Nenhum aplicativo instalado.");
            }
            else
            {
                foreach (var app in AplicativosInstalados)
                {
                    Console.WriteLine($"- {app}");
                }
            }
        }

        public void DesinstalarAplicativo(string nomeApp)
        {
            if (AplicativosInstalados.Contains(nomeApp))
            {
                AplicativosInstalados.Remove(nomeApp);
                Console.WriteLine($"Aplicativo '{nomeApp}' desinstalado com sucesso.");
            }
            else
            {
                Console.WriteLine($"O aplicativo '{nomeApp}' não está instalado.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}