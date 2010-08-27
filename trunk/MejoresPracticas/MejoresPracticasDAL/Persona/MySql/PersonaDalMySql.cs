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
            get { return _adoTemplate; }
            set { _adoTemplate = value; }
        }

        private static readonly ILog Log = LogManager.GetLogger(typeof(PersonaDalMySql));


        public List<BePersona> ObtenerPersonas(BeBuscarPersona beBuscarPersona)
        {
            
            //CommandType.StoredProcedure
            //List<BePersona> lista;
            IDbParameters dbParameters = AdoTemplate.CreateDbParameters();
            dbParameters.Add(PNombApe, MySqlDbType.VarChar, 100).Value = beBuscarPersona.NombresApellidos;
            //Para Parametros de Salida
            //dbParameters.AddOut("ShipperID", SqlDbType.Int);
            //AdoTemplate.QueryWithRowMapper()
            //List<BePersona> lista = AdoTemplate.QueryWithRowMapper(CommandType.StoredProcedure, ConstanteDal.SpObtenerPersonas,
             //                                                      new PersonaRowMapper(),
                //                                                   dbParameters) as List<BePersona>;
            /*IList list = AdoTemplate.QueryWithRowMapper(CommandType.StoredProcedure, ConstanteDal.SpObtenerPersonas,
                                                                   new PersonaRowMapper(),
                                                                   dbParameters);*/

            return Herramienta.ConvertToListOf<BePersona>(AdoTemplate.QueryWithRowMapper(CommandType.StoredProcedure, ConstanteDal.SpObtenerPersonas,
                                                                   new PersonaRowMapper(),
                                                                   dbParameters)) as List<BePersona>;
            
           
        }
    }
}
