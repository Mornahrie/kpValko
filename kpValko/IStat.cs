using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpValko
{
    interface IStat
    {
        double Fond { get; set; }
        double Help();
        string Info();
    }
}
