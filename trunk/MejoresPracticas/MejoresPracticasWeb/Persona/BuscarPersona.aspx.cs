using System;
using log4net;
using MejoresPracticasBLL.Persona;

namespace MejoresPracticasWeb.Persona
{
    public partial class BuscarPersona : System.Web.UI.Page
    {

        private IPersonaBll _personaBll;
        private static readonly ILog Log = LogManager.GetLogger(typeof(BuscarPersona));

        public IPersonaBll PersonaBll
        {
            get { return _personaBll; }
            set { _personaBll = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Log.Debug(PersonaBll);
        }
    }
}
