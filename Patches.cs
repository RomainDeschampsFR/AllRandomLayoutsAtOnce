using Il2Cpp;
using HarmonyLib;
using MelonLoader;

namespace AllRandomLayoutsAtOnce
{
    internal class Patches
    {

        [HarmonyPatch(typeof(DisableObjectForXPMode), nameof(DisableObjectForXPMode.ShouldDisableForCurrentMode))]
        internal class DisableObjectForXPMode_ShouldDisableForCurrentMode
        {
            private static void Postfix(DisableObjectForXPMode __instance, ref bool __result)
            {
                // ---------------   3 BUILDINGS IN COASTAL HIGHWAY DISABLED IN INTERLOPER/MISERY   -----------------
                if (__result == true)
                {
                    if (__instance.name.Contains("STRSPAWN") && Settings.settings.buildingEnabled)
                    {
                        __result = false;
                    }
                }
            }
        }

        [HarmonyPatch(typeof(EnableObjectForXPMode), nameof(EnableObjectForXPMode.ShouldDisableForCurrentMode))]
        internal class EnableObjectForXPMode_ShouldDisableForCurrentMode
        {
            private static void Postfix(EnableObjectForXPMode __instance, ref bool __result)
            {
                // ---------------   ALL MEMENTOS   -----------------
                // NON PERSISTENT WITH SETTINGS CHANGES
                if (__result == true)
                {
                    if (__instance.name.ToUpperInvariant().Contains("VISORNOTE") && Settings.settings.mementosEnabled)
                    {
                        __result = false;
                    }
                    if (__instance.name.ToUpperInvariant().Contains("KEY") && Settings.settings.mementosEnabled)
                    {
                        __result = false;
                    }
                }
            }
        }

        [HarmonyPatch(typeof(LoadScene), nameof(LoadScene.Start))]
        internal class LoadScene_Start
        {
            private static void Postfix(LoadScene __instance)
            {
                if (__instance.gameObject.transform.GetParent().GetParent().name == "STRSPAWN_HouseExteriorDMilton_Prefab")
                {
                    __instance.m_SceneCanBeInstanced = true;
                }
            }
        }

        [HarmonyPatch(typeof(LoadScene), nameof(LoadScene.GetSceneToLoad))]
        internal class LoadScene_GetSceneToLoad
        {
            private static void Postfix(LoadScene __instance, ref string __result)
            {
                // ---------------   ALL PREPPER CACHE FULL   -----------------
                if (__instance.m_SceneToLoad.Contains("PrepperCache") && Settings.settings.cacheEnabled)
                {
                    __result = __result.Substring(0, 13);
                }
            }
        }

        [HarmonyPatch(typeof(RandomSpawnObject), nameof(RandomSpawnObject.ActivateRandomObject))]
        internal class RandomSpawnObject_ActivateRandomObject
        {
            internal static bool Prefix(RandomSpawnObject __instance)
            {
                if (__instance.m_RerollAfterGameHours == 0)
                {
                    string regionName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

                    // ---------------   ALL BUILDINGS AND ALL POSSIBLE DOORS FOR FISHING HUTS  -----------------

                    if (regionName == "MountainTownRegion" && __instance.transform.GetParent().name == "Houses_Random" && Settings.settings.buildingEnabled)
                    {
                        __instance.m_ObjectList[0].gameObject.SetActive(true);
                        __instance.m_ObjectList[1].gameObject.SetActive(true);
                        __instance.m_ObjectList[2].gameObject.SetActive(true);

                        __instance.m_ObjectList[0].transform.GetChild(2).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(4).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(9).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(11).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(13).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(15).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(16).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(17).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(18).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(19).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(20).gameObject.SetActive(false);
                        __instance.m_ObjectList[0].transform.GetChild(21).gameObject.SetActive(false);

                        __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(3).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(5).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(7).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(8).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(10).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(12).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(13).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(14).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(17).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(18).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(19).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(20).gameObject.SetActive(false);
                        __instance.m_ObjectList[1].transform.GetChild(21).gameObject.SetActive(false);

                        __instance.m_ObjectList[2].transform.GetChild(0).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(4).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(6).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(8).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(9).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(10).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(11).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(12).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(13).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(14).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(15).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(16).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(17).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(18).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(19).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(20).gameObject.SetActive(false);
                        __instance.m_ObjectList[2].transform.GetChild(21).gameObject.SetActive(false);
                        return false;
                    }
                    else if (__instance.m_OldSaveObject != null)
                    {
                        if (__instance.m_OldSaveObject.name == "FishHuts_oldsave" && Settings.settings.doorEnabled)
                        {
                            if (regionName == "LakeRegion")
                            {
                                __instance.m_ObjectList[0].gameObject.SetActive(true);
                                __instance.m_ObjectList[1].gameObject.SetActive(true);
                                __instance.m_ObjectList[2].gameObject.SetActive(true);

                                __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(2).gameObject.SetActive(false);

                                __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(2).gameObject.SetActive(false);

                                __instance.m_ObjectList[2].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(1).gameObject.SetActive(false);

                                return false;
                            }
                            else if (regionName == "CoastalRegion")
                            {
                                __instance.m_ObjectList[0].gameObject.SetActive(true);
                                __instance.m_ObjectList[1].gameObject.SetActive(true);
                                __instance.m_ObjectList[2].gameObject.SetActive(true);
                                __instance.m_ObjectList[3].gameObject.SetActive(true);

                                __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(4).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(5).gameObject.SetActive(false);
                                __instance.m_ObjectList[0].transform.GetChild(6).gameObject.SetActive(false);

                                __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(2).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(3).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(4).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(5).gameObject.SetActive(false);
                                __instance.m_ObjectList[1].transform.GetChild(6).gameObject.SetActive(false);

                                __instance.m_ObjectList[2].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(2).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(3).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(4).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(5).gameObject.SetActive(false);
                                __instance.m_ObjectList[2].transform.GetChild(6).gameObject.SetActive(false);

                                __instance.m_ObjectList[3].transform.GetChild(0).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(1).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(2).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(3).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(4).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(5).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(7).gameObject.SetActive(false);
                                __instance.m_ObjectList[3].transform.GetChild(8).gameObject.SetActive(false);
                                return false;
                            }
                        }
                        else if (regionName == "RuralRegion" && __instance.transform.GetParent().name == "Town" && Settings.settings.buildingEnabled)
                        {
                            __instance.m_ObjectList[0].gameObject.SetActive(true);
                            __instance.m_ObjectList[1].gameObject.SetActive(true);
                            __instance.m_ObjectList[2].gameObject.SetActive(true);

                            __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);
                            __instance.m_ObjectList[0].transform.GetChild(2).gameObject.SetActive(false);

                            __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                            __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);

                            __instance.m_ObjectList[2].transform.GetChild(0).gameObject.SetActive(false);
                            __instance.m_ObjectList[2].transform.GetChild(1).gameObject.SetActive(false);
                            return false;
                        }
                        else if (regionName == "LakeRegion" && __instance.name == "RandomSpawnObjectBase_lakeCabins" && Settings.settings.buildingEnabled)
                        {
                            __instance.m_ObjectList[0].gameObject.SetActive(true);
                            __instance.m_ObjectList[1].gameObject.SetActive(true);
                            __instance.m_ObjectList[2].gameObject.SetActive(true);

                            __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                            __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);

                            __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                            __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);
                            __instance.m_ObjectList[1].transform.GetChild(2).gameObject.SetActive(false);
                            
                            __instance.m_ObjectList[2].transform.GetChild(0).gameObject.SetActive(false);
                            __instance.m_ObjectList[2].transform.GetChild(1).gameObject.SetActive(false);
                            __instance.m_ObjectList[2].transform.GetChild(2).gameObject.SetActive(false);
                            return false;
                        }
                        else if (regionName == "CoastalRegion" && Settings.settings.buildingEnabled)
                        {
                            switch (__instance.name)
                            {
                                case "RandomSpawnObjectBase_cabins":

                                    __instance.m_ObjectList[0].gameObject.SetActive(true);
                                    __instance.m_ObjectList[1].gameObject.SetActive(true);
                                    __instance.m_ObjectList[2].gameObject.SetActive(false);

                                    __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                                    return false;

                                case "RandomSpawnObjectBase_logsort":

                                    __instance.m_ObjectList[0].gameObject.SetActive(true);
                                    __instance.m_ObjectList[1].gameObject.SetActive(false);
                                    return false;

                                case "RandomSpawnObjectBase_waterfront":

                                    __instance.m_ObjectList[0].gameObject.SetActive(true);
                                    __instance.m_ObjectList[1].gameObject.SetActive(true);
                                    __instance.m_ObjectList[2].gameObject.SetActive(false);
                                    __instance.m_ObjectList[3].gameObject.SetActive(false);

                                    __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(2).gameObject.SetActive(false);
                                    return false;

                                case "RandomSpawnObjectBase_townSouth":

                                    __instance.m_ObjectList[0].gameObject.SetActive(true);
                                    __instance.m_ObjectList[1].gameObject.SetActive(true);
                                    __instance.m_ObjectList[2].gameObject.SetActive(true);

                                    __instance.m_ObjectList[0].transform.GetChild(0).gameObject.SetActive(false);
                                    __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(0).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(2).gameObject.SetActive(false);
                                    __instance.m_ObjectList[2].transform.GetChild(1).gameObject.SetActive(false);
                                    __instance.m_ObjectList[2].transform.GetChild(2).gameObject.SetActive(false);
                                    return false;

                                case "RandomSpawnObjectBase_townNorth":

                                    __instance.m_ObjectList[0].gameObject.SetActive(true);
                                    __instance.m_ObjectList[1].gameObject.SetActive(true);
                                    __instance.m_ObjectList[2].gameObject.SetActive(false);
                                    __instance.m_ObjectList[3].gameObject.SetActive(false);


                                    __instance.m_ObjectList[0].transform.GetChild(1).gameObject.SetActive(false);
                                    __instance.m_ObjectList[0].transform.GetChild(2).gameObject.SetActive(false);
                                    __instance.m_ObjectList[0].transform.GetChild(4).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(1).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(4).gameObject.SetActive(false);
                                    __instance.m_ObjectList[1].transform.GetChild(5).gameObject.SetActive(false);
                                    return false;

                                case "RandomSpawnObjectBase_burnt_nightmare":

                                    __instance.m_ObjectList[0].gameObject.SetActive(false);
                                    return false;

                                default:
                                    break;
                            }
                        }
                    }
                    /*else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("BEAR") && Settings.settings.bearEnabled)
                    {
                        // ----------   ALL BEAR CAVE ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                    else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("MOOSE") && Settings.settings.mooseEnabled)
                    {
                        // ----------   ALL MOOSE ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                    else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("RABBIT") && Settings.settings.rabbitEnabled)
                    {
                        // ----------   ALL RABBIT ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                    else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("STAG") && Settings.settings.stagEnabled)
                    {
                        // ----------   ALL STAG ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }*/
                    else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("SHELTER") && Settings.settings.snowShelterEnabled)
                    {
                        // ----------   ALL SNOW SHELTER AND FIRE CAMPS ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                    else if (__instance.transform.GetParent().name.ToUpperInvariant().Contains("CAMP") && Settings.settings.snowShelterEnabled)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                    else if (__instance.transform.GetParent().name == "SignalFires" && Settings.settings.signalEnabled)
                    {
                        // ----------   BOTH SIGNAL FIRES IN HRV ACTIVE ---------
                        for (int i = 0; i < 4; i++)
                        {
                            __instance.m_NumObjectsToEnableByLevel[i] = __instance.m_ObjectList.Count;
                        }
                        return true;
                    }
                }
                return true;
            }
        }
    }
}
