using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumController
{
    //Classを編集する場合は、ExtendUtilも修正すること。
    public enum Class
    {
        Ally, //仲間
        Alien, //エイリアン
        Broom, //ほうき
        Captain, //キャプテン
        Detective, //名探偵
        Deity, //神格
        Dragon, //ドラゴン
        DreamBorn, //ドリームボーン
        Fairy, //妖精
        FloodBorn, //フラッドボーン
        Hero, //ヒーロー
        Hunny, //ハニー
        Hyena, //ハイエナ
        Inventor, //発明家
        King, //王様
        Knight, //騎士
        Madrigal, //マドリガル家
        Mentor, //導き手
        Musketeer, //銃士
        Pirate, //海賊
        Prince,　//プリンス
        Princess, //プリンセス
        Puppy, //子犬
        Queen, //女王
        SevenDwarfs, //7人の小人
        StoryBorn, //ストーリーボーン
        Sorcerer, //魔法使い
        Tigger, //ティガー
        Titan, //タイタン
        Villain, //ヴィラン
    }

    public enum Colors
    {
        Amethyst,
        Amber,
        Emerald,
        Sapphire,
        Steel,
        Ruby,
    }

    //Expansionを編集する場合は、ExtendUtilも修正すること。
    public enum Expansion
    {
        TheFirstChapter,
        RiseOfTheFloodBorn,
        IntoTheInkLands,
        UrsulasReturn,
    }

    public enum KeywordAvility
    {
        Bodyguard,
        Challenger2, //果敢+2
        Challenger3, //果敢+3
        Challenger4, //果敢+4
        Evasive, //回避
        Shift2, //変身2
        Shift3, //変身3
        Shift4, //変身4
        Shift5, //変身5
        Shift6, //変身6
        ShiftDiscardAnActionCard, //変身 ： アクション・カードを１枚捨てる
        ShiftDiscardAnCharacterCard, //変身:キャラクター・カードを１枚捨てる
        ShiftDiscardAnSongCard, //変身:歌・カードを１枚捨てる
        ShiftDiscard2Cards, //変身:カードを２枚捨てる
        Singer3, //歌声3
        Singer4, //歌声4
        Singer5, //歌声5
        Singer7, //歌声7
        Singer9, //歌声9
        SingTogether6, //合唱6
        SingTogether7, //合唱7
        SingTogether8, //合唱8
        SingTogether10, //合唱10
        Support, //支援
        Reckless, //暴勇
        Resist1, //耐久+1
        Resist2, //耐久+2
        Rush, //突進
        Ward, //魔除

    }

    public enum OKBtnParamater
    {
        FailedFileCreate,
        NamelessError,
        NotFoundSecureDataPass,
        SuccessFileCreate,
    }

    //Titleを編集する場合は、ExtendUtilも修正すること。
    public enum Title
    {
        None,
        Aladdin, //アラジン
        AliceInWonderland, //不思議の国のアリス
        AtlantisTheLostEmpire, //アトランティス 失われた帝国
        BeautyAndTheBeast, //美女と野獣
        Cinderella, //シンデレラ
        DuckTales, //ダックテイル
        Encanto, //ミラベルと魔法だらけの家
        Fantasia, //ファンタジア
        Frozen, //アナと雪の女王
        Hercules, //ヘラクレス
        TaleSpin, //テイルスピン
        Tangled, //塔の上のラプンツェル
        TheEmperorsNewGroove, //ラマになった王様
        TheGreatMouseDetective, //オリビアちゃんの大冒険
        TheJungleBook, //ジャングル・ブック
        TheLionKing, //ライオンキング
        TheLittleMermaid,  //リトル・マーメイド
        ThePrincessAndTheFrog, //プリンセスと魔法のキス
        TheRescuers, // ビアンカの大冒険
        TheSwordInTheStone, //王様の剣
        TheTaleOfAMouse, //The Tale of a Mouse
        TreasurePlanet, //トレジャー・プラネット
        LiloAndStitch, //リロ・アンド・スティッチ
        Lorcana, //ロルカナ
        MickeyMouse, //ミッキーマウス
        Moana, //モアナと伝説の海
        Mulan, //ムーラン
        OneHundredAndOneDalmatians, //101匹わんちゃん
        PeterPan, //ピーターパン
        Pinocchio, //ピノキオ
        RayaAndTheLastDragon, //ラーヤと龍の王国
        RobinHood, //ロビン・フッド
        SleepingBeauty, //眠れる森の美女
        SnowWhiteAndTheSevenDwarfs, //白雪姫
        WinnieThePooh, //クマのプーさん
        WreckItRalph, //シュガーラッシュ
        Zootopia, //ズートピア
    }

    public enum Type
    {
        Action,
        Character,
        Location,
        Item,
        Song,
    }

    public enum Rare
    {
        Common,
        Uncommon,
        Rare,
        SuperRare,
        Legendary,
        Enchanted,
        Iconic,
        Promo,
    }

    public enum YesOrNoParamater
    {
        ConfirmOverWrite,
        ConfirmOverWrite_OverWriteBtn,
    }

    public enum Illustrator
    {
        AdamBunch, //Adam Bunch
        AdamFenton, //Adam Fenton
        AdamFord, //Adam Ford
        AdrianneGumaya, //AdrianneGumaya
        AishaDurmagambetova, //Aisha Durmagambetova
        AlanBatson, //Alan Batson
        AlexAccorsi, //AlexAccorsi
        AlexAccorsiAndKendallHale, //Alex Accorsi/ Kendall Hale
        AlexandriaNeonakis, //Alexandria Neonakis
        AlexShin, //Alex Shin
        AlibethZermeno, //Alibeth Zermeno
        AlicePisoni, //Alice Pisoni
        AlicePisoniAndWhitneyPollett, //Alice Pisoni / Whitney Pollett
        AmberKommavongsa, //Amber Kommavongsa
        AndersonMahanski, //Anderson Mahanski
        AndreaFemerstrand, //Andrea Femerstrand
        AndreaParisi, //Andrea Parisi
        AndreasRocha, //Andreas Rocha
        AndreyChumak, //Andrey Chumak
        AndrewPena, //Andrew Pena
        AndrewTrabbold, //Andrew Trabbold
        AngelinaSpikeRicardo, //Angelina Spike Ricardo
        AngieSimpson, //Angie Simpson
        AnhDang, //Anh Dang
        AnnaRudAndAnnnaStosik, //Anna Rud / Annna Stosik
        AnnaRudAndLivioCacciatore, //Anna Rud / Livio Cacciatore
        AnnaStosik, //Anna Stosik
        AntoineCouttolenc, //Antoine Couttolenc
        AntoniaFlechsig, //AntoniaFlechsig
        AriannaRea, //AriannaRea
        AubreyArcher, //Aubrey Archer
        BeverlyArceAndJonathanLivslyst, //Beverly Arce / Jonathan Livslyst
        BrianKesinger, //Brian Kesinger
        BriannaGarcia, //Brianna Garcia
        BrianWeisz, //Brian Weisz
        BrittneyHackett, //Brittney Hackett
        BrynJones, //Bryn Jones
        BillRobinson, //Bill Robinson
        BillyWimblett, //Billy Wimblett
        CaclieCarre, //Caclie Carre
        CamKendell, //Cam Kendell
        CanerSoylu, //CanerSoylu
        CarlosLuzzi, //CarlosLuzzi
        CarlosRuiz, //Carlos Ruiz
        CarminePucci, //Carmine Pucci
        CarminePucciAndLeonardoGiammichele, //Carmine Pucci / Leonardo Giammichele
        CaseyRobin, //Casey Robin
        CecileCarreAndAnnaStosik, //Cecile Carre / Anna Stosik
        ClioWolfensberger, //ClioWolfensberger
        ConnieKangAndJackieDroujiko, //Connie Kang / Jackie Droujiko
        Cookie, //Cookie
        CoryGodbey, //CoryGodbey
        CristianRomero, //Cristian Romero
        DavAugereau, //Dav Augereau
        DavAugereauAndGiuliaRiva, //Dav Augereau / Giulia Riva
        DaveAlvarezAndAlicePisoni, //Dave Alvarez / Alice Pisoni
        DaveBeauchene, //DaveBeauchene
        DefneTozum, //Defne Tozum
        DefneTozumAndDennyMinonne, //Defne Tozum / Denny Minonne
        DefneTozumAndLivioCacciatore, //Defne Tozum / Livio Cacciatore
        DennyMinonne, //Denny Minonne
        DevinYang, //DevinYang
        DiogoSaito, //Diogo Saito
        DonAguillo, //Don Aguillo
        DustinPanzino, //Dustin Panzino
        DuyenNguyenAndAubreyArcher, //Duyen Nguyen / Aubrey Archer
        DylanBonner, //Dylan Bonner
        E_MeleranciAndL_Giammichele, //E. Meleranci / L. Giammichele
        EllieHorie, //Ellie Horie
        EllieHorieAndJenniferPark, //Ellie Horie / Jennifer Park
        ElliotBaumAndVivTanner, //Elliot Baum / Viv Tanner
        ElliotBocxtaele, //Elliot Bocxtaele
        ElodieMondoloni, //Elodie Mondoloni
        EmilyAbeydeera, //EmilyAbeydeera
        ErikaWiseman, //Erika Wiseman
        EriWelli, //Eri Welli
        EriWelliAndSamBurley, //Eri Welli / Sam Burley
        EtienneSavoie, //Etienne Savoie
        EvanaKisa, //EvanaKisa
        EvanaKisAndJochemVanGool, //Evana Kis / Jochem van Gool
        EvanaKisaAndLivioCacciatore, //Evana Kisa / Livio Cacciatore
        EvaWidermann, //Eva Widermann
        EverGalvezAndAnnaStosik, //Ever Galvez / Anna Stosik
        FedericoMCugliari, //Federico M. Cugliari
        FilipeLaurentino, //Filipe Laurentino
        GabrielAngelo, //Gabriel Angelo
        GabrielRomero, //GabrielRomero
        GakuKumatori, //Gaku Kumatori
        GiuliaRiva, //Giulia Riva
        GiuseppeDiMaio, //Giuseppe di Maio
        GonzaloKenny, //Gonzalo Kenny
        GusGadgetAndLeonardoGiammichele, //GusGadget / Leonardo Giammichele
        GraceTran, //Grace Tran
        HadjieJoos, //Hadjie Joos
        HedvigHaggman_Sund, //Hadvig Haggman-Sund
        HeidiNeunhoffer, //Heidi Neunhoffer
        HedvigH_S, //Hedvig H-S
        HyunaLee, //HyunaLee
        IanMacDonald, //Ian MacDonald
        IsabellaCeravolo, //IsabellaCeravolo
        IsaiahMesq, //Isaiah Mesq
        JackieDroujiko, //Jackie Droujiko
        JacobMcAlister, //Jacob McAlister
        JakeParker, //Jake Parker
        JaredMathews, //Jared Mathews
        JaredNickerl, //JaredNickerl
        JaredNickerlAndAlexAccorsi, //Jared Nickerl / Alex Accorsi
        JaredNickerlAndAlicePisoni, //Jared Nickerl / Alice Pisoni
        JeremyAdams, //Jeremy Adams
        JaviSalas, //Javi Salas
        JavierSalas, //JavierSalas
        JeannePlounevez, //Jeanne Plounevez
        JeffMerghart, //Jeff Merghart
        JeffMurchie, //JeffMurchie
        JennaGray, //Jenna Gray
        JenniferGheduzziAndLivioCacciatore, //Jennifer Gheduzzi / Livio Cacciatore
        JiahuiEvaGao, //Jiahui Eva Gao
        JimmyLo, //Jimmy Lo
        JochemVanGool, //Jochem van Gool
        JohnLoren, //John Loren
        JonasPetrauskas, //Jonas Petrauskas
        JonathanLiyslyst, //Jonathan Liyslyst
        JonDenskAndHayleyEvans, //Jon Densk / Hayley Evans
        JuanDiegoLeon, //Juan Diego Leon
        JulieVu, //Julie Vu
        JustinRunfola, //Justin Runfola
        LaurenWalsh, //Lauren Walsh
        LinhDang, //Linh Dang
        KamilMurzynAndEriWell, //Kamil Murzyn / Eri Well
        KasiaBrzezinska, //Kasia Brzezinska
        Kapik, //Kapik
        KaitlinCuthbertson, //Kaitlin Cuthbertson
        KamilMurzyn, //KamilMurzyn
        KendallHale, //Kendall Hale
        KendallHaleAndAnhDang, //Kendall Hale / Anh Dang
        KennethAnderson, //Kenneth Anderson
        KevinHong, //Kevin Hong
        KierstenHale, //Kiersten Hale
        Koni, //Koni
        KristinaChori, //KristinaChori
        KristinaChouriAndMarianaMoreno, //Kristina Chouri / Mariana Moreno
        KuyaJaypi, //Kuya Jaypi
        LadyShalirin, //LadyShalirin
        LaurenLevering, //Lauren Levering
        LeonardoGiammichele, //LeonardoGiammichele
        LisanneKoeteeuw, //Lisanne Koeteeuw
        LissetteCarrera, //Lissette Carrera
        LouisJones, //Louis Jones
        LucaPinelli, //Luca Pinelli
        LuisHuerta, //Luis Huerta
        M_K_Manderson_JochemVanGool, //M. K. Manderson / Jochem van Gool
        M_RobertDaviesAndL_Giammichele, //M. Robert Davies / L. Giammichele
        MaddieShilt, //Maddie Shilt
        ManeKandalyanManderson, //ManeKandalyanManderson
        ManeKandalyanMandersonAndLucaPinelli, //Mane Kandalyan Manderson / Luca Pinelli
        ManeKandalyanMandersonAndPixSmith, //Mane Kandalyan Manderson / Pix Smith
        MattChapman, //Matt Chapman
        MarcelBerg, //Marcel Berg
        MaliaEwart, //Malia Ewart
        MarianaMoreno, //Mariana Moreno
        MarioOscarGabriele, //Mario Oscar Gabriele
        MassimilianoNarciso, //Massimiliano Narciso
        MassimilianoNarcisoAndMariekeFerrari, //Massimiliano Narciso / Marieke Ferrari
        MatthewOates, //Matthew Oates
        MatthewRobertDavies, //Matthew Robert Davies
        MarcoGiorgianni, //MarcoGiorgianni
        MaxineVee, //Maxine Vee
        MaxineVeeAndDavidNavarroArenas, //Maxine Vee / David Navarro Arenas
        MckayAnderson, //Mckay Anderson
        MelMilton, //MelMilton
        MGiuliaRiva, //MGiulia Riva
        MichaelGuimont, ///Michael Guimont
        MichelaCacciatore, //Michela Cacciatore
        MichaelaMartin, //Michaela Martin
        MikeParker, //Mike Parker
        MikeMu, //Mike Mu
        MilaUseche, //Mila Useche
        MilicaCelikovic, //Milica Celikovic
        MonicaCatalano, //Monica Catalano
        MoniekSchilder, //Moniek Schilder
        NataliaTrykowska, //Natalia Trykowska
        NicholasKole, //NicholasKole
        NichorasKole, //NichorasKole
        NicolaSaviori, //Nicola Saviori
        NicolaSavioriAndRaquelVillanueva, //Nicola Saviori / Raquel Villanueva
        NicolasKy, //Nicolas Ky
        NicolettaBaldari,//Nicoletta Baldari
        OggyChristiansson, //Oggy Christiansson
        OlegYurkov, //OlegYurkov
        OliverDesiree, //Oliver Desiree
        OttoParedes, //Otto Paredes
        P_GaylordAndL_Giammichele, //P. Gaylord / L. Giammichele
        PabloHidalgo, //Pablo Hidalgo
        PabloHidalgoAndJeffMerghart, //Pablo Hidalgo / Jeff Merghart
        PaoYong, //PaoYong
        PeterBrockhammer, //Peter Brockhammer
        PhilippKruse, //PhilippKruse
        Pirel, //Pirel
        PirelAndMarcoGiorgianni, //Pirel / MarcoGiorgianni
        R_laBarberaAndL_Giammichele, //R. la Barbera / L. Giammichele
        RachelElese, //RachelElese
        RandyBishop, //Randy Bishop
        RaquelVillanueva, //Raquel Villanueva
        RiantiHidayat, //RiantiHidayat
        RiantiHidayatAndAlicePisoni, //Rianti Hidayat / Alice Pisoni
        RichelleCanto, //Richelle Canto
        RobDiSalvo, //Rob Di Salvo
        RobertoGatto, //Roberto Gatto
        RogerPerez, //Roger Perez
        RogieCustodioAndErinShin, //Rogie Custodio / Erin Shin
        RonBaird, //Ron Baird
        RosaLaBarbera, //Rosa la Barbera
        RosaLaBarberaAndLeonardoGiammichele, //Rosa la Barbera / Leonardo Giammichele
        RosaliaRadosti, //Rosalia Radosti
        RudyAndHill, //Rudy / Hill
        RudyHill, //Rudy Hill
        RyanMoeck, //Ryan Moeck
        S_ShawAndL_Giammichele, //S.Shaw / L.Giammichele
        SamantaErdini, //Samanta Erdini
        SandaraTang, //Sandara Tang
        SandraRios, //SandraRios
        ShannonHallstein, //Shannon Hallstein
        SimangalisoShibaya, //SimangalisoShibaya
        SimangalisoSibaya, //SimangalisoSibaya
        SimoneBuonfantino, //Simone Buonfantino
        StefanoZanchi, //StefanoZanchi
        TaniaSoler, //TaniaSoler
        TanishaCherislin, //TanishaCherislin
        ValentinaGraziuso, //Valentina Graziuso
        ValentinPalombo, //Valentin Palombo
        ValerioBuonfantino, //Valerio Buonfantino
        VeronicaDiLorenzoAndLivioCacciatore, //Veronica Di Lorenzo / Livio Cacciatore
        VickeyXieAndMarianaMoreno, //Vickey Xie / Mariana Moreno
        WietseTreurniet, //Wietse Treurniet
        WouterBruneel, //Wouter Bruneel
        YeYangAndRaquelVillanueva, //Ye Yang / Raquel Villanueva
        YuNguyen, //Yu Nguyen
        ZuzanaSokolovaAndLivioCacciatore, //Zuzana Sokolova / Livio Cacciatore
    }
}
