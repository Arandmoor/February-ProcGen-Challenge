using PlatformerLSystem.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Interfaces
{
    public interface IRoom
    {
        /// <summary>
        /// The type of the room.
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Add an exit to the room.
        /// </summary>
        /// <param name="exit">The exit direction.</param>
        /// <param name="destination">The exit destination.</param>
        void AddExit(ExitDirection exit, IRoom destination);

        /// <summary>
        /// Checks the room for an exit.
        /// </summary>
        /// <param name="exit">The direction to check.</param>
        /// <returns>True if exists.</returns>
        bool HasExit(ExitDirection exit);
    }
}
