using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using MyAndroid.RaceData;
using Newtonsoft.Json;

namespace MyAndroid.Activities {
    [Activity(Label = "CharacterCreation")]
    public class CharacterCreationActivity : Activity {
        public const string TAG = "ExampleQuizApp";
        const string RACES_JSON_FILE = "races.json";
        public List<Race> races;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CharacterCreation);
            string json = JsonUtils.LoadJsonFile(this, RACES_JSON_FILE);
            races = JsonConvert.DeserializeObject<List<Race>>(json);

            var raceNames = races.Select(race => race.RaceName).ToList();

            var raceNamesAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, raceNames);

            raceNamesAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            var raceNamesSpinner = FindViewById<Spinner>(Resource.Id.RacesDropDown);
            raceNamesSpinner.Adapter = raceNamesAdapter;
            raceNamesSpinner.ItemSelected += RaceNamesSpinnerOnItemSelected;
            var result = raceNamesSpinner.SelectedItem.ToString();
            var raceSelected = races.FirstOrDefault(race => race.RaceName == result);
            ShowDetails(raceSelected);
        }

        private void RaceNamesSpinnerOnItemSelected(object sender, AdapterView.ItemSelectedEventArgs e) {
            var spinner = (Spinner)sender;
            var str = spinner.SelectedItem.ToString();
            var raceSelected = races.FirstOrDefault(race => race.RaceName == str);
            ShowDetails(raceSelected);
        }



        private void ShowDetails(Race raceSelected)
        {
            FindViewById<TextView>(Resource.Id.RaceDescription).Text = !string.IsNullOrEmpty(raceSelected.Description)
                ? raceSelected.Description
                : "";
            FindViewById<TextView>(Resource.Id.RaceHeight).Text = !string.IsNullOrEmpty(raceSelected.Height)
                ? $"Height: {raceSelected.Height}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceWeight).Text = !string.IsNullOrEmpty(raceSelected.Weight)
                ? $"Weight: {raceSelected.Weight}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceAbilityScoreBonus).Text = raceSelected.AbilityScoreBonus != null
                ? $"Ability Scores: {raceSelected.AbilityScoreBonus.Description}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceSize).Text = !string.IsNullOrEmpty(raceSelected.Size)
                ? $"Size: {raceSelected.Size}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceSpeed).Text = !string.IsNullOrEmpty(raceSelected.Speed)
                ? $"Speed: {raceSelected.Speed}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceVision).Text = !string.IsNullOrEmpty(raceSelected.Vision)
                ? $"Vision: {raceSelected.Vision}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceLanguages).Text = raceSelected.Languages.Any()
                ? $"Languages: {string.Join(",", raceSelected.Languages)}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceSkillBonus).Text = raceSelected.SkillBonus != null
                ? $"Skill Bonuses: {raceSelected.SkillBonus.Description}"
                : "";
            FindViewById<TextView>(Resource.Id.RacePower).Text = raceSelected.RacialPower != null
                ? $"Racial Power: \n{raceSelected.RacialPower.Name}: {raceSelected.RacialPower.Description}"
                : "";
            FindViewById<TextView>(Resource.Id.RaceTraits).Text = raceSelected.Traits.Any()
                ? $"Traits: {string.Join(",", raceSelected.Traits)}"
                : "";
        }
    }
}