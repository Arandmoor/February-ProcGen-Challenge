using PlatformerLSystem.Enumerations;
using PlatformerLSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Models.Configuration
{
    public class HighLevelRoomConfigurator : IConfigurator
    {
        public void Configure(IRoom roomObj, string configurationCode)
        {
            HighLevelRoom room = roomObj as HighLevelRoom;

            if (room != null) {
                switch (configurationCode)
                {
                    case "O":
                        break;
                    case ">":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        break;
                    case "^":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        break;
                    case "v":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        break;
                    case "<":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                    case "I":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        break;
                    case "-":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));
                        break;
                    case "L":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        break;
                    case "r":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        break;
                    case "7":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));
                        
                        break;
                    case "J":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                    case "N":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                    case "S":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                    case "E":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                    case "W":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        break;
                    case "X":
                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.North))
                            roomObj.AddExit(ExitDirection.NORTH, HighLevelRoom.HighLevelLocDict[room.position.North]);
                        else roomObj.AddExit(ExitDirection.NORTH, new HighLevelRoom("v", room.position.North));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.South))
                            roomObj.AddExit(ExitDirection.SOUTH, HighLevelRoom.HighLevelLocDict[room.position.South]);
                        else roomObj.AddExit(ExitDirection.SOUTH, new HighLevelRoom("^", room.position.South));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.East))
                            roomObj.AddExit(ExitDirection.EAST, HighLevelRoom.HighLevelLocDict[room.position.East]);
                        else roomObj.AddExit(ExitDirection.EAST, new HighLevelRoom("<", room.position.East));

                        if (HighLevelRoom.HighLevelLocDict.ContainsKey(room.position.West))
                            roomObj.AddExit(ExitDirection.WEST, HighLevelRoom.HighLevelLocDict[room.position.West]);
                        else roomObj.AddExit(ExitDirection.WEST, new HighLevelRoom(">", room.position.West));

                        break;
                }
            }
        }
    }
}
