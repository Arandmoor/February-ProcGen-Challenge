using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Interfaces
{
    public interface IConfigurator
    {
        /// <summary>
        /// Configure the passed room according to the passed configuration code.
        /// </summary>
        /// <param name="room">The room to configure.</param>
        /// <param name="configurationCode">The code to use to configure the room.</param>
        void Configure(IRoom room, string configurationCode);
    }
}
