using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_2
{
    public interface ICalculatingFigureProperties
    {
        double Perimeter { get; }
        double Square();
    }
}
