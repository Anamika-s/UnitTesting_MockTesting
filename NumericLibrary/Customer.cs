//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NumericLibrary
//{
//    public class EMail
//    {
//        public bool SendEmail()
//        {
//            // some logic will be here
//            return false;
//        }
//    }
//    public class Customer
//    {
//        public bool AddCustomer()
//        {
//            EMail obj = new EMail();
//            obj.SendEmail();
//            // Some code of ADO.Net will go here
//            return true;
//        }
//    }

//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
    public class EMail
    {
        public virtual bool SendEmail()
        {
            // some logic will be here
            return false;
        }
    }
    public class Customer
    {
        public  virtual  bool AddCustomer(EMail obj)
        {
            //EMail obj = new EMail();
            obj.SendEmail();


            // Some code of ADO.Net will go here
            return true;
        }
    }

}

