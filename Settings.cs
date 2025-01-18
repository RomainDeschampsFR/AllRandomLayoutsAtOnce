using ModSettings;
using System.Reflection;

namespace AllRandomLayoutsAtOnce
{
    internal static class Settings
    {
        internal static AllRandomLayoutsAtOnceSettings settings = new();

        internal static void OnLoad()
        {
            settings.AddToModSettings("All Random Layouts At Once");
            settings.RefreshGUI();
        }
    }

    internal class AllRandomLayoutsAtOnceSettings : JsonModSettings
    {
        [Name("Enable all buildings")]
        [Description("All vanilla lootable building will be active (instead of there burnt version)")]
        public bool buildingEnabled = true;

        [Name("Enable all fishing hut doors")]
        [Description("All vanilla door for fishing huts will be active")]
        public bool doorEnabled = true;

        [Name("Enable all bear caves")]
        [Description("All bear cave will be active (With bones in it)")]
        public bool bearEnabled = true;

        [Name("Enable all moose area")]
        [Description("All moose area will be active (With scratch on trees)")]
        public bool mooseEnabled = true;

        [Name("Enable all snow shelters camps")]
        [Description("All snow shelter camps will be active")]
        public bool snowShelterEnabled = true;

        [Name("Enable all signal fires in HRV")]
        [Description("Both signal fires in HRV will be active")]
        public bool signalEnabled = true;
    }
}
