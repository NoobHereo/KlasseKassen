using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseKasse.Database
{
    class Database
    {
        public void RegisterKonto(string navn, string kodeord)
        {
            System.IO.File.WriteAllText(@"C:\Users\PC\Desktop\KlasseKassen\KlasseKasse\KlasseKasse\Database\data\Kontoer\" + navn + ".txt", "");
            using (System.IO.StreamWriter kontoOplysninger = new System.IO.StreamWriter(@"C:\Users\PC\Desktop\KlasseKassen\KlasseKasse\KlasseKasse\Database\data\Kontoer\" + navn + ".txt"))
            {
                kontoOplysninger.WriteLine("Konto brugernavn: " + navn);
                kontoOplysninger.WriteLine("Konto kodeord: " + kodeord);
                kontoOplysninger.WriteLine("Registreret ved: " + DateTime.Now());
            }
        }


    }
}
