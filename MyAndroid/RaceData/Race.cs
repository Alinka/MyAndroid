using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyAndroid.RaceData {
    public enum Ability {
        STR,
        DEX,
        CON,
        INT,
        WIS,
        CHA
    }

    public class AbilityScoreBonus {
        public string Description { get; set; }
        [JsonProperty(PropertyName = "ability_score_incr")]
        public List<int> AbilityScoreIncr { get; set; }
    }

    public enum Skill {
        Acrobatics,
        Arcana,
        Athletics,
        Bluff,
        Diplomacy,
        Dungeoneering,
        Endurance,
        Heal,
        History,
        Insight,
        Intimidate,
        Nature,
        Perception,
        Religion,
        Stealth,
        Streetwise,
        Thievery
    }

    public class SkillBonus {
        public string Description { get; set; }
        [JsonProperty(PropertyName = "skill_bonus_incr")]
        public List<int> SkillBonusIncr { get; set; }
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