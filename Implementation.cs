using MelonLoader;

namespace AllRandomLayoutsAtOnce
{
    public class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }
    }
}