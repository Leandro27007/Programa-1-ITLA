namespace Programa_1_ITLA
{
    public class Socio
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            private set { _nombre = value; }
        }

        private int _aniosAntiguedad;
        public int AniosAntiguedad
        {
            get { return _aniosAntiguedad; }
            private set { _aniosAntiguedad = value; }
        }


        public Socio(string nombre, int antiguedad)
        {
            this.Nombre = nombre;
            this.AniosAntiguedad = antiguedad;
        }
    }
}