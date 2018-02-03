using System;
namespace LoteriaFederalAPI.Model
{
    public class Lotofacil : IJogoInterface
    {
        public int numeroMinimo { get; set; }
        public int numeroMaximo { get; set; }
        public int numeroSorteio { get; set; }
        public int numeroPossiveis { get; set; }

        public Lotofacil()
        {
            numeroMinimo = 15;
            numeroMaximo = 18;
            numeroSorteio = 15;
            numeroPossiveis = 25;
        }
    }
}
