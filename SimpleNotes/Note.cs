using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleNotes
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class Note
    {
        [JsonProperty]
        public String title;
        [JsonProperty]
        public String description;
        [JsonProperty]
        public DateTime dateOfCreation;
        [JsonProperty]
        public DateTime time;
        public Note()
        {
            title = "Новая заметка";
            description = "Описание отсутсвует";
            dateOfCreation = DateTime.Now;
            time = DateTime.Now;
        }
        public Note(String title, String description)
        {
            this.title = title;
            this.description = description;
            dateOfCreation = DateTime.Now;
        }
        public Note(String title, String description, DateTime time)
        {
            this.title = title;
            this.description = description;
            this.time = time;
            dateOfCreation = DateTime.Now;
        }
        public String Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public static Note Deserialize(String str)
        {
            return JsonConvert.DeserializeObject<Note>(str);
        }
        public override int GetHashCode()
        {
            return new
            {
                title,
                description,
                dateOfCreation,
                time
            }.GetHashCode();
        }
    }
}
