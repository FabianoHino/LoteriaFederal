using System;
namespace LoteriaFederalAPI.Model
{
    public interface IJogoInterface
    {
        int numeroMinimo
        {
            get;
            set;
        }
        int numeroMaximo
        {
            get;
            set;
        }
        int numeroSorteio
        {
            get;
            set;
        }
        int numeroPossiveis
        {
            get;
            set;
        }
    }
}
