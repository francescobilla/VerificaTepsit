using System;

namespace Operazoni
{
    public class Gestione
    {
        public static string TariffaConveniente(int giorni)
        {
            string mese1 = "si consiglia un mese";
            string mese3 = "si consiglia 3 mesi";
            string mese12 = "si consiglia 12 mesi";
            if (giorni <= 60)
            {
                return mese1;
            }
            if (giorni >=61 && giorni <=90)
            {
                return mese3;
            }
            if (giorni >= 91 && giorni <= 150)
            {
                return mese1;
            }
            if (giorni >= 151 && giorni <= 209)
            {
                return mese3;
            }
            if (giorni >= 210 && giorni <= 239)
            {
                return mese1;
            }
            if (giorni >= 240 && giorni <= 270)
            {
                return mese3;
            }
            if (giorni >271)
            {
                return mese12;
            }
            return "errore valore inserito non previsto";
        }
    }
}
