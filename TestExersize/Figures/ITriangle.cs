﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public interface ITriangle : IFigure
    {
        bool CheckRightTriangle();
    }
}
