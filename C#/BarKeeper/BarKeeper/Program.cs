 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarKeeper
{
    class Program
    {
        private static List<Getränk> spritislist;
        private static List<Getränk> softdrinklist;
        private static List<Frucht> Früchtelist;
        private static List<Zutat> rezeptAngebot;
        static void Main(string[] args)
        {
            Init();

            Console.WriteLine("Hallo Willkommen, was möchten Sie gerne trinken:");

           
            string Check = "";
            while (Check != "q")
            {

                Check = GibEingabeVonKunde();
                if (Check == "q")
                {
                    Console.WriteLine(" Auf Wiedersehen");
                    Check = "";

                }


            }

            Console.ReadLine();
            Environment.Exit(0);
            //=============

        }
        /// <soummary>
        /// Erhalten Sie Text, dass der Kunde eine Bestellung oder eine Frage eingibt
        /// </summary>
        /// <returns></returns>
        private static string GibEingabeVonKunde()
        {
            
            bool istBestellung = true;            
            var eingabeText = Console.ReadLine();

            if (!String.IsNullOrEmpty(eingabeText)  && !eingabeText.ToLower().Trim().Equals("q"))//false
            {
                var Frage = "welche getränke sind im angebot?";
                if (eingabeText.ToLower().Trim().Equals(Frage))
                {
                    istBestellung = false;                    
                    for (int i = 0; i < rezeptAngebot.Count; i++)
                    {

                        Console.WriteLine(i + ") " + rezeptAngebot[i].Name);
                    }
                    Console.WriteLine("Was möchten Sie gerne trinken:");
                }
                //nur wenn eingabeText != "welches getränke sind im angebot?"
                if (istBestellung == true)
                {
                    Zutat kundenbestellung = new Zutat();
                    bool istVerfügbar = false;
                    bool find = false;

                    for (int i = 0; i < rezeptAngebot.Count; i++)
                    {
                        if (rezeptAngebot[i].Name.Trim().ToLower().Equals(eingabeText.Trim().ToLower()))
                        {

                            find = true;
                            kundenbestellung = rezeptAngebot[i];
                            break;
                        }
                    }

                    // wenn die Name von Bestellung bekannt ist
                    if (find == true)
                    {
                        //check die Anzahl von Früchte in Rezept
                        for (int j = 0; j < kundenbestellung.FrüchteList.Count(); j++)
                        {
                            // Frucht in rezept
                            var frucht = kundenbestellung.FrüchteList[j];

                            //Check verfügbare Früchte in Lager
                            for (int i = 0; i < Früchtelist.Count; i++)
                            {
                                if (frucht.Name == Früchtelist[i].Name)
                                {
                                    if (Früchtelist[i].Stück >= frucht.Stück)
                                    {
                                        istVerfügbar = true;
                                        Früchtelist[i].Stück -= frucht.Stück;
                                        break;
                                    }
                                    else
                                    {
                                        istVerfügbar = false;
                                        Console.WriteLine(Früchtelist[i].Name + " ist leider heute nicht mehr verfügbar ");
                                       
                                    }
                                }
                            }
                        }

                        if (istVerfügbar)
                        {

                            for (int j = 0; j < kundenbestellung.GetränkeList.Count(); j++)
                            {
                                // für check der Verfügbarket von Soft
                                var getränke = kundenbestellung.GetränkeList[j];

                                // check Soft
                                if (getränke.Type == GetränkeTypeEnum.Saftdrink)
                                {
                                    for (int i = 0; i < softdrinklist.Count; i++)
                                    {
                                        if (getränke.Name == softdrinklist[i].Name)
                                        {
                                            if (softdrinklist[i].verfügbareMenge >= getränke.verfügbareMenge)
                                            {
                                                istVerfügbar = true;
                                                softdrinklist[i].verfügbareMenge -= getränke.verfügbareMenge;
                                                break;
                                            }
                                            else
                                            {
                                                istVerfügbar = false;
                                                Console.WriteLine(softdrinklist[i].Name + "  leider ist heute nicht mehr verfügbar ");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < spritislist.Count; i++)
                                    {
                                        if (getränke.Name == spritislist[i].Name)
                                        {
                                            if (spritislist[i].verfügbareMenge >= getränke.verfügbareMenge)
                                            {
                                                istVerfügbar = true;
                                                spritislist[i].verfügbareMenge -= getränke.verfügbareMenge;
                                                break;
                                            }
                                            else
                                            {
                                                istVerfügbar = false;
                                                Console.WriteLine(spritislist[i].Name + "  leider ist heute nicht mehr verfügbar ");
                                            }
                                        }
                                    }
                                }
                            }
                            if (istVerfügbar)
                            {
                                Console.WriteLine("bitte Schön " + kundenbestellung.Name);
                            }
                            else
                            {
                                Console.WriteLine(kundenbestellung.Name + "  leider ist heute nicht mehr verfügbar ");
                            }

                        }
                        
                    }

                    //wenn die Name von betellung überhaupt nicht verfügbar ist
                    else
                    {
                        Console.WriteLine("ihre bestellung wurde nicht gefunden");
                    }

                }
            }



            //für beide 

            return eingabeText;

        }

        private static void Init()
        {
            spritislist = new List<Getränk>();
            softdrinklist = new List<Getränk>();
            Früchtelist = new List<Frucht>();
            rezeptAngebot = new List<Zutat>();

            spritislist.Add(new Getränk() { Name = "Gin", verfügbareMenge = 100, Type = GetränkeTypeEnum.Sprit });
            spritislist.Add(new Getränk() { Name = "wodka", verfügbareMenge = 100, Type = GetränkeTypeEnum.Sprit });
            spritislist.Add(new Getränk() { Name = "Whiskey", verfügbareMenge = 100, Type = GetränkeTypeEnum.Sprit });


            softdrinklist.Add(new Getränk() { Name = "Soda", verfügbareMenge = 100, Type = GetränkeTypeEnum.Saftdrink });
            softdrinklist.Add(new Getränk() { Name = "Tonic", verfügbareMenge = 100, Type = GetränkeTypeEnum.Saftdrink });
            softdrinklist.Add(new Getränk() { Name = "Orangensoft", verfügbareMenge = 100, Type = GetränkeTypeEnum.Saftdrink });

            Früchtelist.Add(new Frucht() { Name = "Limette", Stück = 20 });
            Früchtelist.Add(new Frucht() { Name = "Orange", Stück = 20 });
            Früchtelist.Add(new Frucht() { Name = "Oliven", Stück = 100 });


            Zutat z1 = new Zutat();

            z1.FrüchteList = new List<Frucht>();
            z1.GetränkeList = new List<Getränk>();
            z1.GetränkeList.Add(new Getränk() { Name = "Gin", verfügbareMenge = 2, Type = GetränkeTypeEnum.Sprit });
            z1.GetränkeList.Add(new Getränk() { Name = "Tonic", verfügbareMenge = 4, Type = GetränkeTypeEnum.Saftdrink });
            z1.FrüchteList.Add(new Frucht() { Name = "Limette", Stück = 1 });
            rezeptAngebot.Add(z1);
            z1.Name = "Gin-Tonic";


            Zutat z2 = new Zutat();
           
            z2.FrüchteList = new List<Frucht>();
            z2.GetränkeList = new List<Getränk>();
            z2.GetränkeList.Add(new Getränk() { Name = "Whiskey", verfügbareMenge = 2, Type = GetränkeTypeEnum.Sprit });
            z2.GetränkeList.Add(new Getränk() { Name = "Soda", verfügbareMenge = 4, Type = GetränkeTypeEnum.Saftdrink });
            z2.FrüchteList.Add(new Frucht() { Name = "Orange", Stück = 1 });
            rezeptAngebot.Add(z2);
            z2.Name = "Old-Fashioned";


            Zutat z3 = new Zutat();
            z3.FrüchteList = new List<Frucht>();
            z3.GetränkeList = new List<Getränk>();
            z3.GetränkeList.Add(new Getränk() { Name = "Wodka", verfügbareMenge = 3, Type = GetränkeTypeEnum.Sprit });
            z3.GetränkeList.Add(new Getränk() { Name = "Orangensaft", verfügbareMenge = 5, Type = GetränkeTypeEnum.Saftdrink });
            z3.FrüchteList.Add(new Frucht() { Name = "Oliven", Stück = 3 });
            rezeptAngebot.Add(z3);
            z3.Name = "Whodka-o";












        }
    }



}
