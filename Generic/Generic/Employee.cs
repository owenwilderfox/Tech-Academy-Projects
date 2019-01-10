using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee<T>
    {
        List<T> Things { get; set; }
    }
}
