using System;
namespace LoteriaFederalAPI.Model
{
    public class MegaSena : IJogoInterface
    {
        public int numeroMinimo { get; set; }
        public int numeroMaximo { get; set; }
        public int numeroSorteio { get; set; }
        public int numeroPossiveis { get; set; }

        public MegaSena()
        {
            numeroMinimo = 6;
            numeroMaximo = 15;
            numeroSorteio = 6;
            numeroPossiveis = 60;
        }
    }
}
