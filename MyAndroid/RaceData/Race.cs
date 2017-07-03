using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyAndroid.RaceData
{
    public class AbilityScoreIncr {
        public int Any { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }

    public class AbilityScoreBonus {
        public string Description { get; set; }
        [JsonProperty(PropertyName = "ability_score_incr")]
        public AbilityScoreIncr AbilityScoreIncr { get; set; }
    }

    public class SkillBonusIncr {
        public int Acrobatics { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Bluff { get; set; }
        public int Diplomacy { get; set; }
        public int Dungeoneering { get; set; }
        public int Endurance { get; set; }
        public int Heal { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidate { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Religion { get; set; }
        public int Stealth { get; set; }
        public int Streetwise { get; set; }
        public int Thievery { get; set; }
    }

    public class SkillBonus {
        public string Description { get; set; }
        [JsonProperty(PropertyName = "skill_bonus_incr")]
        public SkillBonusIncr SkillBonusIncr { get; set; }
    }

    public class RacialPower {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Race {
        [JsonProperty(PropertyName = "race_name")]
        public string RaceName { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        [JsonProperty(PropertyName = "ability_score_bonus")]
        public AbilityScoreBonus AbilityScoreBonus { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        public string Vision { get; set; }
        public List<string> Languages { get; set; }
        [JsonProperty(PropertyName = "skill_bonus")]
        public SkillBonus SkillBonus { get; set; }
        [JsonProperty(PropertyName = "racial_power")]
        public RacialPower RacialPower { get; set; }
        public List<string> Traits { get; set; }
    }
}