using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public interface IAreaCalculatableCreator
    {
        string GetFigureName();
        /// <summary>
        /// Creates cpecified figure.
        /// </summary>
        /// <returns>returns <see cref="Area.IAreaCalculatable"/> describing specified figure</returns>
        /// <exception cref="ArgumentException"/>
        IAreaCalculatable CreateAreaCalculatable();
    }
}
