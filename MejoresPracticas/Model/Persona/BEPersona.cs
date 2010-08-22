using Model.Base;

namespace Model.Persona
{
    public class BePersona : BeBase
    {
        private string _nombres;
        private string _apellidos;

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
    }
}
