using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyAndroid.RaceData;
using Newtonsoft.Json;

namespace MyAndroid.Activities {
    [Activity(Label = "CharacterCreation")]
    public class CharacterCreationActivity : Activity {
        public const string TAG = "ExampleQuizApp";
        const string RACES_JSON_FILE = "races.json";

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CharacterCreation);
            string json = JsonUtils.LoadJsonFile(this, RACES_JSON_FILE);
            var races = JsonConvert.DeserializeObject<List<Race>>(json);

            var raceNames = races.Select(race => race.RaceName).ToList();

            var raceNamesAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, raceNames);

            raceNamesAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            var raceNamesSpinner = FindViewById<Spinner>(Resource.Id.RacesDropDown);
            raceNamesSpinner.Adapter = raceNamesAdapter;
        }
    }
}