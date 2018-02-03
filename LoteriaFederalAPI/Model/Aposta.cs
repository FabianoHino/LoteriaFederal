using System;
namespace LoteriaFederalAPI.Model
{
    public class Aposta
    {
        public int Id
        {
            get;
            set;
        }

        public int[] Numeros
        {
            get;
            set;
        }

        public string Data
        {
            get;
            set;
        }
    }
}
