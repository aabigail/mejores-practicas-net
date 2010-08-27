using System.Collections.Generic;
using log4net;
using MejoresPracticasDAL.Persona;
using Model.Persona;
using Util.Entidad;

namespace MejoresPracticasBLL.Persona.Impl
{
    public class PersonaBll : IPersonaBll
    {
        private IPersonaDal _personaDal;

        private static readonly ILog Log = LogManager.GetLogger(typeof(PersonaBll));

        public PersonaBll()
        {
            if (Log.IsInfoEnabled)
            {
                Log.Info("Constructor PersonaBll");
            }
        }

        public IPersonaDal PersonaDal
        {
            get { return _personaDal; }
            set { _personaDal = value; }
        }

        public List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona)
        {
            if (Log.IsDebugEnabled)
            {
                Log.Debug("ObtenerPersonas ( beBuscarPersona : " + beBuscarPersona.ToString() + " )");
            }
            return PersonaDal.ObtenerPersonas(beBuscarPersona);
        }
    }
}
