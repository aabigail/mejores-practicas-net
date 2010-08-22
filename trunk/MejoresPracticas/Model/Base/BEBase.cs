namespace Model.Base
{
    public abstract class BeBase
    {
        private string _codigo;
        private string _descripcion;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
