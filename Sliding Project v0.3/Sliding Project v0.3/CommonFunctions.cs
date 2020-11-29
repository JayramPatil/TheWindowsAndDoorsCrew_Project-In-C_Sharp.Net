using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Project_v0._3
{
    public class CommonFunctions
    { 
        public int Show_ID()
        {
            using (CrewEntities DB = new CrewEntities())
            {
                /*var ID = DB.Customers.SqlQuery("select max(Customer_ID) from Customer");
                if (ID > 0)
                {
                    return ID;
                }*/
                return 1;
            }
        }
    }
}
