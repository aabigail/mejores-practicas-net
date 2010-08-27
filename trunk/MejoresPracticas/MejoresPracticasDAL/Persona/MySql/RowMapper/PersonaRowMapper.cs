using System;
using System.Data;
using Model.Persona;
using Spring.Data;

namespace MejoresPracticasDAL.Persona.MySql.RowMapper
{
    public class PersonaRowMapper : IRowMapper
    {
        private const string Codigo = "Codigo";
        private const string Descripcion = "Descripcion";
        private const string Nombres = "Nombres";
        private const string Apellidos = "Apellidos";

        public object MapRow(IDataReader reader, int rowNum)
        {
            BePersona bePersona = new BePersona();
            bePersona.Codigo = reader[Codigo].ToString();
            bePersona.Descripcion = reader[Descripcion].ToString();
            bePersona.Nombres = reader[Nombres].ToString();
            bePersona.Apellidos = reader[Apellidos].ToString();
            return bePersona;
        }
    }
}
