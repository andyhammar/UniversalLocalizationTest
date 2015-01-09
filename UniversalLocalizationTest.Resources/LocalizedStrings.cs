using Windows.ApplicationModel.Resources;

namespace UniversalLocalizationTest.Resources
{
    public class LocalizedStrings
    {
        public static string Get(string key)
        {
            return ResourceLoader.GetForCurrentView().GetString(key);
        }
    }
}
