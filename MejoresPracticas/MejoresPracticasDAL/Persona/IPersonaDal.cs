using System.Collections.Generic;
using Model.Persona;
using Util.Entidad;

namespace MejoresPracticasDAL.Persona
{
    public interface IPersonaDal
    {
        List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona);
    }
}
