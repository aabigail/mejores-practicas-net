using System.Collections.Generic;
using Model.Persona;
using Util.Entidad;

namespace MejoresPracticasBLL.Persona
{
    public interface IPersonaBll
    {
        List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona);
    }
}
