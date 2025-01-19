using Il2Cpp;
using Il2CppTLD.Scenes;
using MelonLoader;
using UnityEngine;

namespace AllRandomLayoutsAtOnce
{
    public class Implementation : MelonMod
    {

        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if(sceneName == "MountainTownRegion_SANDBOX")
            {
                // ---------------   ADD A BUNKER IN MT BASIN  -----------------
                //Didn't succeed because of exit point
                /*
                GameObject bunker = GameObject.Find("Design/RandomSpawners/BunkerHatch_1d_STARTDISABLED");

                bunker.SetActive(true);
                bunker.transform.GetChild(0).gameObject.SetActive(false);
                bunker.transform.GetChild(1).gameObject.SetActive(false);
                bunker.transform.GetChild(2).gameObject.SetActive(false);
                bunker.transform.GetChild(3).gameObject.SetActive(false);*/
            }
        }


    }
}