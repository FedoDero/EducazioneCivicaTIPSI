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
        
        public void cripto1(string mess, int n)
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
    }
}
