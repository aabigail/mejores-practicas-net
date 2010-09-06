using System.Collections.Generic;
using System.Data;
using log4net;
using MejoresPracticasDAL.Persona.MySql.RowMapper;
using Model.Persona;
using MySql.Data.MySqlClient;
using Spring.Data.Common;
using Spring.Data.Core;
using Util.Constante;
using Util.Entidad;
using Util.Herramientas;

namespace MejoresPracticasDAL.Persona.MySql
{
    public class PersonaDalMySql : IPersonaDal
    {

        private AdoTemplate _adoTemplate;
        private const string PNombApe = "P_NOMB_APE";

        public AdoTemplate AdoTemplate
        {
            private get { return _adoTemplate; }
            set { _adoTemplate = value; }
        }

        private static readonly ILog Log = LogManager.GetLogger(typeof(PersonaDalMySql));


        public List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona)
        {
            
            IDbParameters dbParameters = AdoTemplate.CreateDbParameters();
            dbParameters.Add(PNombApe, MySqlDbType.VarChar, 100).Value = beBuscarPersona.NombresApellidos;
            
            return Herramienta.ConvertToListOf<BePersona>(
                AdoTemplate.QueryWithRowMapper(CommandType.StoredProcedure, ConstanteDal.SpObtenerPersonas,
                                                                   new PersonaRowMapper(),
                                                                   dbParameters)) as List<BePersona>;
        }
    }
}
