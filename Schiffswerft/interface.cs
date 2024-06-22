using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffswerft
{
    public interface IManagement
    {
        string eigentuemer { get; set; }
        string status { get; set; }
    }
}
