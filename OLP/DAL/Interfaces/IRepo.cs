using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Class,Ret,Type>
    {
        List<Class> viewAll();
        Class view(Type id);
        Ret create(Class obj);
        Ret update(Class obj);
        bool delete(Type id);
    }
}
