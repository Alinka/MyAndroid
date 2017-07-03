using System.Collections.Generic;
using System.IO;
using Android.Content;
using Org.Json;
using MyAndroid.RaceData;

namespace MyAndroid {
    public class JsonUtils {

        public JsonUtils(){
        }

        public static string LoadJsonFile(Context context, string fileName) {
            var stream = context.Assets.Open(fileName);
            var sr = new StreamReader(stream);
            var data = sr.ReadToEnd();
            stream.Close();
            return data;
        }
    }
}