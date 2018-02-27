using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookARoomServiceApp.DAL
{
    interface IDal<T> where T: class
    {
        List<T> GetEntities();
    }
}
