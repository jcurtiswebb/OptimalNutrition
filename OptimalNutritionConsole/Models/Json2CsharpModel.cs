using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalNutritionConsole.Models
{
    public class Desc
    {
        public string ndbno { get; set; }
        public string name { get; set; }
        public string ds { get; set; }
        public string manu { get; set; }
        public string ru { get; set; }
    }

    public class Nutrient
    {
        public string nutrient_id { get; set; }
        public string name { get; set; }
        public string derivation { get; set; }
        public string group { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
        public List<object> measures { get; set; }
    }

    public class Food2
    {
        public string sr { get; set; }
        public string type { get; set; }
        public Desc desc { get; set; }
        public List<Nutrient> nutrients { get; set; }
        public List<object> footnotes { get; set; }
    }

    public class Food
    {
        public Food2 food { get; set; }
        public string error { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("foods")]
        public List<Food> foods { get; set; }
        public int count { get; set; }
        public int notfound { get; set; }
        public double api { get; set; }
    }
}
