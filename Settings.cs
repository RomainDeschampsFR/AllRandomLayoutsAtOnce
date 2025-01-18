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
        [Name("All buildings")]
        [Description("All vanilla lootable buildings will be active (instead of there burnt version)")]
        public bool buildingEnabled = true;

        [Name("All fishing hut doors")]
        [Description("All vanilla door for fishing huts will be active")]
        public bool doorEnabled = true;

        [Name("All bear caves")]
        [Description("All bear caves will be active (With bones in it)")]
        public bool bearEnabled = true;

        [Name("All moose areas")]
        [Description("All moose areas will be active (With scratch on trees)")]
        public bool mooseEnabled = true;

        [Name("All snow shelters and campfires")]
        [Description("All snow shelters and campfires will be active")]
        public bool snowShelterEnabled = true;

        [Name("All signal fires in HRV")]
        [Description("Both signal fires in HRV will be active")]
        public bool signalEnabled = true;
    }
}
