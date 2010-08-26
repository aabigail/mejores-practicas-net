using System;
using System.Collections.Generic;
using log4net;
using MejoresPracticasBLL.Persona;
using Model.Persona;
using Spring.Context.Support;
using Util.Entidad;

namespace MejoresPracticasWeb.Persona
{
    public partial class BuscarPersona : System.Web.UI.Page
    {

        private readonly IPersonaBll personaBll;
        private static readonly ILog Log = LogManager.GetLogger(typeof(BuscarPersona));

        public BuscarPersona()
        {
            if(Log.IsDebugEnabled)
            {
                Log.Debug("Constructor de BuscarPersona");
            }
            personaBll = ContextRegistry.GetContext().GetObject("PersonaBll") as IPersonaBll;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            if (Log.IsDebugEnabled)
            {
                Log.Debug("Evento Buscar");
            }
            
            string nombresApellidos = txtNombresApellidos.Text;
            string mensaje = string.Empty;
            if (string.Empty.Equals(nombresApellidos))
            {
                mensaje = "Ingresar nombres y apellidos.";
            }else{
                if (personaBll != null)
                {
                    BeBuscarPersona beBuscarPersona = new BeBuscarPersona();
                    beBuscarPersona.NombresApellidos = nombresApellidos;
                    List<BePersona> lista = personaBll.ObtenerPersonas(beBuscarPersona);
                    if(lista.Count > 0)
                    {
                        gvPersonas.DataSource = lista;
                        gvPersonas.DataBind();
                        
                        mensaje = string.Format("{0} registros encontrados", lista.Count);
                    }else
                    {
                        mensaje = "No se encontro ningun registro.";
                    }
                }else
                {
                    mensaje = "Error al cargar Spring.";
                }
            }

            lblMensaje.Text = mensaje;

        }
    }
}
