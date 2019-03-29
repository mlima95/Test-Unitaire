using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ean13Project
{
    public class Ean13
    {
        private int[] ean13;

        public Ean13(int[] ean13)
        {
            // this.ean13 = new int[12];
            //int k = 0;

            // foreach (int i in ean13)
            //{
            //   this.ean13[k] = i;
            // k++;
            //}

            if (ean13.Length != 12)
            {
                throw new Exception("Un code Ean 13 doit être un tableau de 12 entiers");
            }

            foreach (int i in ean13)
            {
                if (i < 0 || i > 9)
                {
                    throw new Exception("Un élément du gencode n'est pas compris entre 0 et 9");
                }
            }
            this.ean13 = new int[13];
            for (int i = 0; i < 12; i++)
            {
                this.ean13[i] = ean13[i];
            }
        }

        public int PoidsPair()
        {
            
            return poids(1) * 3;
        }

        private int poids(int indiceDepart)
        {
            int poids = 0;

            for (int i = indiceDepart; i < 12; i = i + 2)
            {
                poids = poids + this.ean13[i];
            }
            return poids;

        }
        public int PoidsImpair()
        {
            return poids(0);
        }

        public int Reste()
        {
            int pP = PoidsPair();
            int pIP = PoidsImpair();
            int resultat = pP + pIP;
            int reste = resultat % 10;
            return reste;
        }

        public int Cle()
        {
            if (Reste() == 0)
            {
                return 0;
            }

            else
            {
                return 10 - Reste();
            }
        }

        public override string ToString()
        {
            string s = string.Format("{0}{1}{2}{3}-{4}{5}{6}{7}-{8}{9}{10}{11}-{12}", ean13[0], ean13[1], ean13[2], ean13[3], ean13[4], ean13[5], ean13[6], ean13[7], ean13[8], ean13[9], ean13[10], ean13[11], Cle());
            return s;
        }

    }
}
