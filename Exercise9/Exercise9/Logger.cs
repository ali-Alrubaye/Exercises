using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Logger
    {
        private List<string> employe;
        public List<string> LogPosts { get; set; }
        
        //Constructor
        public Logger()
        {
            LogPosts = new List<string>();
        }

        public void Log(string employe)
        {
            LogPosts.Add(employe);
            
        }
    

    }
}
