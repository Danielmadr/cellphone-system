namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (!AplicativosInstalados.Contains(nomeApp))
            {
                AplicativosInstalados.Add(nomeApp);
                Console.WriteLine($"Aplicativo '{nomeApp}' instalado via App Store.");
            }
            else
            {
                Console.WriteLine($"O aplicativo '{nomeApp}' já está instalado.");
            }
        }
    }
}