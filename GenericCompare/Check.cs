using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCompare
{
    public class Check<Unknown>
    {
        public bool Compare(Unknown t1, Unknown t2)
        {
            if (t1.Equals(t2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class CheckNumbers : Check<int>
    {
        
            
    }

    public class CheckString : Check<string>
    { 
        
    
    }

}
