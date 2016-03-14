using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
   public class Logger: ILogger
    {
        private List<string> LogPosts;

         List<string> ILogger.LogPosts
        {
            get
            {
                return LogPosts;
            }
        } 
        //Constructor
        public Logger()
        {
            LogPosts = new List<string>();
        }

       

        public void Log(string message)
        {
            LogPosts.Add(message);
            
        }   

    }
}
