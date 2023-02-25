﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MDA.Archetypes.Party.Adress
{
    public record IsoCountryCode (string Name, string TwoLetterCode, string ThreeLetterCode, string NumericCode)
    {
        public static IsoCountryCode Afghanistan = new IsoCountryCode("Afghanistan", "AF", "AFG", "004");
        public static IsoCountryCode Albania = new IsoCountryCode("Albania", "AL", "ALB", "008");
        public static IsoCountryCode Algeria = new IsoCountryCode("Algeria", "DZ", "DZA", "012");
        public static IsoCountryCode AmericanSamoa = new IsoCountryCode("American Samoa", "AS", "ASM", "016");
        public static IsoCountryCode Andorra = new IsoCountryCode("Andorra", "AD", "AND", "020");
        public static IsoCountryCode Angola = new IsoCountryCode("Angola", "AO", "AGO", "024");
        public static IsoCountryCode Anguilla = new IsoCountryCode("Anguilla", "AI", "AIA", "660");
        public static IsoCountryCode Antarctica = new IsoCountryCode("Antarctica", "AQ", "ATA", "010");
        public static IsoCountryCode AntiguaandBarbuda = new IsoCountryCode("Antigua and Barbuda", "AG", "ATG", "028");
        public static IsoCountryCode Argentina = new IsoCountryCode("Argentina", "AR", "ARG", "032");
        public static IsoCountryCode Armenia = new IsoCountryCode("Armenia", "AM", "ARM", "051");
        public static IsoCountryCode Aruba = new IsoCountryCode("Aruba", "AW", "ABW", "533");
        public static IsoCountryCode Australia = new IsoCountryCode("Australia", "AU", "AUS", "036");
        public static IsoCountryCode Austria = new IsoCountryCode("Austria", "AT", "AUT", "040");
        public static IsoCountryCode Azerbaijan = new IsoCountryCode("Azerbaijan", "AZ", "AZE", "031");
        public static IsoCountryCode Bahamas = new IsoCountryCode("Bahamas", "BS", "BHS", "044");
        public static IsoCountryCode Bahrain = new IsoCountryCode("Bahrain", "BH", "BHR", "048");
        public static IsoCountryCode Bangladesh = new IsoCountryCode("Bangladesh", "BD", "BGD", "050");
        public static IsoCountryCode Barbados = new IsoCountryCode("Barbados", "BB", "BRB", "052");
        public static IsoCountryCode Belarus = new IsoCountryCode("Belarus", "BY", "BLR", "112");
        public static IsoCountryCode Belgium = new IsoCountryCode("Belgium", "BE", "BEL", "056");
        public static IsoCountryCode Belize = new IsoCountryCode("Belize", "BZ", "BLZ", "084");
        public static IsoCountryCode Benin = new IsoCountryCode("Benin", "BJ", "BEN", "204");
        public static IsoCountryCode Bermuda = new IsoCountryCode("Bermuda", "BM", "BMU", "060");
        public static IsoCountryCode Bhutan = new IsoCountryCode("Bhutan", "BT", "BTN", "064");
        public static IsoCountryCode Bolivia = new IsoCountryCode("Bolivia, Plurinational State of", "BO", "BOL", "068");
        public static IsoCountryCode Bonaire = new IsoCountryCode("Bonaire, Sint Eustatius and Saba", "BQ", "BES", "535");
        public static IsoCountryCode BosniaandHerzegovina = new IsoCountryCode("Bosnia and Herzegovina", "BA", "BIH", "070");
        public static IsoCountryCode Botswana = new IsoCountryCode("Botswana", "BW", "BWA", "072");
        public static IsoCountryCode BouvetIsland = new IsoCountryCode("Bouvet Island", "BV", "BVT", "074");
        public static IsoCountryCode Brazil = new IsoCountryCode("Brazil", "BR", "BRA", "076");
        public static IsoCountryCode BritishIndianOceanTerritory = new IsoCountryCode("British Indian Ocean Territory", "IO", "IOT", "086");
        public static IsoCountryCode BruneiDarussalam = new IsoCountryCode("Brunei Darussalam", "BN", "BRN", "096");
        public static IsoCountryCode Bulgaria = new IsoCountryCode("Bulgaria", "BG", "BGR", "100");
        public static IsoCountryCode BurkinaFaso = new IsoCountryCode("Burkina Faso", "BF", "BFA", "854");
        public static IsoCountryCode Burundi = new IsoCountryCode("Burundi", "BI", "BDI", "108");
        public static IsoCountryCode CaboVerde = new IsoCountryCode("Cabo Verde", "CV", "CPV", "132");
        public static IsoCountryCode Cambodia = new IsoCountryCode("Cambodia", "KH", "KHM", "116");
        public static IsoCountryCode Cameroon = new IsoCountryCode("Cameroon", "CM", "CMR", "120");
        public static IsoCountryCode Canada = new IsoCountryCode("Canada", "CA", "CAN", "124");
        public static IsoCountryCode CaymanIslands = new IsoCountryCode("Cayman Islands", "KY", "CYM", "136");
        public static IsoCountryCode CentralAfricanRepublic = new IsoCountryCode("Central African Republic", "CF", "CAF", "140");
        public static IsoCountryCode Chad = new IsoCountryCode("Chad", "TD", "TCD", "148");
        public static IsoCountryCode Chile = new IsoCountryCode("Chile", "CL", "CHL", "152");
        public static IsoCountryCode China = new IsoCountryCode("China", "CN", "CHN", "156");
        public static IsoCountryCode ChristmasIsland = new IsoCountryCode("Christmas Island", "CX", "CXR", "162");
        public static IsoCountryCode CocosIslands = new IsoCountryCode("Cocos (Keeling) Islands", "CC", "CCK", "166");
        public static IsoCountryCode Colombia = new IsoCountryCode("Colombia", "CO", "COL", "170");
        public static IsoCountryCode Comoros = new IsoCountryCode("Comoros", "KM", "COM", "174");
        public static IsoCountryCode Congo = new IsoCountryCode("Republic of the Congo", "CG", "COG", "178");
        public static IsoCountryCode CongoDemocraticRepublic = new IsoCountryCode("Democratic Republic of the Congo", "CD", "COD", "180");
        public static IsoCountryCode CookIslands = new IsoCountryCode("Cook Islands", "CK", "COK", "184");
        public static IsoCountryCode CostaRica = new IsoCountryCode("Costa Rica", "CR", "CRI", "188");
        public static IsoCountryCode CôtedIvoire = new IsoCountryCode("Côte d'Ivoire", "CI", "CIV", "384");
        public static IsoCountryCode Croatia = new IsoCountryCode("Croatia", "HR", "HRV", "191");
        public static IsoCountryCode Cuba = new IsoCountryCode("Cuba", "CU", "CUB", "192");
        public static IsoCountryCode Curaçao = new IsoCountryCode("Curaçao", "CW", "CUW", "531");
        public static IsoCountryCode Cyprus = new IsoCountryCode("Cyprus", "CY", "CYP", "196");
        public static IsoCountryCode Czechia = new IsoCountryCode("Czechia", "CZ", "CZE", "203");
        public static IsoCountryCode Denmark = new IsoCountryCode("Denmark", "DK", "DNK", "208");
        public static IsoCountryCode Djibouti = new IsoCountryCode("Djibouti", "DJ", "DJI", "262");
        public static IsoCountryCode Dominica = new IsoCountryCode("Dominica", "DM", "DMA", "212");
        public static IsoCountryCode DominicanRepublic = new IsoCountryCode("Dominican Republic", "DO", "DOM", "214");
        public static IsoCountryCode Ecuador = new IsoCountryCode("Ecuador", "EC", "ECU", "218");
        public static IsoCountryCode Egypt = new IsoCountryCode("Egypt", "EG", "EGY", "818");
        public static IsoCountryCode ElSalvador = new IsoCountryCode("El Salvador", "SV", "SLV", "222");
        public static IsoCountryCode EquatorialGuinea = new IsoCountryCode("Equatorial Guinea", "GQ", "GNQ", "226");
        public static IsoCountryCode Eritrea = new IsoCountryCode("Eritrea", "ER", "ERI", "232");
        public static IsoCountryCode Estonia = new IsoCountryCode("Estonia", "EE", "EST", "233");
        public static IsoCountryCode Eswatini = new IsoCountryCode("Eswatini", "SZ", "SWZ", "748");
        public static IsoCountryCode Ethiopia = new IsoCountryCode("Ethiopia", "ET", "ETH", "231");
        public static IsoCountryCode FalklandIslands= new IsoCountryCode("Falkland Islands (Malvinas)", "FK", "FLK", "238");
        public static IsoCountryCode FaroeIslands = new IsoCountryCode("Faroe Islands", "FO", "FRO", "234");
        public static IsoCountryCode Fiji = new IsoCountryCode("Fiji", "FJ", "FJI", "242");
        public static IsoCountryCode Finland = new IsoCountryCode("Finland", "FI", "FIN", "246");
        public static IsoCountryCode France = new IsoCountryCode("France", "FR", "FRA", "250");
        public static IsoCountryCode FrenchGuiana = new IsoCountryCode("French Guiana", "GF", "GUF", "254");
        public static IsoCountryCode FrenchPolynesia = new IsoCountryCode("French Polynesia", "PF", "PYF", "258");
        public static IsoCountryCode FrenchSouthernTerritories = new IsoCountryCode("French Southern Territories", "TF", "ATF", "260");
        public static IsoCountryCode Gabon = new IsoCountryCode("Gabon", "GA", "GAB", "266");
        public static IsoCountryCode Gambia = new IsoCountryCode("Gambia", "GM", "GMB", "270");
        public static IsoCountryCode Georgia = new IsoCountryCode("Georgia", "GE", "GEO", "268");
        public static IsoCountryCode Germany = new IsoCountryCode("Germany", "DE", "DEU", "276");
        public static IsoCountryCode Ghana = new IsoCountryCode("Ghana", "GH", "GHA", "288");
        public static IsoCountryCode Gibraltar = new IsoCountryCode("Gibraltar", "GI", "GIB", "292");
        public static IsoCountryCode Greece = new IsoCountryCode("Greece", "GR", "GRC", "300");
        public static IsoCountryCode Greenland = new IsoCountryCode("Greenland", "GL", "GRL", "304");
        public static IsoCountryCode Grenada = new IsoCountryCode("Grenada", "GD", "GRD", "308");
        public static IsoCountryCode Guadeloupe = new IsoCountryCode("Guadeloupe", "GP", "GLP", "312");
        public static IsoCountryCode Guam = new IsoCountryCode("Guam", "GU", "GUM", "316");
        public static IsoCountryCode Guatemala = new IsoCountryCode("Guatemala", "GT", "GTM", "320");
        public static IsoCountryCode Guernsey = new IsoCountryCode("Guernsey", "GG", "GGY", "831");
        public static IsoCountryCode Guinea = new IsoCountryCode("Guinea", "GN", "GIN", "324");
        public static IsoCountryCode GuineaBissau = new IsoCountryCode("Guinea-Bissau", "GW", "GNB", "624");
        public static IsoCountryCode Guyana = new IsoCountryCode("Guyana", "GY", "GUY", "328");
        public static IsoCountryCode Haiti = new IsoCountryCode("Haiti", "HT", "HTI", "332");
        public static IsoCountryCode HeardIslandandMcDonaldIslands = new IsoCountryCode("Heard Island and McDonald Islands", "HM", "HMD", "334");
        public static IsoCountryCode HolySee = new IsoCountryCode("Holy See", "VA", "VAT", "336");
        public static IsoCountryCode Honduras = new IsoCountryCode("Honduras", "HN", "HND", "340");
        public static IsoCountryCode HongKong = new IsoCountryCode("Hong Kong", "HK", "HKG", "344");
        public static IsoCountryCode Hungary = new IsoCountryCode("Hungary", "HU", "HUN", "348");
        public static IsoCountryCode Iceland = new IsoCountryCode("Iceland", "IS", "ISL", "352");
        public static IsoCountryCode India = new IsoCountryCode("India", "IN", "IND", "356");
        public static IsoCountryCode Indonesia = new IsoCountryCode("Indonesia", "ID", "IDN", "360");
        public static IsoCountryCode Iran = new IsoCountryCode("Iran, Islamic Republic of", "IR", "IRN", "364");
        public static IsoCountryCode Iraq = new IsoCountryCode("Iraq", "IQ", "IRQ", "368");
        public static IsoCountryCode Ireland = new IsoCountryCode("Ireland", "IE", "IRL", "372");
        public static IsoCountryCode IsleofMan = new IsoCountryCode("Isle of Man", "IM", "IMN", "833");
        public static IsoCountryCode Israel = new IsoCountryCode("Israel", "IL", "ISR", "376");
        public static IsoCountryCode Italy = new IsoCountryCode("Italy", "IT", "ITA", "380");
        public static IsoCountryCode Jamaica = new IsoCountryCode("Jamaica", "JM", "JAM", "388");
        public static IsoCountryCode Japan = new IsoCountryCode("Japan", "JP", "JPN", "392");
        public static IsoCountryCode Jersey = new IsoCountryCode("Jersey", "JE", "JEY", "832");
        public static IsoCountryCode Jordan = new IsoCountryCode("Jordan", "JO", "JOR", "400");
        public static IsoCountryCode Kazakhstan = new IsoCountryCode("Kazakhstan", "KZ", "KAZ", "398");
        public static IsoCountryCode Kenya = new IsoCountryCode("Kenya", "KE", "KEN", "404");
        public static IsoCountryCode Kiribati = new IsoCountryCode("Kiribati", "KI", "KIR", "296");
        public static IsoCountryCode KoreaNorth = new IsoCountryCode("North Korea", "KP", "PRK", "408");
        public static IsoCountryCode KoreaSouth = new IsoCountryCode("South Korea", "KR", "KOR", "410");
        public static IsoCountryCode Kuwait = new IsoCountryCode("Kuwait", "KW", "KWT", "414");
        public static IsoCountryCode Kyrgyzstan = new IsoCountryCode("Kyrgyzstan", "KG", "KGZ", "417");
        public static IsoCountryCode LaoPeopleDemocraticRepublic = new IsoCountryCode("Lao People's Democratic Republic", "LA", "LAO", "418");
        public static IsoCountryCode Latvia = new IsoCountryCode("Latvia", "LV", "LVA", "428");
        public static IsoCountryCode Lebanon = new IsoCountryCode("Lebanon", "LB", "LBN", "422");
        public static IsoCountryCode Lesotho = new IsoCountryCode("Lesotho", "LS", "LSO", "426");
        public static IsoCountryCode Liberia = new IsoCountryCode("Liberia", "LR", "LBR", "430");
        public static IsoCountryCode Libya = new IsoCountryCode("Libya", "LY", "LBY", "434");
        public static IsoCountryCode Liechtenstein = new IsoCountryCode("Liechtenstein", "LI", "LIE", "438");
        public static IsoCountryCode Lithuania = new IsoCountryCode("Lithuania", "LT", "LTU", "440");
        public static IsoCountryCode Luxembourg = new IsoCountryCode("Luxembourg", "LU", "LUX", "442");
        public static IsoCountryCode Macao = new IsoCountryCode("Macao", "MO", "MAC", "446");
        public static IsoCountryCode Madagascar = new IsoCountryCode("Madagascar", "MG", "MDG", "450");
        public static IsoCountryCode Malawi = new IsoCountryCode("Malawi", "MW", "MWI", "454");
        public static IsoCountryCode Malaysia = new IsoCountryCode("Malaysia", "MY", "MYS", "458");
        public static IsoCountryCode Maldives = new IsoCountryCode("Maldives", "MV", "MDV", "462");
        public static IsoCountryCode Mali = new IsoCountryCode("Mali", "ML", "MLI", "466");
        public static IsoCountryCode Malta = new IsoCountryCode("Malta", "MT", "MLT", "470");
        public static IsoCountryCode MarshallIslands = new IsoCountryCode("Marshall Islands", "MH", "MHL", "584");
        public static IsoCountryCode Martinique = new IsoCountryCode("Martinique", "MQ", "MTQ", "474");
        public static IsoCountryCode Mauritania = new IsoCountryCode("Mauritania", "MR", "MRT", "478");
        public static IsoCountryCode Mauritius = new IsoCountryCode("Mauritius", "MU", "MUS", "480");
        public static IsoCountryCode Mayotte = new IsoCountryCode("Mayotte", "YT", "MYT", "175");
        public static IsoCountryCode Mexico = new IsoCountryCode("Mexico", "MX", "MEX", "484");
        public static IsoCountryCode Micronesia = new IsoCountryCode("Micronesia, Federated States of", "FM", "FSM", "583");
        public static IsoCountryCode Moldova = new IsoCountryCode("Moldova, Republic of", "MD", "MDA", "498");
        public static IsoCountryCode Monaco = new IsoCountryCode("Monaco", "MC", "MCO", "492");
        public static IsoCountryCode Mongolia = new IsoCountryCode("Mongolia", "MN", "MNG", "496");
        public static IsoCountryCode Montenegro = new IsoCountryCode("Montenegro", "ME", "MNE", "499");
        public static IsoCountryCode Montserrat = new IsoCountryCode("Montserrat", "MS", "MSR", "500");
        public static IsoCountryCode Morocco = new IsoCountryCode("Morocco", "MA", "MAR", "504");
        public static IsoCountryCode Mozambique = new IsoCountryCode("Mozambique", "MZ", "MOZ", "508");
        public static IsoCountryCode Myanmar = new IsoCountryCode("Myanmar", "MM", "MMR", "104");
        public static IsoCountryCode Namibia = new IsoCountryCode("Namibia", "NA", "NAM", "516");
        public static IsoCountryCode Nauru = new IsoCountryCode("Nauru", "NR", "NRU", "520");
        public static IsoCountryCode Nepal = new IsoCountryCode("Nepal", "NP", "NPL", "524");
        public static IsoCountryCode Netherlands = new IsoCountryCode("Netherlands", "NL", "NLD", "528");
        public static IsoCountryCode NewCaledonia = new IsoCountryCode("New Caledonia", "NC", "NCL", "540");
        public static IsoCountryCode NewZealand = new IsoCountryCode("New Zealand", "NZ", "NZL", "554");
        public static IsoCountryCode Nicaragua = new IsoCountryCode("Nicaragua", "NI", "NIC", "558");
        public static IsoCountryCode Niger = new IsoCountryCode("Niger", "NE", "NER", "562");
        public static IsoCountryCode Nigeria = new IsoCountryCode("Nigeria", "NG", "NGA", "566");
        public static IsoCountryCode Niue = new IsoCountryCode("Niue", "NU", "NIU", "570");
        public static IsoCountryCode NorfolkIsland = new IsoCountryCode("Norfolk Island", "NF", "NFK", "574");
        public static IsoCountryCode NorthernMarianaIslands = new IsoCountryCode("Northern Mariana Islands", "MP", "MNP", "580");
        public static IsoCountryCode NorthMacedonia = new IsoCountryCode("North Macedonia", "MK", "MKD", "807");
        public static IsoCountryCode Norway = new IsoCountryCode("Norway", "NO", "NOR", "578");
        public static IsoCountryCode Oman = new IsoCountryCode("Oman", "OM", "OMN", "512");
        public static IsoCountryCode Pakistan = new IsoCountryCode("Pakistan", "PK", "PAK", "586");
        public static IsoCountryCode Palau = new IsoCountryCode("Palau", "PW", "PLW", "585");
        public static IsoCountryCode Palestine = new IsoCountryCode("Palestine, State of", "PS", "PSE", "275");
        public static IsoCountryCode Panama = new IsoCountryCode("Panama", "PA", "PAN", "591");
        public static IsoCountryCode PapuaNewGuinea = new IsoCountryCode("Papua New Guinea", "PG", "PNG", "598");
        public static IsoCountryCode Paraguay = new IsoCountryCode("Paraguay", "PY", "PRY", "600");
        public static IsoCountryCode Peru = new IsoCountryCode("Peru", "PE", "PER", "604");
        public static IsoCountryCode Philippines = new IsoCountryCode("Philippines", "PH", "PHL", "608");
        public static IsoCountryCode Pitcairn = new IsoCountryCode("Pitcairn", "PN", "PCN", "612");
        public static IsoCountryCode Poland = new IsoCountryCode("Poland", "PL", "POL", "616");
        public static IsoCountryCode Portugal = new IsoCountryCode("Portugal", "PT", "PRT", "620");
        public static IsoCountryCode PuertoRico = new IsoCountryCode("Puerto Rico", "PR", "PRI", "630");
        public static IsoCountryCode Qatar = new IsoCountryCode("Qatar", "QA", "QAT", "634");
        public static IsoCountryCode Réunion = new IsoCountryCode("Réunion", "RE", "REU", "638");
        public static IsoCountryCode Romania = new IsoCountryCode("Romania", "RO", "ROU", "642");
        public static IsoCountryCode RussianFederation = new IsoCountryCode("Russian Federation", "RU", "RUS", "643");
        public static IsoCountryCode Rwanda = new IsoCountryCode("Rwanda", "RW", "RWA", "646");
        public static IsoCountryCode SaintBarthélemy = new IsoCountryCode("Saint Barthélemy", "BL", "BLM", "652");
        public static IsoCountryCode SaintHelena = new IsoCountryCode("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", "654");
        public static IsoCountryCode SaintKittsandNevis = new IsoCountryCode("Saint Kitts and Nevis", "KN", "KNA", "659");
        public static IsoCountryCode SaintLucia = new IsoCountryCode("Saint Lucia", "LC", "LCA", "662");
        public static IsoCountryCode SaintMartin = new IsoCountryCode("Saint Martin (French part)", "MF", "MAF", "663");
        public static IsoCountryCode SaintPierreandMiquelon = new IsoCountryCode("Saint Pierre and Miquelon", "PM", "SPM", "666");
        public static IsoCountryCode SaintVincentandtheGrenadines = new IsoCountryCode("Saint Vincent and the Grenadines", "VC", "VCT", "670");
        public static IsoCountryCode Samoa = new IsoCountryCode("Samoa", "WS", "WSM", "882");
        public static IsoCountryCode SanMarino = new IsoCountryCode("San Marino", "SM", "SMR", "674");
        public static IsoCountryCode SaoTomeandPrincipe = new IsoCountryCode("Sao Tome and Principe", "ST", "STP", "678");
        public static IsoCountryCode SaudiArabia = new IsoCountryCode("Saudi Arabia", "SA", "SAU", "682");
        public static IsoCountryCode Senegal = new IsoCountryCode("Senegal", "SN", "SEN", "686");
        public static IsoCountryCode Serbia = new IsoCountryCode("Serbia", "RS", "SRB", "688");
        public static IsoCountryCode Seychelles = new IsoCountryCode("Seychelles", "SC", "SYC", "690");
        public static IsoCountryCode SierraLeone = new IsoCountryCode("Sierra Leone", "SL", "SLE", "694");
        public static IsoCountryCode Singapore = new IsoCountryCode("Singapore", "SG", "SGP", "702");
        public static IsoCountryCode SintMaarten = new IsoCountryCode("Sint Maarten (Dutch part)", "SX", "SXM", "534");
        public static IsoCountryCode Slovakia = new IsoCountryCode("Slovakia", "SK", "SVK", "703");
        public static IsoCountryCode Slovenia = new IsoCountryCode("Slovenia", "SI", "SVN", "705");
        public static IsoCountryCode SolomonIslands = new IsoCountryCode("Solomon Islands", "SB", "SLB", "090");
        public static IsoCountryCode Somalia = new IsoCountryCode("Somalia", "SO", "SOM", "706");
        public static IsoCountryCode SouthAfrica = new IsoCountryCode("South Africa", "ZA", "ZAF", "710");
        public static IsoCountryCode SouthGeorgiaandtheSouthSandwichIslands = new IsoCountryCode("South Georgia and the South Sandwich Islands", "GS", "SGS", "239");
        public static IsoCountryCode SouthSudan = new IsoCountryCode("South Sudan", "SS", "SSD", "728");
        public static IsoCountryCode Spain = new IsoCountryCode("Spain", "ES", "ESP", "724");
        public static IsoCountryCode SriLanka = new IsoCountryCode("Sri Lanka", "LK", "LKA", "144");
        public static IsoCountryCode Sudan = new IsoCountryCode("Sudan", "SD", "SDN", "729");
        public static IsoCountryCode Suriname = new IsoCountryCode("Suriname", "SR", "SUR", "740");
        public static IsoCountryCode SvalbardandJanMayen = new IsoCountryCode("Svalbard and Jan Mayen", "SJ", "SJM", "744");
        public static IsoCountryCode Sweden = new IsoCountryCode("Sweden", "SE", "SWE", "752");
        public static IsoCountryCode Switzerland = new IsoCountryCode("Switzerland", "CH", "CHE", "756");
        public static IsoCountryCode SyrianArabRepublic = new IsoCountryCode("Syrian Arab Republic", "SY", "SYR", "760");
        public static IsoCountryCode Taiwan = new IsoCountryCode("Taiwan, Province of China", "TW", "TWN", "158");
        public static IsoCountryCode Tajikistan = new IsoCountryCode("Tajikistan", "TJ", "TJK", "762");
        public static IsoCountryCode Tanzania = new IsoCountryCode("Tanzania, United Republic of", "TZ", "TZA", "834");
        public static IsoCountryCode Thailand = new IsoCountryCode("Thailand", "TH", "THA", "764");
        public static IsoCountryCode TimorLeste = new IsoCountryCode("Timor-Leste", "TL", "TLS", "626");
        public static IsoCountryCode Togo = new IsoCountryCode("Togo", "TG", "TGO", "768");
        public static IsoCountryCode Tokelau = new IsoCountryCode("Tokelau", "TK", "TKL", "772");
        public static IsoCountryCode Tonga = new IsoCountryCode("Tonga", "TO", "TON", "776");
        public static IsoCountryCode TrinidadandTobago = new IsoCountryCode("Trinidad and Tobago", "TT", "TTO", "780");
        public static IsoCountryCode Tunisia = new IsoCountryCode("Tunisia", "TN", "TUN", "788");
        public static IsoCountryCode Turkey = new IsoCountryCode("Turkey", "TR", "TUR", "792");
        public static IsoCountryCode Turkmenistan = new IsoCountryCode("Turkmenistan", "TM", "TKM", "795");
        public static IsoCountryCode TurksandCaicosIslands = new IsoCountryCode("Turks and Caicos Islands", "TC", "TCA", "796");
        public static IsoCountryCode Tuvalu = new IsoCountryCode("Tuvalu", "TV", "TUV", "798");
        public static IsoCountryCode Uganda = new IsoCountryCode("Uganda", "UG", "UGA", "800");
        public static IsoCountryCode Ukraine = new IsoCountryCode("Ukraine", "UA", "UKR", "804");
        public static IsoCountryCode UnitedArabEmirates = new IsoCountryCode("United Arab Emirates", "AE", "ARE", "784");
        public static IsoCountryCode UnitedKingdomofGreatBritainandNorthernIreland = new IsoCountryCode("United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", "826");
        public static IsoCountryCode UnitedStatesofAmerica = new IsoCountryCode("United States of America", "US", "USA", "840");
        public static IsoCountryCode UnitedStatesMinorOutlyingIslands = new IsoCountryCode("United States Minor Outlying Islands", "UM", "UMI", "581");
        public static IsoCountryCode Uruguay = new IsoCountryCode("Uruguay", "UY", "URY", "858");
        public static IsoCountryCode Uzbekistan = new IsoCountryCode("Uzbekistan", "UZ", "UZB", "860");
        public static IsoCountryCode Vanuatu = new IsoCountryCode("Vanuatu", "VU", "VUT", "548");
        public static IsoCountryCode VenezuelaBolivarianRepublic = new IsoCountryCode("Venezuela, Bolivarian Republic of", "VE", "VEN", "862");
        public static IsoCountryCode VietNam = new IsoCountryCode("Viet Nam", "VN", "VNM", "704");
        public static IsoCountryCode VirginIslandsBritish = new IsoCountryCode("Virgin Islands, British", "VG", "VGB", "092");
        public static IsoCountryCode VirginIslandsUS = new IsoCountryCode("Virgin Islands, U.S.", "VI", "VIR", "850");
        public static IsoCountryCode WallisandFutuna = new IsoCountryCode("Wallis and Futuna", "WF", "WLF", "876");
        public static IsoCountryCode WesternSahara = new IsoCountryCode("Western Sahara", "EH", "ESH", "732");
        public static IsoCountryCode Yemen = new IsoCountryCode("Yemen", "YE", "YEM", "887");
        public static IsoCountryCode Zambia = new IsoCountryCode("Zambia", "ZM", "ZMB", "894");
        public static IsoCountryCode Zimbabwe = new IsoCountryCode("Zimbabwe", "ZW", "ZWE", "716");
        public static IsoCountryCode AlandIslands = new IsoCountryCode("Aland Islands", "AX", "ALA", "248");

        public static IsoCountryCode[] All => typeof(IsoCountryCode)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(IsoCountryCode))
            .Select(f => f.GetValue(null) as IsoCountryCode)
            .OfType<IsoCountryCode>()
            .ToArray();
    }
}
