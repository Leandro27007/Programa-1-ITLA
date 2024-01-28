namespace Programa_1_ITLA
{
    public class Club
    {
        private Socio[] socios = new Socio[3];


        public Club(Socio socio1, Socio socio2, Socio socio3)
        {
            this.socios[0] = socio1;
            this.socios[1] = socio2;
            this.socios[2] = socio3;
        }


        public void imprimirMayorSocio()
        {
            Console.WriteLine($"El mayor socio es:  {socios.OrderByDescending(x => x.AniosAntiguedad).First().Nombre }");
        }
    }
}