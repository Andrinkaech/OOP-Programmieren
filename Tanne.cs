using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Tanne
    {
        int Stammbreite;
        int Stammhoehe;
        int Kronenhoehe;
        string Zeichnung;

        public Tanne (int Stammbreite, int Stammhoehe, int Kronenhoehe, string Zeichnung)
        {
            this.Stammbreite = Stammbreite;
            this.Stammhoehe = Stammhoehe;
            this.Kronenhoehe = Kronenhoehe;
            this.Zeichnung = Zeichnung;
        }
        

    }
}
