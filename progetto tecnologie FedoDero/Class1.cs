using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_tecnologie_FedoDero
{
    internal class Class1
    {
        string alpha = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        public Class1()
        {

        }

        private int Trovanumero(char a)
        {
            foreach (char i in alpha) {
                if (alpha.Contains(a))
                {
                    return alpha.IndexOf(i) + 1;
                }
            }
            return 0;
        }
        
        public void Cripto1(string mess, int n)
        {
            foreach (var i in mess) {
                foreach (var j in alpha) {
                    if (mess[i] == alpha[j])
                    {
                        mess.Replace(mess[i], alpha[j+n]);
                    }
                }
            }
        }

        public void Cripto2(string mess, int n)
        {
            foreach (var i in mess)
            {
                foreach (var j in alpha)
                {
                    if (mess[i] == alpha[j])
                    {
                        mess.Replace(mess[i], alpha[j - n]);
                    }
                }
            }
        }

        public int MoltiLetterale(string mess, int n)
        {
            int sum = 0;

            foreach (var i in mess)
            {
                foreach (var j in alpha)
                {
                    if (mess[i] == alpha[j])
                    {
                        sum += Trovanumero(alpha[i]);
                    }
                }
            }

            return sum * n;
        }
    }
}
