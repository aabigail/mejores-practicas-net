using System.Collections;
using System.Collections.Generic;
using log4net;

namespace Util.Herramientas
{
    public static class Herramienta
    {

        private static readonly ILog Log = LogManager.GetLogger(typeof(Herramienta));

        public static IList<T> ConvertToListOf<T>(IList iList)
        {
            IList<T> result = new List<T>();
            foreach (T value in iList)
            {
                result.Add(value);
            }
                

            return result;
        }

    }
}
