using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSGOConfigBuilder
{
    class CreateNewTextFile
    {
        public string WriteText()
        {
            string labelMsg = "//Inserted by generator";
            StreamWriter ae = new StreamWriter("C:\\Users\\James\\Desktop\\testing\\autoexec.txt", true);
            ae.WriteLine("{0}", labelMsg);
            ae.WriteLine("alias \"+jumpthrow\" \"+jump;-attack");
            ae.WriteLine("alias \"-jumpthrow\" \"-jump\"");
            ae.WriteLine("bind \"z\" \"+jumpthrow\"");

            ae.Close();

            return ("Completed");

            /*
           alias "+jumpthrow" "+jump;-attack"
alias "-jumpthrow" "-jump"
bind "z" "+jumpthrow"
            */
        }
    }
}
