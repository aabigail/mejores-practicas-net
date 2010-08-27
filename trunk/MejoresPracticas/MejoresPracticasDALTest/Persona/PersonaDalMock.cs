using System;
using System.Collections.Generic;
using MejoresPracticasDAL.Persona;
using Model.Persona;
using Util.Entidad;

namespace MejoresPracticasDALTest.Persona
{
    public class PersonaDalMock : IPersonaDal
    {
        public List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona)
        {
            throw new NotImplementedException();
        }
    }
}
