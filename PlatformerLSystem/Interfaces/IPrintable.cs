using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Interfaces
{
    public interface IPrintable<T>
    {
        /// <summary>
        /// Gets output for the room.
        /// </summary>
        /// <returns>Output in some form.</returns>
        T GetOutput();
    }
}
