
namespace E_APP.MODEL.TEST_MODEL.TEST_GET_MODEL
{
    internal class Test_Get_Model01
    {
        private static string[] first_name =
 {
    "Liam","Emma","Noah","Olivia","Oliver","Ava","Elijah","Isabella","William","Sophia",
    "James","Charlotte","Benjamin","Amelia","Lucas","Mia","Henry","Harper","Alexander","Evelyn",
    "Mason","Abigail","Michael","Emily","Ethan","Ella","Daniel","Avery","Jacob","Sofia",
    "Logan","Camila","Jackson","Aria","Levi","Scarlett","Sebastian","Victoria","Mateo","Madison",
    "Jack","Luna","Owen","Grace","Theodore","Chloe","Aiden","Penelope","Samuel","Layla",
    "Joseph","Riley","John","Zoey","David","Nora","Wyatt","Lily","Matthew","Eleanor",
    "Luke","Hannah","Asher","Lillian","Carter","Addison","Julian","Aubrey","Grayson","Ellie",
    "Leo","Stella","Jayden","Natalie","Gabriel","Zoe","Isaac","Leah","Lincoln","Hazel",
    "Anthony","Violet","Hudson","Aurora","Dylan","Savannah","Ezra","Audrey","Thomas","Brooklyn",
    "Charles","Bella","Josiah","Claire","Christopher","Skylar","Caleb","Lucy","Jaxon","Paisley",
    "Christian","Everly","Hunter","Anna"
};
        private static string[] last_name =
{
    "Smith","Johnson","Williams","Brown","Jones","Garcia","Miller","Davis","Rodriguez","Martinez",
    "Hernandez","Lopez","Gonzales","Wilson","Anderson","Thomas","Taylor","Moore","Jackson","Martin",
    "Lee","Perez","Thompson","White","Harris","Sanchez","Clark","Ramirez","Lewis","Robinson",
    "Walker","Young","Allen","King","Wright","Scott","Torres","Nguyen","Hill","Flores",
    "Green","Adams","Nelson","Baker","Hall","Rivera","Campbell","Mitchell","Carter","Roberts",
    "Gomez","Phillips","Evans","Turner","Diaz","Parker","Cruz","Edwards","Collins","Reyes",
    "Stewart","Morris","Morales","Murphy","Cook","Rogers","Gutierrez","Ortiz","Morgan","Cooper",
    "Peterson","Bailey","Reed","Kelly","Howard","Ramos","Kim","Cox","Ward","Richardson",
    "Watson","Brooks","Chavez","Wood","James","Bennett","Gray","Mendoza","Ruiz","Hughes",
    "Price","Alvarez","Castillo","Sanders","Patel","Myers","Long","Ross","Foster","Jimenez",
    "Powell","Jenkins","Perry","Russell","Sullivan","Bell","Coleman","Butler","Henderson","Barnes"
};
        private static string[] email_addresses =
{
    "Liam.Smith@gmail.com","Emma.Johnson@yahoo.com","Noah.Williams@hotmail.com","Olivia.Brown@outlook.com",
    "Oliver.Jones@gmail.com","Ava.Garcia@yahoo.com","Elijah.Miller@hotmail.com","Isabella.Davis@outlook.com",
    "William.Rodriguez@gmail.com","Sophia.Martinez@yahoo.com","James.Hernandez@hotmail.com","Charlotte.Lopez@outlook.com",
    "Benjamin.Gonzales@gmail.com","Amelia.Wilson@yahoo.com","Lucas.Anderson@hotmail.com","Mia.Thomas@outlook.com",
    "Henry.Taylor@gmail.com","Harper.Moore@yahoo.com","Alexander.Jackson@hotmail.com","Evelyn.Martin@outlook.com",
    "Mason.Lee@gmail.com","Abigail.Perez@yahoo.com","Michael.Thompson@hotmail.com","Emily.White@outlook.com",
    "Ethan.Harris@gmail.com","Ella.Sanchez@yahoo.com","Daniel.Clark@hotmail.com","Avery.Ramirez@outlook.com",
    "Jacob.Lewis@gmail.com","Sofia.Robinson@yahoo.com","Logan.Walker@hotmail.com","Camila.Young@outlook.com",
    "Jackson.Allen@gmail.com","Aria.King@yahoo.com","Levi.Wright@hotmail.com","Scarlett.Scott@outlook.com",
    "Sebastian.Torres@gmail.com","Victoria.Nguyen@yahoo.com","Mateo.Hill@hotmail.com","Madison.Flores@outlook.com",
    "Jack.Green@gmail.com","Luna.Adams@yahoo.com","Owen.Nelson@hotmail.com","Grace.Baker@outlook.com",
    "Theodore.Hall@gmail.com","Chloe.Rivera@yahoo.com","Aiden.Campbell@hotmail.com","Penelope.Mitchell@outlook.com",
    "Samuel.Carter@gmail.com","Layla.Roberts@yahoo.com","Joseph.Gomez@hotmail.com","Riley.Phillips@outlook.com",
    "John.Evans@gmail.com","Zoey.Turner@yahoo.com","David.Diaz@hotmail.com","Nora.Parker@outlook.com",
    "Wyatt.Cruz@gmail.com","Lily.Edwards@yahoo.com","Matthew.Collins@hotmail.com","Eleanor.Reyes@outlook.com",
    "Luke.Stewart@gmail.com","Hannah.Morris@yahoo.com","Asher.Morales@hotmail.com","Lillian.Murphy@outlook.com",
    "Carter.Cook@gmail.com","Addison.Rogers@yahoo.com","Julian.Gutierrez@hotmail.com","Aubrey.Ortiz@outlook.com",
    "Grayson.Morgan@gmail.com","Ellie.Cooper@yahoo.com","Leo.Peterson@hotmail.com","Stella.Bailey@outlook.com",
    "Jayden.Reed@gmail.com","Natalie.Kelly@yahoo.com","Gabriel.Howard@hotmail.com","Zoe.Ramos@outlook.com",
    "Isaac.Kim@gmail.com","Leah.Cox@yahoo.com","Lincoln.Ward@hotmail.com","Hazel.Richardson@outlook.com",
    "Anthony.Watson@gmail.com","Violet.Brooks@yahoo.com","Hudson.Chavez@hotmail.com","Aurora.Wood@outlook.com",
    "Dylan.James@gmail.com","Savannah.Bennett@yahoo.com","Ezra.Gray@hotmail.com","Audrey.Mendoza@outlook.com",
    "Thomas.Ruiz@gmail.com","Brooklyn.Hughes@yahoo.com","Charles.Price@hotmail.com","Bella.Alvarez@outlook.com",
    "Josiah.Castillo@gmail.com","Claire.Sanders@yahoo.com","Christopher.Patel@hotmail.com","Skylar.Myers@outlook.com",
    "Caleb.Long@gmail.com","Lucy.Ross@yahoo.com","Jaxon.Foster@hotmail.com","Paisley.Jimenez@outlook.com"
};
        private static string[] phone_numbers =
{
    "(212) 555-0173","(305) 555-0142","(415) 555-0198","(619) 555-0183","(713) 555-0129",
    "(312) 555-0167","(702) 555-0118","(404) 555-0135","(503) 555-0179","(602) 555-0156",
    "(214) 555-0131","(310) 555-0191","(516) 555-0187","(407) 555-0149","(786) 555-0124",
    "(617) 555-0163","(503) 555-0151","(954) 555-0175","(916) 555-0139","(801) 555-0181",
    "(305) 555-0153","(312) 555-0197","(713) 555-0171","(602) 555-0161","(425) 555-0147",
    "(404) 555-0185","(907) 555-0115","(719) 555-0165","(970) 555-0133","(928) 555-0193",
    "(317) 555-0148","(617) 555-0182","(832) 555-0195","(404) 555-0127","(702) 555-0159",
    "(212) 555-0141","(407) 555-0177","(214) 555-0158","(803) 555-0132","(303) 555-0168",
    "(801) 555-0178","(678) 555-0126","(516) 555-0194","(312) 555-0119","(713) 555-0179",
    "(415) 555-0138","(305) 555-0172","(602) 555-0146","(303) 555-0190","(818) 555-0154",
    "(321) 555-0176","(215) 555-0188","(503) 555-0145","(954) 555-0169","(512) 555-0117",
    "(619) 555-0192","(404) 555-0162","(480) 555-0180","(713) 555-0143","(212) 555-0155",
    "(702) 555-0164","(617) 555-0196","(305) 555-0121","(818) 555-0113","(214) 555-0170",
    "(516) 555-0144","(425) 555-0134","(602) 555-0189","(312) 555-0152","(803) 555-0116",
    "(954) 555-0174","(801) 555-0188","(907) 555-0130","(615) 555-0174","(210) 555-0199",
    "(409) 555-0160","(702) 555-0122","(305) 555-0114","(617) 555-0186","(323) 555-0149",
    "(408) 555-0174","(801) 555-0166","(312) 555-0199","(702) 555-0150","(214) 555-0123",
    "(516) 555-0184","(404) 555-0170","(305) 555-0188","(212) 555-0136","(714) 555-0142"
};
        private static string[] birthdays =
{
    "01/12/1985","02/28/1992","03/07/2001","04/21/1978","05/19/1999",
    "06/03/1988","07/15/1975","08/09/2004","09/27/1996","10/10/1990",
    "11/01/1982","12/23/1973","01/30/2000","02/14/1995","03/30/1987",
    "04/18/1979","05/05/2002","06/29/1991","07/07/1983","08/25/1997",
    "09/11/1989","10/16/1974","11/22/2003","12/09/1994","01/08/1980",
    "02/25/1986","03/13/2005","04/02/1998","05/27/1993","06/12/1977",
    "07/31/1984","08/19/2001","09/03/1999","10/29/1981","11/17/1996",
    "12/05/1988","01/24/1976","02/07/1993","03/22/2000","04/30/1982",
    "05/14/1989","06/26/1995","07/04/1987","08/13/1992","09/19/2004",
    "10/08/1986","11/29/1978","12/15/1991","01/03/1997","02/18/1983",
    "03/25/2003","04/11/1974","05/09/1990","06/17/2002","07/21/1985",
    "08/28/1998","09/14/1980","10/23/1994","11/06/2001","12/31/1987",
    "01/19/1996","02/04/1981","03/16/1999","04/27/2005","05/22/1979",
    "06/09/1992","07/12/2000","08/05/1984","09/29/1993","10/04/1988",
    "11/13/1977","12/20/2003","01/27/1991","02/10/2004","03/08/1982",
    "04/24/1997","05/16/1986","06/30/1975","07/09/1995","08/23/1990",
    "09/02/1983","10/18/2002","11/24/1989","12/01/1998","01/05/1973",
    "02/21/2001","03/31/1994","04/07/2005","05/11/1981","06/15/1990",
    "07/18/1992","08/27/1985","09/10/1976","10/26/2003","11/08/1999",
    "12/28/1993","01/20/1974","02/13/1987","03/29/2000","04/22/1984"
};
        private static string[] usernames =
{
    "StarGazer99","BlueSkyWalker","PixelPilot","NeonShadow","SilentEcho_7",
    "LunarFlame","CrimsonFox","TechNomad","MysticWolf23","ArcaneCoder",
    "SilverHorizon","NightRider_88","BinaryWizard","CyberSprinter","EchoStorm",
    "QuantumJumper","RoguePixel","VividDreamer","TurboPhantom","AlphaPulse",
    "ZenithVoyager","SkylineDrifter","CosmicSniper","LoneWanderer","FrostByte",
    "ThunderClap","SolarFlare_X","HyperNova","IronSentinel","CyberNova",
    "PixelRhythm","SilentRunner","DreamChaser","RiftWalker","AetherKnight",
    "MysticMarauder","NeonNomad","BlazeRunner","EchoBlitz","NightShade_X",
    "GalacticHero","NovaFusion","RadiantShadow","LunarWisp","SpectralKnight",
    "PhantomStriker","StormBreaker","VaporTrail","CelestialFire","ApexPredator",
    "CrystalWave","TurboSonic","NightPulse","IronPhalanx","GalacticMage",
    "ShadowCaster","FrostPhoenix","RogueSpecter","QuantumFlux","PixelSlinger",
    "CyberSage","StormChaser","VividVortex","SilentSpecter","AstralRider",
    "BlazeStorm","HyperKnight","EclipsePilot","SolarReaper","MysticScribe",
    "RiftStalker","ZenithBlade","NovaStrider","SkyRanger","ThunderBolt_21",
    "LunarShadow","SpectralWarden","IronClad","NebulaWhisper","PhantomGlow",
    "EchoKnight","GalacticVoyager","AetherMage","CyberWarlock","SolarKnight",
    "NightRogue","TurboSpecter","PixelRebel","CrimsonKnight","ZenithStorm",
    "BlazePhantom","CosmicWarden","SilentNova","RogueVortex","FrostRider",
    "QuantumKnight","NeonBlade","EchoWisp","ThunderRider","MysticVoyager"
};
        private static string[] passwords =
        {
    "A9x!mT6^pQ2z", "E7#uL9@fH4rV3", "D1$gT8*qK5nY0", "X8%tR2&hC9bU6",
    "P3@eW7#kM1vZ5", "R2^sQ6!jF8yN1", "B9*gV5&dH3kW7", "L4!zQ8@cS2nX0",
    "G7%wT1$qD9jC3", "M8#fK2!pR5uV6", "N4&yH7*xB0zL1", "T9!vD3%pQ6kF2",
    "Q5@hC8&bT1nM7", "Y7^kR2!dX9jZ3", "U6#zP9$qV4tH1", "C8!wF2%gS7xK5",
    "Z2#eG7&hQ9mR1", "K3%uW6$pT1yF8", "H6!pN9@fD3vC2", "J1^jT8!mQ4xN7",
    "W5&gX2#wB9tV3", "S8!dY4%pK7qH1", "F3@vR9&nM6uT2", "V7#kC1!xP8bQ5",
    "O9%tZ3&qD2wS7", "I4&yN8!fH6pQ1", "E8!kV5@sW2jT9", "P6@dL3%hR7xN0",
    "M1$qF9!gC8pT4", "R3&nK7^dY2vW5", "L9#tP6!mB1xH8", "T5%yE8@rN4wQ3",
    "Q2!bH7&vD9kS6", "U9#xW4*tF1pV2", "C7!gM2%aR8kL3", "N5@fJ9&cT1yP6",
    "D8#zY3!vH4tF1", "G6!rN2%pQ9bT7", "W2@kD8&fS5nC3", "H4!yX7%tJ0mV9",
    "X1^cP6@vR9tH2", "Y5#bF8!sN3wL7", "S9!kQ2%rD6nM4", "K8@zG1&hW5yT3",
    "F2!pV7%tC9bR6", "B3#jN8!dX1wQ5", "J6&fH2^sP4tV9", "E9!mW3%gK1xN8",
    "L2#nT1!hD8wQ7", "P8@dX5&vF3kS2", "V9$gZ4!tM7yC1", "N6!rQ1%pH3bT8",
    "C5#kJ9!vF2tW7", "D3!mG7%hP8xQ2", "T1&bC5!sY9kN4", "G4$zW8@pR2tM6",
    "R6!fD1%vX7cQ9", "H8#nF2!tB4yS3", "Q9!pM3%gK7tL2", "S1&xT6!nD8vF4",
    "M2@wH9&pC1rQ7", "K7^bV3!dT5yW8", "F8!zR4%hN2pC1", "W1&gX5!mP9tH7",
    "Y3#cT6%kR8pD1", "E4!nF9@vH7tC2", "J2@xP8&gQ6dS1", "L7%tH3!mV9kR5",
    "U5!fC2%nW8dQ7", "B7#rX1!pT6gH9", "Z1!pM4%fK8tD3", "O3&vR9!hC5yW2",
    "I9$kQ2!tN7pH4", "S4&dT8!mC1wR7", "Q6!bV3%gX9nH2", "F1@tM6&wD8pK5",
    "V2!cH9%rT4pQ8", "N8#xW3!dF5kC1", "C1!pR7%gT9mH2", "T3#vQ8!nC4dW6",
    "H5$kM9@pD3tX7", "X7!wF2%hR8cQ4", "P9!gV1%tB6kS3", "D2&nX8!fW1tH5",
    "M3#tC6!pD9mY8", "K1!bH7%gR4tF2", "G9!xQ2%hP7wD6", "R4!vN1%tC8pQ9",
    "L7#cG5!kT2pH3", "U8$kR9!mC4tF1", "O6!pW2%hR9dQ3", "I5&nC8!fT7pH2",
    "E1#xM4!tQ9rC8","Z8!dT2%pW7hX1","J9&gR1!mC5tF8","Y6$kH3!pT2vW9"
};

        private static Random rnd = new Random();
        public string random_first_name => first_name[rnd.Next(first_name.Length)];
        public string random_last_name => last_name[rnd.Next(last_name.Length)];
        public string random_email_addresses => email_addresses[rnd.Next(email_addresses.Length)];
        public string random_phone_numbers => phone_numbers[rnd.Next(phone_numbers.Length)];
        public string random_birthdays => birthdays[rnd.Next(birthdays.Length)];
        public string random_username => usernames[rnd.Next(usernames.Length)];
        public string random_passwords => passwords[rnd.Next(passwords.Length)];
    }
}
