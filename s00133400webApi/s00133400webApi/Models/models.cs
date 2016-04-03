using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Constellation.Models
{
    class ConstDb : DbContext
    {
        public DbSet<Constellation> Constellations { get; set; }
        public DbSet<Star> Stars { get; set; }
        public ConstDb()
            : base("ConstDb")
        { }
    }
    public class Constellation
    {
        [Key]
        public int ConstellationId { get; set; }
        [Display(Name = "Constellation Name")]
        public string Title { get; set; }

        [Display(Name = "Alternative Name")]
        public string Title2 { get; set; }

        public virtual List<Star> Stars { get; set; }
    }

    public class Star
    {
        public int StarId { get; set; }
        public string Name { get; set; }
        public Constellation Constellation { get; set; }
    }

    class ConstDbInitialiser : DropCreateDatabaseAlways<ConstDb>
    {
        protected override void Seed(ConstDb context)
        {
            // seed the database
            context.Constellations.Add(new Constellation()
            {
                Title = "Andromeda",
                Title2 = "Princess of Ethiopia or the Chained Lady ",

                Stars = new List<Star>()
                {
                    new Star() {Name = " ALPHERATZ"},
                    new Star() {Name = "MIRACH"},
                    new Star() {Name = "ALMAAK"},
                    new Star() {Name = "Adhil"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Antlia",
                Title2 = "The Air Pump"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Apus",
                Title2 = "The Bird of Paradise"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Aquarius",
                Title2 = "The Water Bearer",

                Stars = new List<Star>()
                {
                    new Star() {Name = "SADALMELIK"},
                    new Star() {Name = "Sadalsuud"},
                    new Star() {Name = "Sadalachbia"},
                    new Star() {Name = "Skat"},
                    new Star() {Name = "Albali"},
                    new Star() {Name = "Ancha"},
                    new Star() {Name = "Situla"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Aquila",
                Title2 = "The Eagle",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALTAIR"},
                    new Star() {Name = "ALSHAIN"},
                    new Star() {Name = "TARAZED"},
                    new Star() {Name = "Deneb el Okab"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Aries",
                Title2 = "The Ram",

                Stars = new List<Star>()
                {
                    new Star() {Name = "HAMAL"},
                    new Star() {Name = "Sharatan"},
                    new Star() {Name = "Mesarthim"},
                    new Star() {Name = "Botein"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Ara",
                Title2 = "The Altar"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Auriga",
                Title2 = "The Charioteer",

                Stars = new List<Star>()
                {
                    new Star() {Name = "CAPELLA"},
                    new Star() {Name = "Menkalinan"},
                    new Star() {Name = "Al Anz"},
                    new Star() {Name = "Haedi"},
                    new Star() {Name = "Hoedus II"},
                    new Star() {Name = "Hassaleh"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Boötes",
                Title2 = "The Bear Driver",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ARCTURUS"},
                    new Star() {Name = "Nekkar"},
                    new Star() {Name = "Seginus"},
                    new Star() {Name = "IZAR"},
                    new Star() {Name = "Mufrid"},
                    new Star() {Name = "Asellus Primus"},
                    new Star() {Name = "Asellus Secondus"},
                    new Star() {Name = "Asellus Tertius"},
                    new Star() {Name = "Alkalurops"},
                    new Star() {Name = "Merga"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Caelum",
                Title2 = "The Sculptor's Chisel"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Camelopardalis",
                Title2 = "The Giraffe"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Cancer",
                Title2 = "The Crab",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Acubens"},
                    new Star() {Name = "Altarf"},
                    new Star() {Name = "Asellus Borealis"},
                    new Star() {Name = "Asellus Australis"},
                    new Star() {Name = "Tegmen"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Canes Venatici",
                Title2 = "The Hunting Dogs",

                Stars = new List<Star>()
                {
                    new Star() {Name = "COR CAROLI"},
                    new Star() {Name = "Chara"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Canis Major",
                Title2 = "The Greater Dog",

                Stars = new List<Star>()
                {
                    new Star() {Name = "SIRIUS"},
                    new Star() {Name = "Murzim"},
                    new Star() {Name = "Muliphen"},
                    new Star() {Name = "Wezen"},
                    new Star() {Name = "ADARA"},
                    new Star() {Name = "Furud"},
                    new Star() {Name = "Aludra"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Canis Minor",
                Title2 = "The Lesser Dog",

                Stars = new List<Star>()
                {
                    new Star() {Name = "PROCYON"},
                    new Star() {Name = "Gomeisa"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Capricornus",
                Title2 = "The Sea Goat",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Prima Giedi"},
                    new Star() {Name = "Secunda Giedi"},
                    new Star() {Name = "Dabih"},
                    new Star() {Name = "Nashira"},
                    new Star() {Name = "Deneb Algedi"},
                    new Star() {Name = "Alshat"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Carina",
                Title2 = "The Keel",

                Stars = new List<Star>()
                {
                    new Star() {Name = "CANOPUS"},
                    new Star() {Name = "Miaplacidus"},
                    new Star() {Name = "Avior"},
                    new Star() {Name = "Turais"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Cassiopeia",
                Title2 = "Queen of Ethiopia or Andromeda's Mother",

                Stars = new List<Star>()
                {
                    new Star() {Name = "SHEDIR"},
                    new Star() {Name = "Caph"},
                    new Star() {Name = "Ruchbah"},
                    new Star() {Name = "Segin"},
                    new Star() {Name = "Achird"},
                    new Star() {Name = "Marfak "}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Centaurus",
                Title2 = "The Centaur",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Rigel Kentaurus"},
                    new Star() {Name = "AGENA"},
                    new Star() {Name = "Menkent"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Cepheus",
                Title2 = "King of Ethiopia or Andromeda's Father",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALDERAMIN"},
                    new Star() {Name = "Alfirk"},
                    new Star() {Name = "Alrai"},
                    new Star() {Name = "Herschel's 'Garnet Star'"},
                    new Star() {Name = "Alkurhah"},
                    new Star() {Name = "Al Kalb al Rai"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Cetus",
                Title2 = "The Sea Monster",

                Stars = new List<Star>()
                {
                    new Star() {Name = "MENKAR"},
                    new Star() {Name = "DIPHDA"},
                    new Star() {Name = "Kaffaljidhma"},
                    new Star() {Name = "Baten Kaitos"},
                    new Star() {Name = "Dheneb"},
                    new Star() {Name = "Deneb Kaitos Shemali"},
                    new Star() {Name = "Menkar"},
                    new Star() {Name = " MIRA"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Chamaeleon",
                Title2 = "The Chameleon"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Circinus",
                Title2 = "The Compasses"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Columba",
                Title2 = "The Dove",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Phaet"},
                    new Star() {Name = "Wezn"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Coma Berenices",
                Title2 = "Berenice's Hair ",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Diadem"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Corona Austrina",
                Title2 = "The Southern Crown",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Alfecca Meridiana"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Corona Borealis",
                Title2 = "The Northern Crown",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALPHEKKA"},
                    new Star() {Name = "Nusakan"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Corvus",
                Title2 = "The Crow",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Alchiba"},
                    new Star() {Name = "Kraz"},
                    new Star() {Name = "Gienah Ghurab"},
                    new Star() {Name = "Algorab"},
                    new Star() {Name = "Minkar"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Crater",
                Title2 = "The Cup",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Alkes"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Crux",
                Title2 = "The Southern Cross",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ACRUX"},
                    new Star() {Name = "Becrux"},
                    new Star() {Name = "Gacrux"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Cygnus",
                Title2 = "The Swan or the Northern Cross",

                Stars = new List<Star>()
                {
                    new Star() {Name = "DENEB"},
                    new Star() {Name = "ALBIREO"},
                    new Star() {Name = "Sadr"},
                    new Star() {Name = "Gienah Cygni"},
                    new Star() {Name = "Azelfafage"},
                    new Star() {Name = "Ruchba"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Delphinus",
                Title2 = "The Dolphin",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Sualocin"},
                    new Star() {Name = "Rotanev"},
                    new Star() {Name = "Deneb Dulfim"}
                }

            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Dorado",
                Title2 = "The Swordfish"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Draco",
                Title2 = "The Dragon",

                Stars = new List<Star>()
                {
                    new Star() {Name = "THUBAN"},
                    new Star() {Name = "Rastaban"},
                    new Star() {Name = "ETAMIN"},
                    new Star() {Name = "Nodus Secundus"},
                    new Star() {Name = "Tyl"},
                    new Star() {Name = "Aldhibah"},
                    new Star() {Name = "Ed Asich"},
                    new Star() {Name = "Gianfar"},
                    new Star() {Name = "Arrakis"},
                    new Star() {Name = "Kuma"},
                    new Star() {Name = "Grumium"},
                    new Star() {Name = "Alsafi"},
                    new Star() {Name = "Dsiban"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Equuleus",
                Title2 = "The Foal",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Kitalpha"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Eridanus",
                Title2 = "The River",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ACHERNAR"},
                    new Star() {Name = "Cursa"},
                    new Star() {Name = "Zaurak"},
                    new Star() {Name = "Rana"},
                    new Star() {Name = "Zibal"},
                    new Star() {Name = "Azha"},
                    new Star() {Name = "ACAMAR"},
                    new Star() {Name = "Beid"},
                    new Star() {Name = "Keid"},
                    new Star() {Name = "Angetenar"},
                    new Star() {Name = "Theemim"},
                    new Star() {Name = "Sceptrum"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Fornax",
                Title2 = "The Laboratory Furnace",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Fornacis"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Gemini",
                Title2 = "The Twins",

                Stars = new List<Star>()
                {
                    new Star() {Name = "CASTOR"},
                    new Star() {Name = "POLLUX"},
                    new Star() {Name = "ALHENA"},
                    new Star() {Name = "Wasat"},
                    new Star() {Name = "Mebsuta"},
                    new Star() {Name = "Mekbuda"},
                    new Star() {Name = "Propus"},
                    new Star() {Name = "Tejat Posterior"},
                    new Star() {Name = "Alzirr"},
                    new Star() {Name = "Propus"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Grus",
                Title2 = "The Crane",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALNAIR"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Hercules",
                Title2 = "Hercules",

                Stars = new List<Star>()
                {
                    new Star() {Name = "RASALGETHI"},
                    new Star() {Name = "Kornephoros"},
                    new Star() {Name = "Sarin"},
                    new Star() {Name = "Marfik"},
                    new Star() {Name = "Maasym"},
                    new Star() {Name = "Kajam"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Horologium",
                Title2 = "The Clock"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Hydra",
                Title2 = "The Water Serpent",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALPHARD"},
                    new Star() {Name = "Al Minliar al Shuja"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Hydrus",
                Title2 = "The Water Snake",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Head of Hydrus"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Indus",
                Title2 = "The American Indian"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Lacerta",
                Title2 = "The Lizard"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Leo",
                Title2 = "The Lion",

                Stars = new List<Star>()
                {
                    new Star() {Name = "REGULUS"},
                    new Star() {Name = "DENEBOLA"},
                    new Star() {Name = "ALGIEBA"},
                    new Star() {Name = "Zosma"},
                    new Star() {Name = "Ras Elased Australis"},
                    new Star() {Name = "Adhafera"},
                    new Star() {Name = "Chort"},
                    new Star() {Name = "Al Minliar al Asad"},
                    new Star() {Name = "Alterf"},
                    new Star() {Name = "Ras Elased Borealis"},
                    new Star() {Name = "Subra"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Leo Minor",
                Title2 = "The Lion Cub",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Praecipua"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Lepus",
                Title2 = "The Hare",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ARNEB"},
                    new Star() {Name = "NIHAL"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Libra",
                Title2 = "The Beam Balance",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Zuben Elgenubi"},
                    new Star() {Name = "Zuben Elschemali"},
                    new Star() {Name = "Zuben Elakrab"},
                    new Star() {Name = "Zuben Elakribi"},
                    new Star() {Name = "Brachium"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Lupus",
                Title2 = "The Wolf"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Lynx",
                Title2 = "The Lynx",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Alsciaukat"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Lyra",
                Title2 = "The Lyre",

                Stars = new List<Star>()
                {
                    new Star() {Name = "VEGA"},
                    new Star() {Name = "Sheliak"},
                    new Star() {Name = "Sulafat"},
                    new Star() {Name = "Double Double"},
                    new Star() {Name = "Aladfar"},
                    new Star() {Name = "Alathfar"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Mensa",
                Title2 = "The Table Mountain"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Microscopium",
                Title2 = "The Microscope"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Monoceros",
                Title2 = "The Unicorn"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Musca",
                Title2 = "The Fly"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Norma",
                Title2 = "The Carpenter's Square"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Octans",
                Title2 = "The Octant",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Polaris Australis"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Ophiuchus",
                Title2 = "The Serpent Holder",

                Stars = new List<Star>()
                {
                    new Star() {Name = "RASALHAGUE"},
                    new Star() {Name = "Cebalrai"},
                    new Star() {Name = "Yed Prior"},
                    new Star() {Name = "Yed Posterior"},
                    new Star() {Name = "Sabik"},
                    new Star() {Name = "Marfic"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Orion",
                Title2 = "The Great Hunter",

                Stars = new List<Star>()
                {
                    new Star() {Name = "BETELGEUSE"},
                    new Star() {Name = "RIGEL"},
                    new Star() {Name = "BELLATRIX"},
                    new Star() {Name = "MINTAKA"},
                    new Star() {Name = "ALNILAM"},
                    new Star() {Name = "ALNITAK"},
                    new Star() {Name = "Nair al Saif"},
                    new Star() {Name = "SAIPH"},
                    new Star() {Name = "Meissa"},
                    new Star() {Name = "Tabit"},
                    new Star() {Name = "Thabit"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Pavo",
                Title2 = "The Peacock",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Peacock"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Pegasus",
                Title2 = "The Winged Horse",

                Stars = new List<Star>()
                {
                    new Star() {Name = "MARKAB"},
                    new Star() {Name = "SCHEAT"},
                    new Star() {Name = "ALGENIB"},
                    new Star() {Name = "ENIF"},
                    new Star() {Name = "Homam"},
                    new Star() {Name = "Matar"},
                    new Star() {Name = "Baham"},
                    new Star() {Name = "Salm"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Perseus",
                Title2 = "The Hero",

                Stars = new List<Star>()
                {
                    new Star() {Name = "MIRPHAK"},
                    new Star() {Name = "ALGOL"},
                    new Star() {Name = "Miram"},
                    new Star() {Name = "Menkib"},
                    new Star() {Name = "Atik"},
                    new Star() {Name = "Gorgonea Secunda"},
                    new Star() {Name = "Gorgonea Tertia"},
                    new Star() {Name = "Gorgonea Quarta"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Phoenix",
                Title2 = "The Phoenix",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ANKAA"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Pictor",
                Title2 = "The Painter's Easel"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Pisces",
                Title2 = "The Fishes",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Alrisha"},
                    new Star() {Name = "Fum al Samakah"},
                    new Star() {Name = "Torcularis Septentrionalis"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Piscis Austrinus",
                Title2 = "The Southern Fish",

                Stars = new List<Star>()
                {
                    new Star() {Name = "FOMALHAUT"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Puppis",
                Title2 = "The Stern",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Naos"},
                    new Star() {Name = "Azmidiske"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Pyxis",
                Title2 = "The Compass Box"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Reticulum",
                Title2 = "The Net "
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Sagitta",
                Title2 = "The Arrow",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Sham"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Sagittarius",
                Title2 = "The Archer",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Rukbat"},
                    new Star() {Name = "Arkab Prior"},
                    new Star() {Name = "Arkab Posterior"},
                    new Star() {Name = "Nash"},
                    new Star() {Name = "Kaus Meridionalis"},
                    new Star() {Name = "KAUS AUSTRALIS"},
                    new Star() {Name = "Ascella"},
                    new Star() {Name = "Kaus Borealis"},
                    new Star() {Name = "Ain al Rami"},
                    new Star() {Name = "Albaldah"},
                    new Star() {Name = "NUNKI"},
                    new Star() {Name = "Terebellum"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Scorpius",
                Title2 = "The Scorpion",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ANTARES"},
                    new Star() {Name = "Graffias"},
                    new Star() {Name = "Dschubba"},
                    new Star() {Name = "Sargas"},
                    new Star() {Name = "SHAULA"},
                    new Star() {Name = "Jabbah"},
                    new Star() {Name = "Grafias"},
                    new Star() {Name = "Alniyat"},
                    new Star() {Name = "Alniyat"},
                    new Star() {Name = "Lesath"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Sculptor",
                Title2 = "The Sculptor's Workshop"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Scutum",
                Title2 = "The Shield "
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Serpens",
                Title2 = "The Serpent",

                Stars = new List<Star>()
                {
                    new Star() {Name = "UNUKALHAI"},
                    new Star() {Name = "Alya"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Sextans",
                Title2 = "The Sextant ",
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Taurus",
                Title2 = "The Bull",

                Stars = new List<Star>()
                {
                    new Star() {Name = "ALDEBARAN"},
                    new Star() {Name = "ALNATH"},
                    new Star() {Name = "Hyadum I"},
                    new Star() {Name = "Hyadum II"},
                    new Star() {Name = "Ain"},
                    new Star() {Name = "ALCYONE"},
                    new Star() {Name = "Celaeno"},
                    new Star() {Name = "Electra"},
                    new Star() {Name = "Taygeta"},
                    new Star() {Name = "Maia"},
                    new Star() {Name = "Asterope"},
                    new Star() {Name = "Sterope II"},
                    new Star() {Name = " Merope"},
                    new Star() {Name = "Atlas"},
                    new Star() {Name = "Pleione"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Telescopium",
                Title2 = "The Telescope",
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Triangulum",
                Title2 = "The Triangle",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Metallah"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Triangulum Australe",
                Title2 = "The Southern Triangle"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Tucana",
                Title2 = "The Toucan"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Ursa Major",
                Title2 = "The Greater Bear",

                Stars = new List<Star>()
                {
                    new Star() {Name = "DUBHE"},
                    new Star() {Name = "MERAK"},
                    new Star() {Name = "PHAD"},
                    new Star() {Name = "MEGREZ"},
                    new Star() {Name = "ALIOTH"},
                    new Star() {Name = "MIZAR"},
                    new Star() {Name = "ALKAID"},
                    new Star() {Name = "Talitha"},
                    new Star() {Name = "Tania Borealis"},
                    new Star() {Name = "Tania Australis"},
                    new Star() {Name = "Alula Borealis"},
                    new Star() {Name = "Alula Australis"},
                    new Star() {Name = "Muscida "},
                    new Star() {Name = "ALCOR"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Ursa Minor",
                Title2 = "The Lesser Bear",

                Stars = new List<Star>()
                {
                    new Star() {Name = "POLARIS"},
                    new Star() {Name = "KOCAB"},
                    new Star() {Name = "Pherkad"},
                    new Star() {Name = "Yildun"},
                    new Star() {Name = "Pherkad Minor"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Vela",
                Title2 = "The Sail",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Suhail al Muhlif"},
                    new Star() {Name = "Alsuhail"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Virgo",
                Title2 = "The Maiden",

                Stars = new List<Star>()
                {
                    new Star() {Name = "SPICA"},
                    new Star() {Name = "Zavijah"},
                    new Star() {Name = "Porrima"},
                    new Star() {Name = "Auva"},
                    new Star() {Name = "VINDEMIATRIX"},
                    new Star() {Name = "Heze"},
                    new Star() {Name = "Zaniah"},
                    new Star() {Name = "Syrma"},
                    new Star() {Name = "Rijl al Awwa"}
                }
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Volans",
                Title2 = "The Flying Fish"
            });

            context.Constellations.Add(new Constellation()
            {
                Title = "Vulpecula",
                Title2 = "The Fox",

                Stars = new List<Star>()
                {
                    new Star() {Name = "Anser"}
                }
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }

    
}