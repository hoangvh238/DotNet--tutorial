using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp
{
    public class SessionManager
    {
        private static SessionManager instance;
        public static SessionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionManager();
                }
                return instance;
            }
        }

        private Dictionary<string, object> sessionData = new Dictionary<string, object>();

        public void Set(string key, object value)
        {
            sessionData[key] = value;
        }

        public object Get(string key)
        {
            if (sessionData.ContainsKey(key))
            {
                return sessionData[key];
            }
            return null;
        }
    }

}
