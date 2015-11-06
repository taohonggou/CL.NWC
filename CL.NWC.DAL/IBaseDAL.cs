using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.NWC.DAL
{
   public  interface IBaseDAL<T> where T:class
    {
       bool Add(T t);

    }
}
