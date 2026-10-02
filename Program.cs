// using System skal stå øverst fordi uden den kan vi ikke bruge Console, int.Parse osv
using System;
// using System.IO giver os adgang til File.ReadAllLines og File.WriteAllLines
// så vi kan læse og skrive til CSV filer
using System.IO;

// alt vores kode skal ligge inde i en klasse - det er sådan C# virker
class Program
{
    // Main er startpunktet - programmet begynder altid her
    // static void = den hører til klassen og returnerer ikke noget
    static void Main(string[] args)
    {
        // ===== OPRETTER 20 BRUGERE FRA START =====
        // opgaven kræver minimum 20 brugere på forhånd
        // vi sætter dem direkte ind i arrays fordi de skal være der når programmet starter
        // index starter fra 0 fordi arrays altid starter fra 0 i C#
        //
        // hver bruger fylder én plads i ALLE 8 arrays
        // fx bruger nr 1 (Anna Jensen) ligger i index 0:
        //   telefonnumre[0] = "12345678"
        //   fornavne[0] = "Anna"
        //   efternavne[0] = "Jensen"
        //   aldre[0] = 25
        //   adresser[0] = "Vestergade 1"
        //   postnumre[0] = "1456"
        //   byer[0] = "København"
        //   frekvenser[0] = 12   (12 = månedlig, 4 = kvartårlig, 1 = årlig)
        //
        // det er det der gør det til parallelle arrays - samme index = samme bruger

        // bruger nr 1 - Anna Jensen, 25 år, København, vil have nyhedsbrev hver måned (12)
        telefonnumre[0] = "12345678"; fornavne[0] = "Anna"; efternavne[0] = "Jensen"; aldre[0] = 25; adresser[0] = "Vestergade 1"; postnumre[0] = "1456"; byer[0] = "København"; frekvenser[0] = 12;
        telefonnumre[1] = "23456789"; fornavne[1] = "Bo"; efternavne[1] = "Nielsen"; aldre[1] = 32; adresser[1] = "Østergade 2"; postnumre[1] = "8000"; byer[1] = "Aarhus"; frekvenser[1] = 4;
        telefonnumre[2] = "34567890"; fornavne[2] = "Camilla"; efternavne[2] = "Hansen"; aldre[2] = 28; adresser[2] = "Nørregade 3"; postnumre[2] = "5000"; byer[2] = "Odense"; frekvenser[2] = 1;
        telefonnumre[3] = "45678901"; fornavne[3] = "David"; efternavne[3] = "Pedersen"; aldre[3] = 45; adresser[3] = "Søndergade 4"; postnumre[3] = "9000"; byer[3] = "Aalborg"; frekvenser[3] = 12;
        telefonnumre[4] = "56789012"; fornavne[4] = "Eva"; efternavne[4] = "Andersen"; aldre[4] = 19; adresser[4] = "Havnegade 5"; postnumre[4] = "6000"; byer[4] = "Kolding"; frekvenser[4] = 4;
        telefonnumre[5] = "67890123"; fornavne[5] = "Frederik"; efternavne[5] = "Larsen"; aldre[5] = 55; adresser[5] = "Skolegade 6"; postnumre[5] = "7100"; byer[5] = "Vejle"; frekvenser[5] = 1;
        telefonnumre[6] = "78901234"; fornavne[6] = "Gitte"; efternavne[6] = "Møller"; aldre[6] = 38; adresser[6] = "Kirkegade 7"; postnumre[6] = "4000"; byer[6] = "Roskilde"; frekvenser[6] = 12;
        telefonnumre[7] = "89012345"; fornavne[7] = "Hans"; efternavne[7] = "Sørensen"; aldre[7] = 22; adresser[7] = "Bredgade 8"; postnumre[7] = "3000"; byer[7] = "Helsingør"; frekvenser[7] = 4;
        telefonnumre[8] = "90123456"; fornavne[8] = "Ida"; efternavne[8] = "Rasmussen"; aldre[8] = 30; adresser[8] = "Strandvej 9"; postnumre[8] = "2900"; byer[8] = "Hellerup"; frekvenser[8] = 1;
        telefonnumre[9] = "11223344"; fornavne[9] = "Jakob"; efternavne[9] = "Thomsen"; aldre[9] = 41; adresser[9] = "Parkvej 10"; postnumre[9] = "2100"; byer[9] = "København Ø"; frekvenser[9] = 12;
        telefonnumre[10] = "22334455"; fornavne[10] = "Karen"; efternavne[10] = "Christensen"; aldre[10] = 27; adresser[10] = "Skovvej 11"; postnumre[10] = "2800"; byer[10] = "Lyngby"; frekvenser[10] = 4;
        telefonnumre[11] = "33445566"; fornavne[11] = "Lars"; efternavne[11] = "Madsen"; aldre[11] = 50; adresser[11] = "Åboulevarden 12"; postnumre[11] = "8200"; byer[11] = "Aarhus N"; frekvenser[11] = 1;
        telefonnumre[12] = "44556677"; fornavne[12] = "Mette"; efternavne[12] = "Olsen"; aldre[12] = 35; adresser[12] = "Rosenvej 13"; postnumre[12] = "5230"; byer[12] = "Odense M"; frekvenser[12] = 12;
        telefonnumre[13] = "55667788"; fornavne[13] = "Niels"; efternavne[13] = "Jørgensen"; aldre[13] = 29; adresser[13] = "Birkevej 14"; postnumre[13] = "2630"; byer[13] = "Taastrup"; frekvenser[13] = 4;
        telefonnumre[14] = "66778899"; fornavne[14] = "Olivia"; efternavne[14] = "Petersen"; aldre[14] = 23; adresser[14] = "Elmevej 15"; postnumre[14] = "2650"; byer[14] = "Hvidovre"; frekvenser[14] = 1;
        telefonnumre[15] = "77889900"; fornavne[15] = "Peter"; efternavne[15] = "Winther"; aldre[15] = 60; adresser[15] = "Granvej 16"; postnumre[15] = "2720"; byer[15] = "Vanløse"; frekvenser[15] = 12;
        telefonnumre[16] = "88990011"; fornavne[16] = "Rita"; efternavne[16] = "Lund"; aldre[16] = 33; adresser[16] = "Fyrrevej 17"; postnumre[16] = "2400"; byer[16] = "København NV"; frekvenser[16] = 4;
        telefonnumre[17] = "99001122"; fornavne[17] = "Søren"; efternavne[17] = "Berg"; aldre[17] = 47; adresser[17] = "Egevej 18"; postnumre[17] = "2500"; byer[17] = "Valby"; frekvenser[17] = 1;
        telefonnumre[18] = "10203040"; fornavne[18] = "Tina"; efternavne[18] = "Dam"; aldre[18] = 21; adresser[18] = "Poppelvej 19"; postnumre[18] = "2300"; byer[18] = "København S"; frekvenser[18] = 12;
        telefonnumre[19] = "50607080"; fornavne[19] = "Ulrik"; efternavne[19] = "Holm"; aldre[19] = 36; adresser[19] = "Kastanievej 20"; postnumre[19] = "2200"; byer[19] = "København N"; frekvenser[19] = 4;

        // vi sætter antalBrugere til 20 fordi vi lige har lagt 20 brugere ind
        // uden denne linje tror programmet der er 0 brugere
        antalBrugere = 20;

        // ===== CSV FIL =====
        // vi tjekker om data.csv filen allerede findes
        // hvis den findes læser vi brugere derfra i stedet for de hardkodede
        // hvis den IKKE findes bruger vi de 20 hardkodede og gemmer dem til filen
        if (File.Exists("data.csv"))
        {
            // filen findes - læs alle linjer ind i et string array
            // hver linje i filen er én bruger
            string[] linjer = File.ReadAllLines("data.csv");

            // nulstiller tælleren fordi vi nu læser fra fil i stedet
            antalBrugere = 0;

            // for-løkke der går igennem hver linje i filen
            for (int i = 0; i < linjer.Length; i++)
            {
                // Split deler linjen op ved hvert semikolon
                // fx "12345678;Anna;Jensen;25;Vestergade 1;1456;København;12"
                // bliver til et array: ["12345678", "Anna", "Jensen", "25", ...]
                string[] dele = linjer[i].Split(';');

                // vi tjekker at linjen har 8 dele (en for hver oplysning)
                // ellers er linjen forkert og vi springer den over
                if (dele.Length == 8)
                {
                    // sætter hver del ind i det rigtige array
                    telefonnumre[antalBrugere] = dele[0];
                    fornavne[antalBrugere] = dele[1];
                    efternavne[antalBrugere] = dele[2];
                    // int.Parse fordi alder og frekvens er tal men filen giver strings
                    aldre[antalBrugere] = int.Parse(dele[3]);
                    adresser[antalBrugere] = dele[4];
                    postnumre[antalBrugere] = dele[5];
                    byer[antalBrugere] = dele[6];
                    frekvenser[antalBrugere] = int.Parse(dele[7]);
                    // tæller op
                    antalBrugere++;
                }
            }
        }
        else
        {
            // filen findes IKKE - vi bruger de 20 hardkodede brugere
            // og gemmer dem til data.csv så de er der næste gang
            GemTilFil();
        }

        // vi sætter farver fordi programmet skal køre på en informationsstander
        // hvid tekst på blå baggrund er nemt at læse på en skærm
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        // Clear sætter farverne på hele skærmen - uden den ser man kun farven på ny tekst
        Console.Clear();

        // ===== HOVEDMENU =====
        // vi bruger en bool fordi vi har brug for at stoppe løkken senere
        // når brugeren vælger "Afslut" sætter vi koerer til false
        bool koerer = true;

        // vi bruger while fordi menuen skal komme frem igen og igen
        // en for-løkke ville ikke virke her fordi vi ikke ved hvor mange gange brugeren vil bruge menuen
        while (koerer)
        {
            // vi rydder skærmen hver gang så brugeren ikke ser gammel tekst
            Console.Clear();

            // viser firmanavn og menupunkter så brugeren ved hvad de kan vælge
            Console.WriteLine("CMIS - Nyhedsbrev Informationsstander");
            Console.WriteLine("Charlie Mørk Information Systems");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Tilmeld dig nyhedsbrev");
            Console.WriteLine("2. Admin login");
            Console.WriteLine("3. Afslut");
            Console.WriteLine("------------------------------------");

            // vi bruger Write i stedet for WriteLine fordi brugeren skal skrive på SAMME linje
            Console.Write("Vælg en mulighed: ");

            // ReadLine venter på brugeren trykker ENTER og giver os det de tastede
            // vi gemmer det i valg så vi kan tjekke det bagefter
            string valg = Console.ReadLine();

            // vi bruger switch fordi vi skal tjekke om valg er "1", "2" eller "3"
            // switch er pænere end at skrive if-else-if-else for hvert valg
            switch (valg)
            {
                // ===== CASE 1: OPRET BRUGER =====
                // denne case kører når brugeren taster 1
                case "1":
                    // rydder skærmen og viser overskrift
                    Console.Clear();
                    Console.WriteLine("Tilmeld dig nyhedsbrev");
                    Console.WriteLine("------------------------------------");

                    // if tjekker om arrayet er fyldt op
                    // antalBrugere tæller hvor mange vi har, maksAntal er 100
                    if (antalBrugere >= maksAntal)
                    {
                        // der er ikke plads til flere
                        Console.WriteLine("Der kan ikke oprettes flere brugere.");
                    }
                    // else kører hvis der ER plads
                    else
                    {
                        // beder brugeren om at skrive sit telefonnummer
                        Console.Write("Indtast telefonnummer (8 cifre): ");
                        // gemmer det brugeren skriver i variablen telefon
                        string telefon = Console.ReadLine();

                        // vi starter med at antage nummeret er gyldigt
                        // hvis vi finder en fejl sætter vi den til false
                        bool telefonGyldig = true;

                        // vi tjekker længden FØRST fordi et nummer der ikke er 8 tegn
                        // aldrig kan være et dansk telefonnummer
                        if (telefon == null || telefon.Length != 8)
                        {
                            telefonGyldig = false;
                        }
                        else
                        {
                            // vi bruger en for-løkke fordi vi skal tjekke HVERT tegn
                            // et telefonnummer må kun indeholde tal, ikke bogstaver
                            for (int i = 0; i < telefon.Length; i++)
                            {
                                // vi tjekker om tegnet ligger uden for '0' til '9'
                                // hvis ja er det et bogstav eller specialtegn og nummeret er ugyldigt
                                if (telefon[i] < '0' || telefon[i] > '9')
                                {
                                    telefonGyldig = false;
                                }
                            }
                        }

                        // ! betyder "ikke" - så !telefonGyldig betyder "telefon er IKKE gyldig"
                        if (!telefonGyldig)
                        {
                            // viser fejlbesked til brugeren
                            Console.WriteLine("Fejl: Telefonnummeret skal være præcis 8 cifre.");
                        }
                        else
                        {
                            // vi skal tjekke om nummeret allerede er registreret
                            // fordi opgaven siger man ikke må oprette samme nummer to gange
                            bool nummerFindes = false;

                            // vi bruger en for-løkke fordi vi skal sammenligne med ALLE brugere
                            for (int i = 0; i < antalBrugere; i++)
                            {
                                // == tjekker om to ting er ens
                                // sammenligner det indtastede nummer med nummeret i arrayet
                                if (telefonnumre[i] == telefon)
                                {
                                    // nummeret findes allerede
                                    nummerFindes = true;
                                }
                            }

                            if (nummerFindes)
                            {
                                // nummeret er der allerede - giv fejl
                                Console.WriteLine("Fejl: Dette telefonnummer er allerede registreret.");
                            }
                            else
                            {
                                // nummeret er ledigt - nu spørger vi om resten
                                // vi gemmer hver oplysning i sin egen variabel
                                // så vi kan lægge dem i arrays bagefter

                                // beder om fornavn - tjekker at det ikke er tomt og ikke indeholder tal
                                Console.Write("Indtast fornavn: ");
                                string fornavn = Console.ReadLine();

                                // tjekker om fornavn er tomt
                                bool fornavnGyldig = true;
                                if (fornavn == null || fornavn.Length == 0)
                                {
                                    fornavnGyldig = false;
                                }
                                else
                                {
                                    // for-løkke tjekker hvert tegn - et navn må ikke indeholde tal
                                    for (int i = 0; i < fornavn.Length; i++)
                                    {
                                        if (fornavn[i] >= '0' && fornavn[i] <= '9')
                                        {
                                            fornavnGyldig = false;
                                        }
                                    }
                                }

                                if (!fornavnGyldig)
                                {
                                    Console.WriteLine("Fejl: Fornavn må ikke være tomt eller indeholde tal.");
                                }
                                else
                                {
                                    // beder om efternavn - samme tjek som fornavn
                                    Console.Write("Indtast efternavn: ");
                                    string efternavn = Console.ReadLine();

                                    bool efternavnGyldig = true;
                                    if (efternavn == null || efternavn.Length == 0)
                                    {
                                        efternavnGyldig = false;
                                    }
                                    else
                                    {
                                        // for-løkke tjekker hvert tegn
                                        for (int i = 0; i < efternavn.Length; i++)
                                        {
                                            if (efternavn[i] >= '0' && efternavn[i] <= '9')
                                            {
                                                efternavnGyldig = false;
                                            }
                                        }
                                    }

                                    if (!efternavnGyldig)
                                    {
                                        Console.WriteLine("Fejl: Efternavn må ikke være tomt eller indeholde tal.");
                                    }
                                    else
                                    {
                                        // alder er speciel fordi ReadLine giver tekst men vi skal bruge et tal
                                        // derfor bruger vi int.Parse til at lave teksten om
                                        // men hvis brugeren skriver "abc" crasher int.Parse
                                        // try-catch fanger den fejl så programmet ikke lukker
                                        Console.Write("Indtast alder: ");
                                        string alderInput = Console.ReadLine();
                                        int alder = 0;
                                        bool alderGyldig = true;

                                        // try = prøv at køre denne kode
                                        try
                                        {
                                            // int.Parse("25") giver tallet 25
                                            // int.Parse("abc") fejler og hopper til catch
                                            alder = int.Parse(alderInput);

                                            // vi tjekker om alderen er realistisk
                                            // ingen er under 1 eller over 120 år gammel
                                            if (alder < 1 || alder > 120)
                                            {
                                                alderGyldig = false;
                                            }
                                        }
                                        // catch = hvis try fejlede, kør denne kode i stedet
                                        // uden catch ville programmet crashe og lukke
                                        catch
                                        {
                                            // int.Parse fejlede - det var ikke et tal
                                            alderGyldig = false;
                                        }

                                        if (!alderGyldig)
                                        {
                                            Console.WriteLine("Fejl: Alder skal være et tal mellem 1 og 120.");
                                        }
                                        else
                                        {
                                            // beder om adresse - tjekker at det ikke er tomt
                                            Console.Write("Indtast adresse: ");
                                            string adresse = Console.ReadLine();

                                            if (adresse == null || adresse.Length == 0)
                                            {
                                                Console.WriteLine("Fejl: Adresse må ikke være tom.");
                                            }
                                            else
                                            {
                                                // beder om postnummer - tjekker at det er 4 cifre
                                                // danske postnumre er altid 4 cifre
                                                Console.Write("Indtast postnummer (4 cifre): ");
                                                string postnummer = Console.ReadLine();

                                                // tjekker postnummer ligesom telefonnummer
                                                bool postGyldig = true;
                                                if (postnummer == null || postnummer.Length != 4)
                                                {
                                                    postGyldig = false;
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < postnummer.Length; i++)
                                                    {
                                                        if (postnummer[i] < '0' || postnummer[i] > '9')
                                                        {
                                                            postGyldig = false;
                                                        }
                                                    }
                                                }

                                                if (!postGyldig)
                                                {
                                                    Console.WriteLine("Fejl: Postnummer skal være 4 cifre.");
                                                }
                                                else
                                                {
                                                    // beder om by - tjekker at det ikke er tomt og ikke indeholder tal
                                                    Console.Write("Indtast by: ");
                                                    string by = Console.ReadLine();

                                                    bool byGyldig = true;
                                                    if (by == null || by.Length == 0)
                                                    {
                                                        byGyldig = false;
                                                    }
                                                    else
                                                    {
                                                        // for-løkke tjekker at by ikke indeholder tal
                                                        for (int i = 0; i < by.Length; i++)
                                                        {
                                                            if (by[i] >= '0' && by[i] <= '9')
                                                            {
                                                                byGyldig = false;
                                                            }
                                                        }
                                                    }

                                                    if (!byGyldig)
                                                    {
                                                        Console.WriteLine("Fejl: By må ikke være tom eller indeholde tal.");
                                                    }
                                                    else
                                                    {

                                                        // Console.WriteLine("") laver en tom linje
                                                        Console.WriteLine("");

                                                        // viser frekvens-valgmuligheder
                                                        Console.WriteLine("Hvor ofte vil du modtage nyhedsbrev?");
                                                        Console.WriteLine("12 = Hver måned");
                                                        Console.WriteLine("4  = Hver tredje måned");
                                                        Console.WriteLine("1  = En gang om året");
                                                        Console.Write("Vælg frekvens (12, 4 eller 1): ");
                                                        string frekvensInput = Console.ReadLine();
                                                        int frekvens = 0;
                                                        bool frekvensGyldig = false;

                                                        // try-catch igen - samme princip som med alder
                                                        try
                                                        {
                                                            frekvens = int.Parse(frekvensInput);
                                                            // tjekker om frekvens er en af de tre tilladte værdier
                                                            if (frekvens == 12 || frekvens == 4 || frekvens == 1)
                                                            {
                                                                frekvensGyldig = true;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            frekvensGyldig = false;
                                                        }

                                                        if (!frekvensGyldig)
                                                        {
                                                            Console.WriteLine("Fejl: Frekvens skal være 12, 4 eller 1.");
                                                        }
                                                        else
                                                        {
                                                            // ===== GEMMER BRUGEREN I ARRAYS =====
                                                            // antalBrugere er det næste ledige index
                                                            // fx hvis der er 20 brugere (index 0-19) er næste plads index 20
                                                            // vi bruger det som index fordi arrays starter fra 0
                                                            telefonnumre[antalBrugere] = telefon;
                                                            fornavne[antalBrugere] = fornavn;
                                                            efternavne[antalBrugere] = efternavn;
                                                            aldre[antalBrugere] = alder;
                                                            adresser[antalBrugere] = adresse;
                                                            postnumre[antalBrugere] = postnummer;
                                                            byer[antalBrugere] = by;
                                                            frekvenser[antalBrugere] = frekvens;

                                                            // vi tæller op fordi der nu er en bruger mere i arrayet
                                                            // uden denne linje ville næste bruger overskrive den forrige
                                                            antalBrugere++;

                                                            // gemmer alle brugere til CSV filen
                                                            // så den nye bruger også er der næste gang programmet starter
                                                            GemTilFil();

                                                            Console.WriteLine("Du er nu tilmeldt nyhedsbrevet!");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // venter på brugeren trykker en tast inden vi går tilbage til menuen
                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                    // Console.ReadKey venter på et vilkårligt tastetryk
                    Console.ReadKey();
                    // break afslutter denne case i switch
                    break;

                // ===== CASE 2: ADMIN LOGIN =====
                // denne case kører når brugeren taster 2
                case "2":
                    Console.Clear();
                    Console.WriteLine("Admin Login");
                    Console.WriteLine("------------------------------------");

                    // beder om password
                    Console.Write("Indtast password: ");
                    string password = Console.ReadLine();

                    // vi tjekker password fordi kun admin må se brugerdata
                    // det er et krav i opgaven at admin-menuen er beskyttet
                    if (password == adminPassword)
                    {
                        // admin-menuen har sin egen while-løkke
                        // fordi admin skal kunne vælge flere ting uden at logge ind igen
                        bool adminKoerer = true;

                        while (adminKoerer)
                        {
                            Console.Clear();
                            Console.WriteLine("Admin Menu");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("1. Find bruger");
                            Console.WriteLine("2. Vis alle brugere");
                            Console.WriteLine("3. Tilbage til hovedmenu");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Vælg en mulighed: ");

                            string adminValg = Console.ReadLine();

                            // admin switch - tjekker admin valg
                            switch (adminValg)
                            {
                                // ===== ADMIN CASE 1: FIND BRUGER =====
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Find Bruger");
                                    Console.WriteLine("------------------------------------");

                                    // beder brugeren om at skrive hvad de vil søge efter
                                    Console.Write("Indtast søgeord (navn eller tlf): ");
                                    string soegning = Console.ReadLine();

                                    // vi laver et EKSTRA array til at gemme hvilke brugere der matchede
                                    // fordi vi ikke ved på forhånd hvor mange der matcher
                                    // vi gemmer deres index-numre så vi kan finde dem i de rigtige arrays
                                    int[] fundne = new int[maksAntal];
                                    int antalFundne = 0;

                                    // vi SKAL bruge en for-løkke fordi vi skal tjekke HVER bruger
                                    // der er ingen genvej - vi skal igennem alle sammen
                                    for (int i = 0; i < antalBrugere; i++)
                                    {
                                        // Contains tjekker om en tekst indeholder en anden tekst
                                        // fx "Anna".Contains("nn") er true
                                        // StringComparison.OrdinalIgnoreCase gør at store/små bogstaver er lige
                                        // fx "Anna".Contains("anna") bliver også true
                                        // || betyder "eller" - hvis en af de tre er true matcher brugeren
                                        if (telefonnumre[i].Contains(soegning, StringComparison.OrdinalIgnoreCase) ||
                                            fornavne[i].Contains(soegning, StringComparison.OrdinalIgnoreCase) ||
                                            efternavne[i].Contains(soegning, StringComparison.OrdinalIgnoreCase))
                                        {
                                            // gemmer index-nummeret på den bruger der matchede
                                            fundne[antalFundne] = i;
                                            // tæller op
                                            antalFundne++;
                                        }
                                    }

                                    // tjekker om der blev fundet nogen
                                    if (antalFundne == 0)
                                    {
                                        Console.WriteLine("Ingen brugere fundet.");
                                    }
                                    else
                                    {
                                        // + sætter tekst og tal sammen
                                        Console.WriteLine("Fundet " + antalFundne + " bruger(e):");
                                        Console.WriteLine("");

                                        // ===== PAGINERING =====
                                        // vi viser kun 14 ad gangen fordi opgaven kræver det
                                        // uden paginering ville alle brugere scrolle forbi for hurtigt
                                        int soegSide = 0;
                                        bool soegViser = true;

                                        // while fordi vi ikke ved hvor mange sider der er på forhånd
                                        while (soegViser)
                                        {
                                            // regner ud hvilke brugere der skal vises
                                            // side 0: start=0, slut=14
                                            // side 1: start=14, slut=28
                                            int soegStart = soegSide * 14;
                                            int soegSlut = soegStart + 14;
                                            // hvis slut er større end antal fundne, sæt den ned
                                            if (soegSlut > antalFundne)
                                            {
                                                soegSlut = antalFundne;
                                            }

                                            // \t er et tab-tegn der laver mellemrum mellem kolonnerne
                                            Console.WriteLine("Tlf\t\tFornavn\t\tEfternavn\tAlder\tFrekvens");
                                            Console.WriteLine("---------------------------------------------------");

                                            // for-løkke der printer brugerne fra start til slut
                                            for (int i = soegStart; i < soegSlut; i++)
                                            {
                                                // idx er det rigtige index i bruger-arrayet
                                                // fordi fundne[i] gemmer det originale index
                                                int idx = fundne[i];

                                                // laver frekvens-tallet om til tekst man kan læse
                                                string frekTekst = "";
                                                if (frekvenser[idx] == 12) { frekTekst = "Månedlig"; }
                                                else if (frekvenser[idx] == 4) { frekTekst = "Kvartårlig"; }
                                                else if (frekvenser[idx] == 1) { frekTekst = "Årlig"; }

                                                // printer en linje med brugerens data
                                                // + sætter alle tekster sammen med \t tabs imellem
                                                Console.WriteLine(telefonnumre[idx] + "\t" + fornavne[idx] + "\t\t" + efternavne[idx] + "\t" + aldre[idx] + "\t" + frekTekst);
                                            }

                                            // regner ud hvor mange sider der er i alt
                                            // +13 og /14 runder op så vi altid får mindst 1 side
                                            int soegTotalSider = (antalFundne + 13) / 14;
                                            Console.WriteLine("");
                                            Console.WriteLine("Side " + (soegSide + 1) + " af " + soegTotalSider);

                                            // tjekker om der er flere brugere efter denne side
                                            if (soegSlut < antalFundne)
                                            {
                                                Console.Write("Tryk ENTER for næste side, eller Q for at stoppe: ");
                                                string soegInput = Console.ReadLine();
                                                // tjekker om brugeren tastede q eller Q
                                                if (soegInput == "q" || soegInput == "Q")
                                                {
                                                    // stopper paginerings-løkken
                                                    soegViser = false;
                                                }
                                                else
                                                {
                                                    // går til næste side
                                                    soegSide++;
                                                    Console.Clear();
                                                }
                                            }
                                            else
                                            {
                                                // vi er på sidste side - stop løkken
                                                soegViser = false;
                                            }
                                        }
                                    }

                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;

                                // ===== ADMIN CASE 2: VIS ALLE BRUGERE =====
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Vis Alle Brugere");
                                    Console.WriteLine("------------------------------------");

                                    // tjekker om der overhovedet er nogen brugere
                                    if (antalBrugere == 0)
                                    {
                                        Console.WriteLine("Der er ingen brugere.");
                                    }
                                    else
                                    {
                                        // paginering - samme princip som i find bruger
                                        int alleSide = 0;
                                        bool alleViser = true;

                                        while (alleViser)
                                        {
                                            int alleStart = alleSide * 14;
                                            int alleSlut = alleStart + 14;
                                            if (alleSlut > antalBrugere)
                                            {
                                                alleSlut = antalBrugere;
                                            }

                                            Console.WriteLine("Tlf\t\tFornavn\t\tEfternavn\tAlder\tFrekvens");
                                            Console.WriteLine("---------------------------------------------------");

                                            // for-løkke der printer alle brugere ud
                                            for (int i = alleStart; i < alleSlut; i++)
                                            {
                                                string frekTekst = "";
                                                if (frekvenser[i] == 12) { frekTekst = "Månedlig"; }
                                                else if (frekvenser[i] == 4) { frekTekst = "Kvartårlig"; }
                                                else if (frekvenser[i] == 1) { frekTekst = "Årlig"; }

                                                Console.WriteLine(telefonnumre[i] + "\t" + fornavne[i] + "\t\t" + efternavne[i] + "\t" + aldre[i] + "\t" + frekTekst);
                                            }

                                            int alleTotalSider = (antalBrugere + 13) / 14;
                                            Console.WriteLine("");
                                            Console.WriteLine("Side " + (alleSide + 1) + " af " + alleTotalSider);

                                            if (alleSlut < antalBrugere)
                                            {
                                                Console.Write("Tryk ENTER for næste side, eller Q for at stoppe: ");
                                                string alleInput = Console.ReadLine();
                                                if (alleInput == "q" || alleInput == "Q")
                                                {
                                                    alleViser = false;
                                                }
                                                else
                                                {
                                                    alleSide++;
                                                    Console.Clear();
                                                }
                                            }
                                            else
                                            {
                                                alleViser = false;
                                            }
                                        }

                                        // ===== GENNEMSNITSALDER =====
                                        // kalder funktionen BeregnGennemsnitsalder som ligger længere nede
                                        // den returnerer et tal med decimaler (double)
                                        // resultatet gemmes i variablen gnsAlder
                                        double gnsAlder = BeregnGennemsnitsalder();
                                        Console.WriteLine("");
                                        // printer gennemsnitsalderen ud
                                        Console.WriteLine("Gennemsnitsalder: " + gnsAlder + " år");
                                    }

                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;

                                // ===== ADMIN CASE 3: TILBAGE =====
                                case "3":
                                    // sætter adminKoerer til false
                                    // det stopper admin while-løkken og vi går tilbage til hovedmenuen
                                    adminKoerer = false;
                                    break;

                                // default kører hvis brugeren taster noget der ikke er 1, 2 eller 3
                                default:
                                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        // password var forkert
                        Console.WriteLine("Fejl: Forkert password.");
                        Console.WriteLine("Tryk på en tast for at fortsætte...");
                        Console.ReadKey();
                    }
                    break;

                // ===== CASE 3: AFSLUT =====
                case "3":
                    // sætter koerer til false
                    // det stopper hoved while-løkken
                    // programmet falder ned til bunden af Main og slutter
                    koerer = false;
                    break;

                // default kører hvis brugeren taster noget der ikke er 1, 2 eller 3
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    Console.WriteLine("Tryk på en tast for at fortsætte...");
                    Console.ReadKey();
                    break;
            }
        }
        // ===== PROGRAMMET SLUTTER HER =====
        // vi kommer herned når while-løkken stopper (koerer = false)
        // vi bruger IKKE Environment.Exit() fordi opgaven forbyder det
        // i stedet lader vi bare programmet køre til bunden af Main
        Console.Clear();
        Console.WriteLine("Tak fordi du brugte CMIS Nyhedsbrev.");
        Console.WriteLine("Programmet afsluttes...");
        // efter denne linje er der ikke mere kode - programmet stopper af sig selv
    }

    // ===== VARIABLER OG ARRAYS =====
    // static = de kan bruges overalt i klassen, ikke kun inde i Main

    // vi sætter maks til 100 fordi vi skal have en grænse for arrayet
    // arrays har fast størrelse - man kan ikke bare tilføje uendeligt
    static int maksAntal = 100;

    // vi bruger en tæller fordi vi skal vide hvor mange brugere der faktisk er
    // arrayet har plads til 100 men vi starter med 20
    static int antalBrugere = 0;

    // vi bruger PARALLELLE arrays - det betyder bruger nr 5 har sit telefonnummer
    // i telefonnumre[5], sit fornavn i fornavne[5], sin alder i aldre[5] osv
    // alle arrays deler samme index for samme bruger
    static string[] telefonnumre = new string[maksAntal];
    static string[] fornavne = new string[maksAntal];
    static string[] efternavne = new string[maksAntal];
    static int[] aldre = new int[maksAntal]; // int fordi alder er et heltal
    static string[] adresser = new string[maksAntal];
    static string[] postnumre = new string[maksAntal];
    static string[] byer = new string[maksAntal];
    static int[] frekvenser = new int[maksAntal]; // 12 = hver måned, 4 = hver 3. måned, 1 = årligt

    // password ligger her så det er nemt at ændre ét sted
    static string adminPassword = "Adminpass1";

    // ===== FUNKTION: BEREGN GENNEMSNITSALDER =====
    // opgaven kræver en matematisk funktion der returnerer en værdi
    // derfor er denne funktion den ENESTE der bruger return
    // static double = den returnerer et tal med decimaler
    // vi bruger double og ikke int fordi gennemsnit næsten altid har decimaler
    static double BeregnGennemsnitsalder()
    {
        // vi starter sum på 0 og lægger alle aldre til
        double sum = 0;

        // for-løkke fordi vi skal igennem ALLE brugere og lægge deres alder sammen
        for (int i = 0; i < antalBrugere; i++)
        {
            sum = sum + aldre[i];
        }

        // return sender resultatet tilbage til der hvor funktionen blev kaldt
        // division giver os gennemsnittet - fx 700 / 20 = 35.0
        // dette er det ENESTE sted i hele programmet vi bruger return
        // fordi opgaven siger return kun må bruges i funktioner der returnerer en værdi
        return sum / antalBrugere;
    }

    // ===== FUNKTION: GEM TIL CSV FIL =====
    // denne funktion gemmer alle brugere i arrays til en CSV fil
    // vi kalder den hver gang en ny bruger oprettes
    // static void = den returnerer ikke noget, den bare gemmer
    static void GemTilFil()
    {
        // laver et string array med plads til alle brugere
        // hver plads i arrayet bliver én linje i filen
        string[] linjer = new string[antalBrugere];

        // for-løkke der går igennem alle brugere
        for (int i = 0; i < antalBrugere; i++)
        {
            // sætter alle oplysninger sammen med semikolon imellem
            // fx "12345678;Anna;Jensen;25;Vestergade 1;1456;København;12"
            // vi bruger semikolon fordi det er standard i CSV filer
            linjer[i] = telefonnumre[i] + ";" + fornavne[i] + ";" + efternavne[i] + ";" + aldre[i] + ";" + adresser[i] + ";" + postnumre[i] + ";" + byer[i] + ";" + frekvenser[i];
        }

        // File.WriteAllLines skriver alle linjer til filen
        // hvis filen ikke findes laver den en ny
        // hvis filen allerede findes overskriver den den gamle
        File.WriteAllLines("data.csv", linjer);
    }
}