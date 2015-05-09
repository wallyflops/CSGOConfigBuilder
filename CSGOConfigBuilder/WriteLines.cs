using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace CSGOConfigBuilder
{
    class CreateNewTextFile
    {
        public string WriteText(string configFile, string keyToBind, bool includeJumpThrowBind)
        {
            if (includeJumpThrowBind)
            {
                string labelMsg = "//Jump throw bind";
                //TODO make an exception handler for this if it doesn't recieve a configFile
                StreamWriter ae = new StreamWriter(configFile, true);
                ae.WriteLine("{0}", labelMsg);
                ae.WriteLine("alias \"+jumpthrow\" \"+jump;-attack");
                ae.WriteLine("alias \"-jumpthrow\" \"-jump\"");
                ae.WriteLine("bind \"{0}\" \"+jumpthrow\"", keyToBind);
                ae.Close();
            }
            
            return ("Completed");

        }
    }
}
