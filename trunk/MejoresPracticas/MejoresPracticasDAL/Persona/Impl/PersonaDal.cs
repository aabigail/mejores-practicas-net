using System.Collections.Generic;
using log4net;
using Model.Persona;
using Util.Entidad;

namespace MejoresPracticasDAL.Persona.Impl
{
    public class PersonaDal : IPersonaDal
    {
        private List<BePersona> _listMock;

        private static readonly ILog Log = LogManager.GetLogger(typeof(PersonaDal));

        public PersonaDal()
        {
            
            if(Log.IsDebugEnabled)
            {
                Log.Debug("Constructor PersonaDal");
            }

            
            _listMock = new List<BePersona>();
            BePersona bePersona;
            for (int i = 0; i < 200; i++)
            {
                bePersona = new BePersona
                                {
                                    Codigo = i.ToString(),
                                    Nombres = "Nombre " + i,
                                    Apellidos = "Apellido " + i,
                                    Descripcion = "Descripcion " + i
                                };
                _listMock.Add(bePersona);
            }
        }

        public List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona)
        {
            if (Log.IsDebugEnabled)
            {
                Log.Debug("ObtenerPersonas");
            }
            
            List<BePersona> lista;
            lista = new List<BePersona>();
            foreach (BePersona bePersona in _listMock)
            {
                if(beBuscarPersona.NombresApellidos.Contains(bePersona.Nombres) ||
                   beBuscarPersona.NombresApellidos.Contains(bePersona.Apellidos) )
                {
                    lista.Add(bePersona);
                }
            }

            if (Log.IsDebugEnabled)
            {
                Log.Debug("Registros " + lista.Count);
            }

            return lista;
        }
    }
}
