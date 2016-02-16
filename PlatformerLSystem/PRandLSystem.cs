using PlatformerLSystem.Interfaces;
using PlatformerLSystem.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem
{
    public class PRandLSystem
    {
        private Language Language { get; set; }
        private Random rand = new Random();

        public static IList<IRoom> System = new List<IRoom>();

        public PRandLSystem(string langFilePath)
        {
            Language = Language.Load(langFilePath);
        }

        public void ProcessSystem()
        {
            for (int i = 0; i < System.Count; i++)
            {
                if (Language.HighroomsLanguage.ContainsKey(System[i].Type))
                    System[i].Type = Language.HighroomsLanguage[System[i].Type][rand.Next(Language.HighroomsLanguage[System[i].Type].Count)];
            }
        }
    }
}
