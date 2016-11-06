using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragonsList
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GridDragon> BattleRange = new List<GridDragon>();
        List<GridDragon> BattleDef = new List<GridDragon>();
        List<GridDragon> BattleAtk = new List<GridDragon>();

        List<GridDragon> FishIron = new List<GridDragon>();
        List<GridDragon> WoodIron = new List<GridDragon>();


        List<GridDragon> FishDragon = new List<GridDragon>();
        List<GridDragon> WoodDragon = new List<GridDragon>();

        List<GridDragon> IronDragon = new List<GridDragon>();

        //List<GridDragon> onBerkList = new List<GridDragon>();


        public MainWindow()
        {
            InitializeComponent();
             
         //   getDragonsOnBerk();
           
             
            string FileName = System.IO.Directory.GetCurrentDirectory()+ @"\Dragons.txt";

            List<string> dragonListPlain = new List<string>();
          
            using (StreamReader sr = new StreamReader(FileName, Encoding.Default))
                {  
                    string line = sr.ReadToEnd();

                    line = line.Replace("|-", "#").Replace("|}", "#");

                    line = Regex.Replace(line, @"\r\n?|\n", "");
                    line = line.Replace("*","");

                    line = line.Replace("[[Gothi's Gronckle]] [[Gothi's Gronckle| {(^_^)}'s&lt;^),,//,,)~]]", "[[Gothi's Gronckle]]");
                 
                    string[] dragons = line.Split('#');
                       
                foreach(var item in dragons)
                {
                    if (item != "")
                        dragonListPlain.Add(item);

                }

                sr.Close();
                }

            List<DragonModel> dragonList = new List<DragonModel>();

           
            foreach(var item in dragonListPlain)
            {
 
                    DragonModel dragon = new DragonModel();
                    string[] removeSpliter = item.Split('|');

                    switch (removeSpliter.Count())
                    {

                        case 20:
                            try
                            {
                                //removeSpliter[0] "" 
                                dragon.DragonName = removeSpliter[1].Replace("[", "").Replace("]", "").Trim();


                          

                                dragon.DragonClass = removeSpliter[2].Replace("[", "").Replace("]", "").Trim();
                                dragon.ClassImage = removeSpliter[3].Replace("None", "").Trim();

                                // removeSpliter[4] url rarity
                                dragon.Rarity = removeSpliter[5].Replace("]", "").Trim();
                                dragon.Fish1s = removeSpliter[6].Replace("None", "0").Trim();
                                dragon.Wood1s = removeSpliter[7].Replace("None", "0").Trim();
                                // removeSpliter[8] sort
                                dragon.Times = removeSpliter[9].Trim();
                                dragon.BattleType = removeSpliter[10].Replace("None", "").Trim();
                                //removeSpliter[11] icon
                                //removeSpliter[12] px
                                //removeSpliter[13] url
                                dragon.BattleValues = removeSpliter[14].Replace("None", "0").Replace("?", "0").Trim();


                                dragon.Irons = removeSpliter[15].Replace("None", "0").Replace("?", "0").Trim();
                                dragon.IronTimes = removeSpliter[17].Replace("None", "0").Trim();
                                dragon.IronFishs = removeSpliter[18].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();
                                dragon.IronWoods = removeSpliter[19].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();


                               
                                addNewDragon(dragon);



                            }
                            catch (Exception ex)
                            { MessageBox.Show(ex.Message + " 20 " + item); }


                            break;
                        case 26:
                            try
                            {

                                if (!item.Contains("Lil Lullaby"))
                                {
                                    //removeSpliter[0] "" 
                                    dragon.DragonName = removeSpliter[1].Replace("[", "").Replace("]", "").Trim();

 

                                    dragon.DragonClass = removeSpliter[2].Replace("[", "").Replace("]", "").Trim();
                                    dragon.ClassImage = removeSpliter[3].Split('"')[1].Trim();
                                    // removeSpliter[4] Icon
                                    // removeSpliter[5] px
                                    // removeSpliter[6] url classe
                                    // removeSpliter[7] url rarity
                                    dragon.Rarity = removeSpliter[8].Replace("]", "").Trim();
                                    dragon.Fish1s = removeSpliter[9].Replace("None", "0").Trim();
                                    dragon.Wood1s = removeSpliter[10].Replace("None", "0").Trim();
                                    // removeSpliter[11] sort
                                    dragon.Times = removeSpliter[12].Trim();
                                    dragon.BattleType = removeSpliter[13].Split('"')[1].Trim();
                                    //removeSpliter[14] icon
                                    //removeSpliter[15] px
                                    //removeSpliter[16] url
                                    dragon.BattleValues = removeSpliter[17].Replace("None", "0").Replace("?", "0").Trim();
                                    //removeSpliter[18] sort
                                    //removeSpliter[19] b1
                                    //removeSpliter[20] b2
                                    //removeSpliter[21] b3
                                    dragon.Irons = removeSpliter[22].Replace("None", "0").Replace("?", "0").Trim();
                                    dragon.IronTimes = removeSpliter[23].Replace("None", "0").Trim();
                                    dragon.IronFishs = removeSpliter[24].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();
                                    dragon.IronWoods = removeSpliter[25].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();
                                }
                                else
                                {

                                    //removeSpliter[0] "" 
                                    dragon.DragonName = removeSpliter[1].Replace("[", "").Replace("]", "").Trim();

 

                                    dragon.DragonClass = removeSpliter[2].Replace("[", "").Replace("]", "").Trim();
                                    dragon.ClassImage = removeSpliter[3].Split('"')[1].Trim();
                                    // removeSpliter[4] Icon
                                    // removeSpliter[5] px
                                    // removeSpliter[6] url classe
                                    // removeSpliter[7] url rarity
                                    dragon.Rarity = removeSpliter[8].Replace("]", "").Trim();
                                    dragon.Fish1s = removeSpliter[9].Replace("None", "0").Trim();
                                    dragon.Wood1s = removeSpliter[10].Replace("None", "0").Trim();
                                    // removeSpliter[11] sort
                                    dragon.Times = removeSpliter[12].Trim();
                                    dragon.BattleType = removeSpliter[13].Split('"')[1].Trim();
                                    //removeSpliter[14] icon
                                    //removeSpliter[15] px
                                    //removeSpliter[16] url
                                    dragon.BattleValues = removeSpliter[17].Replace("None", "0").Replace("?", "0").Trim();
                                    //removeSpliter[18] sort
                                    //removeSpliter[19] b1
                                    //removeSpliter[20] b2
                                    //removeSpliter[21] b3
                                    dragon.Irons = removeSpliter[22].Replace("None", "0").Replace("?", "0").Trim();
                                    dragon.IronTimes = removeSpliter[24].Replace("None", "0").Trim();
                                    dragon.IronFishs = removeSpliter[25].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();
                                    dragon.IronWoods = ""; // removeSpliter[25].Replace("None", "").Replace("???M", "").Replace("M", "").Replace("?", "").Trim();
                                }
                              
                                addNewDragon(dragon);

                            }
                            catch (Exception ex)
                            { MessageBox.Show(ex.Message + " 26 " + item); }



                            break;
                        case 27:
                            try
                            {

                                //removeSpliter[0] "" 
                                dragon.DragonName = removeSpliter[1].Replace("[", "").Replace("]", "").Trim();
 


                                dragon.DragonClass = removeSpliter[2].Replace("[", "").Replace("]", "").Trim();
                                dragon.ClassImage = removeSpliter[3].Split('"')[1].Trim();
                                // removeSpliter[4] Icon
                                // removeSpliter[5] px
                                // removeSpliter[6] url classe
                                // removeSpliter[7] url rarity
                                dragon.Rarity = removeSpliter[8].Replace("]", "").Trim();
                                dragon.Fish1s = removeSpliter[9].Replace("None", "0").Trim();
                                dragon.Wood1s = removeSpliter[10].Replace("None", "0").Trim();
                                // removeSpliter[11] sort
                                dragon.Times = removeSpliter[12].Trim();
                                dragon.BattleType = removeSpliter[13].Split('"')[1].Trim();
                                //removeSpliter[14] icon
                                //removeSpliter[15] px
                                //removeSpliter[16] url
                                dragon.BattleValues = removeSpliter[17].Replace("None", "0").Replace("?", "0").Trim();
                                //removeSpliter[18] sort
                                //removeSpliter[19] b1
                                //removeSpliter[20] b2
                                //removeSpliter[21] b3
                                dragon.Irons = removeSpliter[22].Replace("None", "0").Replace("?", "0").Trim();
                                //removeSpliter[23] sort
                                dragon.IronTimes = removeSpliter[24].Replace("None", "0").Trim();
                                dragon.IronFishs = removeSpliter[25].Replace("None", "").Replace("???M", "").Replace("?", "").Replace("M", "").Trim();
                                dragon.IronWoods = removeSpliter[26].Replace("None", "").Replace("???M", "").Replace("?", "").Replace("M", "").Trim();
                               
                              
                                addNewDragon(dragon);

                            }
                            catch (Exception ex)
                            { MessageBox.Show(ex.Message + " 27 " + item); }


                            break;

                        default: if (item != " ") MessageBox.Show("new dragonitem:" + item + removeSpliter.Count().ToString()); break;
                    }
                 

                    if (dragon.DragonName != null   )
                    {

                    dragonList.Add(dragon);
                }

            }

            /*
            List<GridDragon> top10fish = new List<GridDragon>(); 

            top10fish.Add(new GridDragon { Name = "Sven's Nightmare", Type = "U" });
      top10fish.Add(new GridDragon { Name = "Bonecrusher's Conquest", Type = "U" });
top10fish.Add(new GridDragon { Name = "Valka's Mercy", Type = "U" });
top10fish.Add(new GridDragon { Name = "Coldsnap2", Type = "E" });
top10fish.Add(new GridDragon { Name = "Coldsnap", Type = "E" });
top10fish.Add(new GridDragon { Name = "Chompers", Type = "E" });
top10fish.Add(new GridDragon { Name = "Windstriker", Type = "R" });
top10fish.Add(new GridDragon { Name = "Scardian", Type = "U" });
top10fish.Add(new GridDragon { Name = "Threadtail", Type = "R" });
 top10fish.Add(new GridDragon { Name = "Skystreaker", Type = "L" });
 
             
            foreach (var item in dragonList)
            {
                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
                d.Type = item.Type;
  
                if (item.OnBerk == true)
                {
                    if (item.Fish8 > 0)
                    {
                        d.Value = item.Fish8;
                        FishDragon.Add(d);
                          
                    }
                   
                }
            }
           
            foreach (var item in dragonList)
            {
                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
                d.Type = item.Type;

                bool fishdrache = false;
                foreach (var fish in top10fish)
                {
                    if (fish.Name == item.DragonName && fish.Type == item.Type) fishdrache = true;

                }

                if (item.OnBerk == true && fishdrache == false)
                {
                    if (item.Wood8 > 0)
                    { 
                        d.Value = item.Wood8;
                        WoodDragon.Add(d);
                    }
                }

            
            }


            foreach(var item in dragonList )
            {
               GridDragon d = new  GridDragon();
                 d.Name = item.DragonName;
                 d.Type = item.Type;

          
                 
                if(item.OnBerk == true)
                {
                if(item.BattleType =="Sharpshooter"  )
                {
                    d.Value = item.BattleValuei;
                    BattleRange.Add(d);

                }
                else if (item.BattleType == "Attacker")
                {
                    d.Value = item.BattleValuei;
                    BattleAtk.Add(d);
                }
                else if (item.BattleType == "Defender")
                {
                    d.Value = item.BattleValuei;
                    BattleDef.Add(d);
                }
                }
            }
            */

            //collecting
            foreach (var item in dragonList)
            {


                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
                d.Type = item.Type;
               
                d.Value = item.Fish8;
                FishDragon.Add(d);
                    
            }

            foreach (var item in dragonList)
            {


                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
                d.Type = item.Type;
                d.Value = item.Wood8;
                WoodDragon.Add(d);
                

            }

            //battle
            foreach (var item in dragonList)
            {

                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
                d.Type = item.Type;



                if (item.OnBerk == true)
                {
                    if (item.BattleType == "Sharpshooter")
                    {
                        d.Value = item.BattleValuei;
                        BattleRange.Add(d);

                    }
                    else if (item.BattleType == "Attacker")
                    {
                        d.Value = item.BattleValuei;
                        BattleAtk.Add(d);
                    }
                    else if (item.BattleType == "Defender")
                    {
                        d.Value = item.BattleValuei;
                        BattleDef.Add(d);
                    }
                }


            }


            //iron
            foreach (var item in dragonList)
            {
                GridDragon d = new GridDragon();
                d.Name = item.DragonName;
            

                int ironpeases = item.Ironi;

                double woodPrice = item.IronWoodi;

                double  fishPrice = item.IronFishi;

                int time = item.IronTimei;

                if (ironpeases > 0)
                {
                    if (woodPrice > 0)
                    {
                        d.Value =  woodPrice / ironpeases;
                        d.Type = (time / ironpeases).ToString();
                        WoodIron.Add(d);

                    }
                    else if (fishPrice > 0)
                    {
                        d.Value =  fishPrice / ironpeases;
                        d.Type = (time / ironpeases).ToString();
                        FishIron.Add(d);

                    }
                }
               






            }
            gridIronFish.ItemsSource = FishIron;
            gridIronWood.ItemsSource = WoodIron;
            battleRange.ItemsSource = BattleRange;
            battleAtk.ItemsSource = BattleAtk;
            battleDef.ItemsSource = BattleDef;
            gridFish.ItemsSource = FishDragon;
            gridWood.ItemsSource = WoodDragon;

           // creagteDragons();
           
          
        }

        //private void getDragonsOnBerk()
        //{
        //    /*
        //                case "Battle": dragon.Type = "B"; break;
                     
                       
        //                case "Common": dragon.Type = "C"; break;
        //                case "Exclusive": dragon.Type = "E"; break;
                       
        //                case "Rare": dragon.Type = "R"; break;
        //                case "Scarce": dragon.Type = "C"; break;
                        
        //                case "Unique": dragon.Type = "U"; break;
        //     */

        //    onBerkList.Add(new GridDragon { Name = "Toothless", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Monstrous Nightmare", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Gronckle", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Terrible Terror", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Monstrous Nightmare", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Cupid Meatlug", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Meatlug", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Scauldron", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Smothering Smokebreath", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Whispering Death", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Edge Nadder", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Deadly Nadder", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Gronckle", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Stormfly", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Hobblegrunt", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Snaptrapper", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Whispering Death", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Snafflefang", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Changewing", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Shockjaw", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Hackatoo", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Timberjack", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Deadly Nadder", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Fanghook", Type = "U" }); 
        //    onBerkList.Add(new GridDragon { Name = "Toothless' Rival", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Stormfly's Offspring", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Hideous Zippleback", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Thunderdrum", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Typhoomerang", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Changewing", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Smothering Smokebreath", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Scauldron", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Snaptrapper", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Terrible Terror", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Puddlemuck", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Valka's Mercy", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Sliquifier", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Flightmare", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Raincutter", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Thunderpede", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Hotburple", Type = "C" });

        //    onBerkList.Add(new GridDragon { Name = "Exotic Shockjaw", Type = "Ex" });
        //    onBerkList.Add(new GridDragon { Name = "Torch's Mother", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Gobber's Nemesis", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Icebane", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Scuttleclaw", Type = "C" });
        //    onBerkList.Add(new GridDragon { Name = "Boneknapper", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Rumblehorn", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Thunderdrum", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Hookfang", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Exotic Smothering Smokebreath", Type = "Ex" });
        //    onBerkList.Add(new GridDragon { Name = "Thornridge", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Windshear", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Sand Wraith", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Stormcutter", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Skrill", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Snoggletog Barf and Belch", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Seashocker", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Sweet Death", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Flightmare", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Scardian", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Tide Glider", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Fireworm Princess", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Sweet Wraith", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Trailtwister", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Shivertooth", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Woolly Howl", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Groncicle", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Ripwrecker", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Grapple Grounder", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Sword Stealer", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Thornado", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Torch", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Windstriker", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Snow Wraith", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Slithersong", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Night Terror", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Thunderclaw", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Groundsplitter", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Boneknapper", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Bonecrusher's Conquest", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Hofferson's Bane", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Sailback", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Torch's Brother", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Torch's Sister", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Timberjack", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Grump", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Hackagift", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Clawlifter", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Rattling Smokebreath", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Deepfreeze", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Egg Biter", Type = "R" });

        //    onBerkList.Add(new GridDragon { Name = "Egg Blossom", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Catastrophic Quaken", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Stormcutter", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Sweet Death", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Skrill", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Lil Lullaby", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Whip & Lash", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Muddlehunt", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Coldsnap", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Book Wyrm", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Earsplitter", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Boneshedder", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Stokehead", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Spitelout's Kingstail", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Solar Flare", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Gobsucker", Type = "R" });
        //    onBerkList.Add(new GridDragon { Name = "Champion Triple Stryke", Type = "Ch" });
        //    onBerkList.Add(new GridDragon { Name = "Windgnasher", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Tuffwing", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Raincutter", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Rumblehorn", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Typhoomerang", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Junior Tuffnut jr.", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Edgewing", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Fangmaster", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Soaring Sidekick", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Brute Boneknapper", Type = "LB" });

        //    onBerkList.Add(new GridDragon { Name = "Brute Snaptrapper", Type = "LB" });
        //    onBerkList.Add(new GridDragon { Name = "Brute Timberjack", Type = "LB" });
        //    onBerkList.Add(new GridDragon { Name = "Garffiljorg", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Irontooth", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Death Song", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Nightwatch", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Gobstinker", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Mildew's Misery", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Groncicle", Type = "B" });

        //    onBerkList.Add(new GridDragon { Name = "Battle Hideous Zippleback", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Stormfly's Mate", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Pestbud", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Melting Wing", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Tormentor", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Seedling Sweet Death", Type = "LS" });

        //    onBerkList.Add(new GridDragon { Name = "Fireworm Queen", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Desert Wraith", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Exotic Sliquifier", Type = "Ex" });

        //    onBerkList.Add(new GridDragon { Name = "Primal Hobblegrunt", Type = "LP" });
        //    onBerkList.Add(new GridDragon { Name = "Champion Catastrophic Quaken", Type = "Ch" });
        //    onBerkList.Add(new GridDragon { Name = "Champion Windgnasher", Type = "Ch" });

        //    onBerkList.Add(new GridDragon { Name = "Gothi's Gronckle", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Rumpus", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Skullcrusher", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Sven's Nightmare", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Winged Warden", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Barf & Belch's Mate", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Exotic Sword Stealer", Type = "Ex" });
        //    onBerkList.Add(new GridDragon { Name = "Masked Sweet Death", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Chompers", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Cloudjumper", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Dagur's Skrill", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Kick-off Terror", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Smidvarg", Type = "U" });

        //    onBerkList.Add(new GridDragon { Name = "Coldsnap2", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Hackagift2", Type = "E" });

        //    onBerkList.Add(new GridDragon { Name = "Skystreaker", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Battle Ripwrecker", Type = "B" });
        //    onBerkList.Add(new GridDragon { Name = "Slimeslinger", Type = "E" });
        //    onBerkList.Add(new GridDragon { Name = "Darkvarg", Type = "U" });
        //    onBerkList.Add(new GridDragon { Name = "Threadtail", Type = "R" });
            
            

        //    //onBerkList.Add("Battle Sliquifier");
        //    //onBerkList.Add("Ambered Nadder");
        //    //onBerkList.Add("Armorwing");
        //    //onBerkList.Add("Axewing");
        //    //onBerkList.Add("Bam");
        //    //onBerkList.Add("Bandit");
             
        //    //onBerkList.Add("Barf & Belch's Offspring");
        //    //onBerkList.Add("Basket Case");
            
        //    //onBerkList.Add("Battle Fireworm Princess");
        //    // 
        //    //onBerkList.Add("Battle Grapple Grounder");
        
             
        //    //onBerkList.Add("Battle Hackatoo");
            
        //    //onBerkList.Add("Battle Hobblegrunt");
        //    //onBerkList.Add("Battle Hotburple");
             
        //    //onBerkList.Add("Battle Ripwrecker");
            
        //    //onBerkList.Add("Battle Scuttleclaw");
        //    //onBerkList.Add("Battle Seashocker");
        //    //onBerkList.Add("Battle Shockjaw");
            
        //    //onBerkList.Add("Battle Snafflefang");
      
        //    //onBerkList.Add("Battle Sword Stealer");
             
        //    //onBerkList.Add("Battle Thunderclaw");
        //    // 
        //    //onBerkList.Add("Battle Thunderpede");
        //    //onBerkList.Add("Battle Tide Glider");
         
        //    //onBerkList.Add("Battle Windstriker");
        //    //onBerkList.Add("Battle Woolly Howl");
        //    //onBerkList.Add("Bing");
             
        //    //onBerkList.Add("Boom");
        //    //onBerkList.Add("Bork Week Nadder");
        //    // 
        //    //onBerkList.Add("Brute Skrill");
           
        //    //onBerkList.Add("Butt");
        //    //onBerkList.Add("Cagecruncher");
             
        //    //onBerkList.Add("Cavern Crasher");
             
        //    //onBerkList.Add("Chicken");
             
        //    //onBerkList.Add("Covecharger");
        //    // 
        //    //onBerkList.Add("Darkvarg");
        //    // 
           
        //    // 
        //    //onBerkList.Add("DRAGON");
        //    //onBerkList.Add("Dronkeys");
        //    //onBerkList.Add("Dustbrawler");
        //    // 
        //    //onBerkList.Add("Exiled Gronckle");
        //    //onBerkList.Add("Exiled Hideous Zippleback");
        //    //onBerkList.Add("Exiled Monstrous Nightmare");
        //    //onBerkList.Add("Exotic Egg Biter");
        //    //onBerkList.Add("Exotic Flightmare");
        //    //onBerkList.Add("Exotic Grapple Grounder");
        //    //onBerkList.Add("Exotic Hackatoo");
        //    //onBerkList.Add("Exotic Moldruffle");
        //    //onBerkList.Add("Exotic Razorwhip");
        //    //onBerkList.Add("Exotic Ripwrecker");
        //    //onBerkList.Add("Exotic Scauldron");
        //    //onBerkList.Add("Exotic Shivertooth");
        //    // 
        //    //onBerkList.Add("Exotic Shovelhelm");
        //    // 
        //    //onBerkList.Add("Exotic Slithersong");
        //    // 
        //    //onBerkList.Add("Exotic Sweet Death");
        //    // 
        //    //onBerkList.Add("Exotic Thunderpede");
        //    //onBerkList.Add("Exotic Tide Glider");
        //    //onBerkList.Add("Exotic Whispering Death");
          
        //    //onBerkList.Add("Firescrapes");
             
        //    //onBerkList.Add("Flashfright");
        //    // 
        //    //onBerkList.Add("Flystorm");
        //    //onBerkList.Add("Frozen Groncicle");
        //    //onBerkList.Add("Furnace");
        //    // 
        //    //onBerkList.Add("Girl-Hookfang");
        //    // 
             
        //    //onBerkList.Add("Gothi's Frostfright");
        //    // 
        //    //onBerkList.Add("Gothi's Pet");
        //    // 
        //    //onBerkList.Add("Gritpicker");
            
        //    //onBerkList.Add("Gruff");
        //    // 
        //    //onBerkList.Add("Guslout");
        //    //onBerkList.Add("Gustnudger");
           
        //    //onBerkList.Add("Head");
            
        //    //onBerkList.Add("Hookfang's Mate");
        //    //onBerkList.Add("Hookfang's Offspring");
        //    // 
        //    //onBerkList.Add("Hotshot");
        //    //onBerkList.Add("Hunterbolt");
        //    // 
        //    //onBerkList.Add("Iggy");
        //    //onBerkList.Add("Incognito");
            
        //    // 
        //    //onBerkList.Add("Leafy Snaptrapper");
        //    // 
        //    //onBerkList.Add("Lump");
        //    // 
             
        //    //onBerkList.Add("Meatlug's Mate");
        //    //onBerkList.Add("Meatlug's Offspring");
        //    // 
        //    // 
        //    //onBerkList.Add("Mildew's Strain");
        //    //onBerkList.Add("Moldruffle");
              
        //    //onBerkList.Add("Outsnapper");
        //    //onBerkList.Add("Pain");
        //    // 
        //    //onBerkList.Add("Prickleboggle");
        //    // 
        //    //onBerkList.Add("Primal Snafflefang");
        //    //onBerkList.Add("Primal Thornridge");
        //    // 
        //    //onBerkList.Add("Quiverpain");
        //    // 
        //    // 
        //    //onBerkList.Add("Razorwhip");
        //    // 
        //    //onBerkList.Add("Ruffnut's Trancemare");
             
        //    //onBerkList.Add("Scauldy");
            
        //    //onBerkList.Add("Seedling Night Terror");
        //    //onBerkList.Add("Seedling Rumblehorn");
        //    //onBerkList.Add("Seedling Sand Wraith");
        //    // 
        //    //onBerkList.Add("Sharpshot");
        //    // 
        //    // 
        //    //onBerkList.Add("Shovelhelm");
        //    // 
        //    //onBerkList.Add("Skrill Chiller");
        //    // 
        //    //onBerkList.Add("Slasher");
          
        //    // 
        //    //onBerkList.Add("Snaggletooth");
        //    // 
        //    //onBerkList.Add("Sneaky");
        //    //onBerkList.Add("Sneezlehunch");
        //    //onBerkList.Add("Snifflehunch");
        //    //onBerkList.Add("Snoggletog Wraith");
            
        //    //onBerkList.Add("Spikeback");
            
        //    // 
          
        //    //onBerkList.Add("Thornshade");
        //    //onBerkList.Add("Thorstopian");
        //    //onBerkList.Add("Threadtail");
        //    //onBerkList.Add("Thump");
             
        //    //onBerkList.Add("Triple Stryke");
        //    //onBerkList.Add("Tuffnut's Death Ride");
           
        //    //onBerkList.Add("Valka's Seashocker");
        //    //onBerkList.Add("Whirlwing");
             
        //    //onBerkList.Add("Wise Wind");
            


          
        //}


        private void creagteDragons(List<DragonModel> dragonList)
        { 
 
        }
        private  DragonModel  addNewDragon( DragonModel dragon)
        {  
            try
            {
                
                dragon.OnBerk = false;
                  switch (dragon.Rarity) 
                    {
                        case "Battle": dragon.Type = "B"; break;
                        case "Brute": dragon.Type = "LB"; break;
                        case "Champion": dragon.Type = "Ch"; break;
                        case "Common": dragon.Type = "C"; break;
                        case "Exclusive": dragon.Type = "E"; break;
                        case "Exiled": dragon.Type = "LE"; break;
                        case "Exotic": dragon.Type = "Ex"; break;
                        case "Premium": dragon.Type = "P"; break;
                        case "Primal": dragon.Type = "LP"; break;
                        case "Rare": dragon.Type = "R"; break;
                        case "Scarce": dragon.Type = "C"; break;
                        case "Seedling": dragon.Type = "LS"; break;
                        case "Unique": dragon.Type = "U"; break;
                      default: dragon.Type = ""; break;
                    }
                 
/*
                foreach (var onberk in onBerkList)
                    if (dragon.DragonName == onberk.Name && dragon.Type == onberk.Type)
                        dragon.OnBerk = true; */

                  dragon.OnBerk = true;

                  

                    dragon.Fish1s = dragon.Fish1s.Replace(",", "");
                    dragon.Wood1s = dragon.Wood1s.Replace(",", "");
                 

                    dragon.Irons = dragon.Irons.Replace(",", "");
                    dragon.BattleValues = dragon.BattleValues.Replace(",", "");
                    dragon.Fish1i = Convert.ToDouble(dragon.Fish1s) / 1000000.0;
                    dragon.Wood1i = Convert.ToDouble(dragon.Wood1s) / 1000000.0;

                   
                    if (dragon.DragonName == "Meatlug") 
                    { 
                        dragon.Wood1i = (dragon.Wood1i / 100.0) * 140.0;
                      dragon.DragonName = "Cupid Meatlug"; } 
                   if   (dragon.DragonName == "Barf & Belch")
                   {
                       dragon.Wood1i = (dragon.Wood1i / 100.0) * 400.0;
                       dragon.Fish1i = (dragon.Fish1i / 100.0) * 400.0;
                       dragon.DragonName = "Snoggletog Barf and Belch";
                   } 
                    dragon.Timei = getTimeMin(dragon.Times);
                    dragon.FishTotal = dragon.Fish1i * (dragon.Timei / 60.0);
                    dragon.WoodTotal = dragon.Wood1i * (dragon.Timei / 60.0);
                    dragon.BattleValuei = Convert.ToDouble(dragon.BattleValues) / 1000.0; ;
                 
                        dragon.Ironi = Convert.ToInt32(dragon.Irons);
                   
                    dragon.IronTimei = getTimeMin(dragon.IronTimes);
                    if (dragon.IronFishs != "")
                        dragon.IronFishi = Convert.ToDouble(dragon.IronFishs);
                    if (dragon.IronWoods != "")
                        dragon.IronWoodi = Convert.ToDouble(dragon.IronWoods);

                    if (dragon.Timei >= 8.0 * 60.0) dragon.Time8 = 8.0;
                    else dragon.Time8 = dragon.Timei / 60.0;

                    dragon.Fish8 = dragon.Fish1i * (dragon.Time8);
                    dragon.Wood8 = dragon.Wood1i * (dragon.Time8);

                    dragon.FishTotal = dragon.Fish1i * (dragon.Timei);
                    dragon.WoodTotal = dragon.Wood1i * (dragon.Timei);


                   
                 
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message + " name " + dragon.DragonName); }

            return dragon;
        }

        private int getTimeMin(string p)
        {
            int min = 0;
  
             string d ="0";
             string h = "0";
             string m = "0";
             if (p.Contains("d"))
             {
                 d = p.Split('d')[0];
                 p = p.Split('d')[1];
             }

            if(p.Contains("h"))
            {
                h = p.Split('h')[0];
                p = p.Split('h')[1]; 
            }

            if(p.Contains("m"))
            {

               m = p.Split('m')[0];
                
            }

            min = Convert.ToInt32(m) + Convert.ToInt32(h) * 60 + Convert.ToInt32(d) * 60 * 24;
         
            return min;
        }
    }
}
