using System;
using System.Collections.Generic;
using MejoresPracticasDAL.Persona;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Persona;
using NUnit.Framework;
using Spring.Testing.NUnit;
using Util.Entidad;

namespace MejoresPracticasDALTest.Persona
{
    [TestFixture]
    public class PersonaDalTest : AbstractDependencyInjectionSpringContextTests
    {

        private IPersonaDal personaDal;

        public IPersonaDal PersonaDal
        {
            set { personaDal = value; }
        }

        [Test]
        public void ObtenerPersonasTest()
        {
            BeBuscarPersona beBuscarPersona = new BeBuscarPersona();
            beBuscarPersona.NombresApellidos = "Test";

            IList<BePersona> listTest = personaDal.ObtenerPersonas(beBuscarPersona);



        }

        protected override string[] ConfigLocations
        {
            get
            {
                return new String[] { "assembly://MejoresPracticasDALTest/Config/Dal.xml" };
            }
        }
    }
}
