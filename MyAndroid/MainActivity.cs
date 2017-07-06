using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Java.Util;
using MyAndroid.RaceData;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MyAndroid.Activities;

namespace MyAndroid {
    [Activity(Label = "My D&D Helper", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo")]
    public class MainActivity : Activity {
        public MainActivity() {
         
        }

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.ButtonCreateNewCharacter);
            button.Click += ButtonCreateNewCharacterOnClick;


        }

        private void ButtonCreateNewCharacterOnClick(object sender, EventArgs eventArgs)
        {
            StartActivity(typeof(CharacterCreationActivity));
        }
    }
}

