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
            switch (sceneName)
            {
                case "RuralRegion_SANDBOX":

                    GameObject town1 = GameObject.Find("Design/RandomSpawnStructures/notForMisery/Town/Town1");
                    GameObject town2 = GameObject.Find("Design/RandomSpawnStructures/notForMisery/Town/Town2");
                    GameObject town3 = GameObject.Find("Design/RandomSpawnStructures/notForMisery/Town/Town3");

                    if (town1.activeSelf && town2.activeSelf && town3.activeSelf)
                    {

                        town1.transform.GetChild(1).gameObject.SetActive(false);
                        town1.transform.GetChild(2).gameObject.SetActive(false);

                        town2.transform.GetChild(0).gameObject.SetActive(false);
                        town2.transform.GetChild(1).gameObject.SetActive(false);

                        town3.transform.GetChild(0).gameObject.SetActive(false);
                        town3.transform.GetChild(1).gameObject.SetActive(false);
                    }
                    break;

                case "MountainTownRegion_SANDBOX":

                    GameObject RandomHouseGroup1 = GameObject.Find("Design/Houses_Random/RandomHouseGroup1");
                    GameObject RandomHouseGroup2 = GameObject.Find("Design/Houses_Random/RandomHouseGroup2");
                    GameObject RandomHouseGroup3 = GameObject.Find("Design/Houses_Random/RandomHouseGroup3");

                    if (RandomHouseGroup1.activeSelf && RandomHouseGroup2.activeSelf && RandomHouseGroup3.activeSelf)
                    {
                        RandomHouseGroup1.transform.GetChild(2).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(4).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(9).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(11).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(13).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(15).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(16).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(17).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(18).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(19).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(20).gameObject.SetActive(false);
                        RandomHouseGroup1.transform.GetChild(21).gameObject.SetActive(false);

                        RandomHouseGroup2.transform.GetChild(0).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(3).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(5).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(7).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(8).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(10).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(12).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(13).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(14).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(17).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(18).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(19).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(20).gameObject.SetActive(false);
                        RandomHouseGroup2.transform.GetChild(21).gameObject.SetActive(false);

                        RandomHouseGroup3.transform.GetChild(0).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(4).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(6).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(8).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(9).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(10).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(11).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(12).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(13).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(14).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(15).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(16).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(17).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(18).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(19).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(20).gameObject.SetActive(false);
                        RandomHouseGroup3.transform.GetChild(21).gameObject.SetActive(false);

                    }
                    break;


                case "CoastalRegion_SANDBOX":

                    GameObject CabinsA = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/Cabins/CabinsA");
                    GameObject CabinsB = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/Cabins/CabinsB");
                    GameObject Waterfront1 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/Waterfront/Waterfront1");
                    GameObject Waterfront2 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/Waterfront/Waterfront2");
                    GameObject TownSouth1 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/TownSouth/TownSouth1");
                    GameObject TownSouth2 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/TownSouth/TownSouth2");
                    GameObject TownSouth3 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/TownSouth/TownSouth3");
                    GameObject TownNorth1 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/TownNorth/TownNorth1");
                    GameObject TownNorth2 = GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/TownNorth/TownNorth2");

                    GameObject FishHuts11 = GameObject.Find("Design/RandomSpawnStructures/RandomFishHuts/Fishhuts1"); // lower 'h'
                    GameObject FishHuts22 = GameObject.Find("Design/RandomSpawnStructures/RandomFishHuts/FishHuts2");
                    GameObject FishHuts33 = GameObject.Find("Design/RandomSpawnStructures/RandomFishHuts/FishHuts3");
                    GameObject FishHuts44 = GameObject.Find("Design/RandomSpawnStructures/RandomFishHuts/FishHuts4");

                    if (FishHuts11.activeSelf && FishHuts22.activeSelf && FishHuts33.activeSelf && FishHuts44.activeSelf)
                    {
                        FishHuts11.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts11.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts11.transform.GetChild(4).gameObject.SetActive(false);
                        FishHuts11.transform.GetChild(5).gameObject.SetActive(false);
                        FishHuts11.transform.GetChild(6).gameObject.SetActive(false);

                        FishHuts22.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(2).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(3).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(4).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(5).gameObject.SetActive(false);
                        FishHuts22.transform.GetChild(6).gameObject.SetActive(false);

                        FishHuts33.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(2).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(3).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(4).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(5).gameObject.SetActive(false);
                        FishHuts33.transform.GetChild(6).gameObject.SetActive(false);

                        FishHuts44.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(2).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(3).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(4).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(5).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(7).gameObject.SetActive(false);
                        FishHuts44.transform.GetChild(8).gameObject.SetActive(false);
                    }

                    if (TownSouth1.activeSelf && TownSouth2.activeSelf && TownSouth3.activeSelf)
                    {

                        GameObject.Find("Design/RandomSpawnStructures/RandomBurnedHouses/Nightmare_Burned_Buildings/Nightmare_burnt").gameObject.SetActive(false);
                        GameObject.Find("Art/Structure_Group/STRSPAWN_HouseExteriorE_Prefab").gameObject.SetActive(true);
                        GameObject.Find("Art/Structure_Group/STRSPAWN_LakeCabinD_Prefab").gameObject.SetActive(true);
                        GameObject.Find("Art/Structure_Group/LakeCabins_with_Fishing_interiors/STRSPAWN_LakeCabinD_Prefab").gameObject.SetActive(true);

                        CabinsA.transform.GetChild(0).gameObject.SetActive(false);
                        CabinsB.transform.GetChild(0).gameObject.SetActive(false);

                        Waterfront1.transform.GetChild(0).gameObject.SetActive(false);
                        Waterfront2.transform.GetChild(1).gameObject.SetActive(false);
                        Waterfront2.transform.GetChild(2).gameObject.SetActive(false);

                        TownSouth1.transform.GetChild(0).gameObject.SetActive(false);
                        TownSouth1.transform.GetChild(1).gameObject.SetActive(false);
                        TownSouth2.transform.GetChild(0).gameObject.SetActive(false);
                        TownSouth2.transform.GetChild(2).gameObject.SetActive(false);
                        TownSouth3.transform.GetChild(1).gameObject.SetActive(false);
                        TownSouth3.transform.GetChild(2).gameObject.SetActive(false);

                        TownNorth1.transform.GetChild(1).gameObject.SetActive(false);
                        TownNorth1.transform.GetChild(2).gameObject.SetActive(false);
                        TownNorth1.transform.GetChild(4).gameObject.SetActive(false);
                        TownNorth2.transform.GetChild(1).gameObject.SetActive(false);
                        TownNorth2.transform.GetChild(4).gameObject.SetActive(false);
                        TownNorth2.transform.GetChild(5).gameObject.SetActive(false);
                    }
                    break;

                case "LakeRegion_SANDBOX":

                    GameObject LakeCabins1 = GameObject.Find("Design/RandomSpawnStructures/RandomBurned/LakeCabins/LakeCabins1");
                    GameObject LakeCabins2 = GameObject.Find("Design/RandomSpawnStructures/RandomBurned/LakeCabins/LakeCabins2");
                    GameObject LakeCabins3 = GameObject.Find("Design/RandomSpawnStructures/RandomBurned/LakeCabins/LakeCabins3");

                    GameObject FishHuts1 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts1/");
                    GameObject FishHuts2 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts2/");
                    GameObject FishHuts3 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts3/");
                    
                    if (LakeCabins1.activeSelf && LakeCabins2.activeSelf && LakeCabins3.activeSelf)
                    {
                        LakeCabins1.transform.GetChild(0).gameObject.SetActive(false);
                        LakeCabins1.transform.GetChild(1).gameObject.SetActive(false);

                        LakeCabins2.transform.GetChild(0).gameObject.SetActive(false);
                        LakeCabins2.transform.GetChild(1).gameObject.SetActive(false);
                        LakeCabins2.transform.GetChild(2).gameObject.SetActive(false);

                        LakeCabins3.transform.GetChild(0).gameObject.SetActive(false);
                        LakeCabins3.transform.GetChild(1).gameObject.SetActive(false);
                        LakeCabins3.transform.GetChild(2).gameObject.SetActive(false);
                    }

                    if (FishHuts1.activeSelf && FishHuts2.activeSelf && FishHuts3.activeSelf)
                    {
                        FishHuts1.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts1.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts1.transform.GetChild(2).gameObject.SetActive(false);

                        FishHuts2.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts2.transform.GetChild(1).gameObject.SetActive(false);
                        FishHuts2.transform.GetChild(2).gameObject.SetActive(false);

                        FishHuts3.transform.GetChild(0).gameObject.SetActive(false);
                        FishHuts3.transform.GetChild(1).gameObject.SetActive(false);
                    }
                    break;

                /*case "MarshRegion_WILDLIFE":

                    GameObject.Find("Wildlife_Spawns_Predators/Moose_controlledByTags/MooseSet2").gameObject.SetActive(true);
                    GameObject.Find("Wildlife_Spawns_Predators/Moose_controlledByTags/MooseSet3").gameObject.SetActive(true);
                    GameObject.Find("Wildlife_Spawns_Predators/Moose_controlledByTags/MooseSet4").gameObject.SetActive(true);
                    break;*/

                default:
                    break;
            }


            /*public override void OnSceneWasInitialized(int buildIndex, string sceneName)
            {
                if(sceneName == "MountainTownRegion_SANDBOX")
                {
                    // ---------------   ADD A BUNKER IN MT BASIN  -----------------
                    //Didn't succeed because of exit point

                    GameObject bunker = GameObject.Find("Design/RandomSpawners/BunkerHatch_1d_STARTDISABLED");

                    bunker.SetActive(true);
                    bunker.transform.GetChild(0).gameObject.SetActive(false);
                    bunker.transform.GetChild(1).gameObject.SetActive(false);
                    bunker.transform.GetChild(2).gameObject.SetActive(false);
                    bunker.transform.GetChild(3).gameObject.SetActive(false);
                }
            }
            
             ,
		{
			"type": "mod",
			"version": "1.1.0",
			"name": "AllRandomLayoutsAtOnce",
			"displayName": "All Random Layouts At Once",
			"author": "Romain",
			"previousAuthors": "",
			"released": "2025-01-18",
			"updated": "2025-01-19",
			"downloadURL": "https://github.com/RomainDeschampsFR/AllRandomLayoutsAtOnce/releases/download/1.1.0/AllRandomLayoutsAtOnce.dll",
			"modURL": "https://github.com/RomainDeschampsFR/AllRandomLayoutsAtOnce",
			"description": "This mod allows you to combine all random layouts in the same run.",
			"tags": "",
			"categories": [
				"Quality of Life",
				"Base Building",
				"Cheats",
				"Misc"
			],
			"gameversion": [
				"vanilla"
			],
			"images": [],
			"dependencies": [
				"ModSettings"
			],
			"status": {
				"working": true,
				"beta": false,
				"patchnotes": "",
				"notes": "Allow to enable :\n* All vanilla lootable buildings\n* All prepper caches full\n\n* All bear caves\n* All moose areas\n* All rabbits areas\n* All stag areas\n\n* All snow shelters and campfires\n* All vanilla doors for fishing huts\n* All mementos\n* Both signal fires in HRV",
				"issues": ""
			},
			"testedon": {
				"tldversion": "2.39",
				"mlversion": "6.6"
			},
			"updater": {
				"enable": true,
				"downloads": []
			},
			"aliases": [],
			"replaces": []
		}*/


        }
    }
}