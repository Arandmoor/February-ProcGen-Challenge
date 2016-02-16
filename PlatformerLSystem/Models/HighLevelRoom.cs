using PlatformerLSystem;
using PlatformerLSystem.Enumerations;
using PlatformerLSystem.Interfaces;
using PlatformerLSystem.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Models
{
    public class HighLevelRoom : IRoom, IPrintable<string>, ISystemObject
    {
        /// <summary>
        /// HighLevelRooms manage their own positions on a grid.
        /// </summary>
        public static IDictionary<GridPos, HighLevelRoom> HighLevelLocDict = new Dictionary<GridPos, HighLevelRoom>(new GridPosEqualityComparer());
        public GridPos position { get; set; }

        public string Type { get; set; }
        private IDictionary<ExitDirection, HighLevelRoom> Exits;

        public HighLevelRoom()
        {
            Type = "O";
            Exits = new Dictionary<ExitDirection, HighLevelRoom>();
            position = new GridPos(0, 0);
            HighLevelLocDict.Add(position, this);
            Register();
        }

        public HighLevelRoom(string type, int x, int y)
        {
            Type = type;
            Exits = new Dictionary<ExitDirection, HighLevelRoom>();
            position = new GridPos(x, y);
            HighLevelLocDict.Add(position, this);
            Register();
        }

        public HighLevelRoom(string type, GridPos pos)
        {
            Type = type;
            Exits = new Dictionary<ExitDirection, HighLevelRoom>();
            position = pos;
            HighLevelLocDict.Add(position, this);
            Register();
        }

        public void AddExit(ExitDirection exit, IRoom destination)
        {
            HighLevelRoom dest = destination as HighLevelRoom;
            if (dest != null)
                Exits[exit] = dest;
            else throw new Exception("Passed destination was not a HighLevelRoom object.");
        }

        public bool HasExit(ExitDirection exit)
        {
            return Exits.ContainsKey(exit);
        }

        public string GetOutput()
        {
            return Type;
        }

        public void Register()
        {
            PRandLSystem.System.Add(this);
        }
    }
}
