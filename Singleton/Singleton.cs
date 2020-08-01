using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        //constructor should alwasy be private
        private Singleton()
        { 
        }

        public static Singleton Instance()
        {
            //use lazy initialization
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
