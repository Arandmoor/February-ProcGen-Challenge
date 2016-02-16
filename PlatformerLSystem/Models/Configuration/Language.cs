using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Models.Configuration
{
    /// <summary>
    /// Model of the JSON language files.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Dictionary holding the highrooms language data.
        /// </summary>
        [JsonProperty("highrooms")]
        public IDictionary<string, IList<string>> HighroomsLanguage { get; set; }

        /// <summary>
        /// Load an L-System language from a JSON file.
        /// </summary>
        /// <param name="filename">The file to read.</param>
        /// <returns></returns>
        public static Language Load(string filename)
        {
            if (System.IO.File.Exists(filename.ToString()))
            {
                Console.WriteLine("Reading configuration file @ " + filename);
                return JsonConvert.DeserializeObject<Language>(System.IO.File.ReadAllText(filename));
            }
            else
            {
                Console.WriteLine("No configuration file found.");
                return null;
            }
        }
    }
}
