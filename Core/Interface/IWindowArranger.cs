using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IWindowArranger
    {
        /// <summary>
        /// Sắp xếp các tab game
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        void ArrangeWindows(int rows, int columns);
    }
}
