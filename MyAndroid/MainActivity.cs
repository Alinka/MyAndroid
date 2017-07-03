using Android.App;
using Android.OS;
using Android.Widget;
using Java.Util;
using MyAndroid.RaceData;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MyAndroid {
    [Activity(Label = "MyAndroid", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo")]
    public class MainActivity : Activity {
        public const string TAG = "ExampleQuizApp";
        const string RACES_JSON_FILE = "races.json";
        public MainActivity() {
         
        }

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
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

