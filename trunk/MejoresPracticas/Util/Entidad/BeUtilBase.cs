using PrintProperties.MGLHPM;

namespace Util.Entidad
{
    public abstract class BeUtilBase
    {
        private static readonly Print Print = new Print();

        public override string ToString()
        {
            return Print.WriteEntity(this);
        }

    }
}
