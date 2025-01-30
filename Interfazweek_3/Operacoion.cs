
namespace Interfazweek_3
{
    public class Operacoion : IOperacion, IArea
    {
        public double N1 { get; set; };
        public double N2 { get; set; };

        double IOperacion.Division()
        {
            throw new NotImplementedException();
        }

        double IOperacion.Multiplicacion()
        {
            throw new NotImplementedException();
        }

        double IOperacion.Resta()
        {
            throw new NotImplementedException();
        }

        double IOperacion.Suma()
        {
            throw new NotImplementedException();
        }
    }
}
