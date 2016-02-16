using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Interfaces
{
    public interface ISystemObject
    {
        /// <summary>
        /// Register the object with the LSystem for processing.
        /// </summary>
        void Register();
    }
}
