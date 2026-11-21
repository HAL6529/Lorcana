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
        Dinosaur, //恐竜
        Dragon, //ドラゴン
        DreamBorn, //ドリームボーン
        Fairy, //妖精
        FloodBorn, //フラッドボーン
        Gargoyle, //ガーゴイル
        Giant, //巨人
        Hero, //ヒーロー
        Hunny, //ハニー
        Hyena, //ハイエナ
        Illusion, //イリュージョン
        Inventor, //発明家
        King, //王様
        Knight, //騎士
        Madrigal, //マドリガル家
        Mentor, //導き手
        Monster, //モンスター
        Musketeer, //銃士
        Pirate, //海賊
        Prince,　//プリンス
        Princess, //プリンセス
        Puppy, //子犬
        Queen, //女王
        Racer, //レーサー
        RedPanda, //レッサーパンダ
        Robot, //ロボット
        SevenDwarfs, //7人の小人
        StoryBorn, //ストーリーボーン
        Sorcerer, //魔法使い
        Super, //スーパー
        Team, //チーム
        Tigger, //ティガー
        Titan, //タイタン
        Toy, //トイ
        Villain, //ヴィラン
        Vineling, //ヴァインリング
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
        ShimmeringSkies,
        AzuriteSea,
        ArchaziasIsland,
        ReignOfJafar,
        Fabled_vol1,
        Fabled_vol2,
    }


    //KeywordAvilityを編集する場合は、SearchFilterClassも修正すること。
    public enum KeywordAvility
    {
        Bodyguard,
        Challenger1, //果敢+1
        Challenger2, //果敢+2
        Challenger3, //果敢+3
        Challenger4, //果敢+4
        Challenger7, //果敢+7
        Evasive, //回避
        PuppyShift3, //子犬変身3
        Shift1, //変身1
        Shift2, //変身2
        Shift3, //変身3
        Shift4, //変身4
        Shift5, //変身5
        Shift6, //変身6
        Shift7, //変身7
        ShiftDiscardAnActionCard, //変身 ： アクション・カードを１枚捨てる
        ShiftDiscardAnCharacterCard, //変身:キャラクター・カードを１枚捨てる
        ShiftDiscardAnLocationCard, //変身:ロケーション・カードを１枚捨てる
        ShiftDiscardAnSongCard, //変身:歌・カードを１枚捨てる
        ShiftDiscard2Cards, //変身:カードを２枚捨てる
        Singer3, //歌声3
        Singer4, //歌声4
        Singer5, //歌声5
        Singer6, //歌声6
        Singer7, //歌声7
        Singer9, //歌声9
        SingTogether6, //合唱6
        SingTogether7, //合唱7
        SingTogether8, //合唱8
        SingTogether9, //合唱9
        SingTogether10, //合唱10
        Support, //支援
        Reckless, //暴勇
        Resist1, //耐久+1
        Resist2, //耐久+2
        Resist3, //耐久+3
        Rush, //突進
        UniversalShift4, //だれでも変身4
        Vanish, //霧消
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
        Bambi, //バンビ
        BeautyAndTheBeast, //美女と野獣
        BigHero6, //ベイマックス
        Bolt, //ボルト
        BrotherBear, //ブラザー・ベア
        Chipmunk, // チップとデール
        Cinderella, //シンデレラ
        DuckTales, //ダックテイル
        Dumbo, //ダンボ
        Encanto, //ミラベルと魔法だらけの家
        Fantasia, //ファンタジア
        Frozen, //アナと雪の女王
        Hercules, //ヘラクレス
        TaleSpin, //テイルスピン
        Tangled, //塔の上のラプンツェル
        TheAristocats, //おしゃれキャット
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
        LadyAndTheTramp, //わんわん物語
        LiloAndStitch, //リロ・アンド・スティッチ
        Lorcana, //ロルカナ
        MickeyMouse, //ミッキーマウス
        Moana, //モアナと伝説の海
        Mulan, //ムーラン
        OneHundredAndOneDalmatians, //101匹わんちゃん
        OswaldTheLuckyRabbit, //オズワルド・ザ・ラッキー・ラビット
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
        Epic,
        Enchanted,
        Iconic,
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
        AilbethZermeno, //Ailbeth Zermeno
        AishaDurmagambetova, //Aisha Durmagambetova
        AishDurmagmbetova, // Aish Durmagmbetova
        AlanBatson, //Alan Batson
        AlexAccorsi, //AlexAccorsi
        AlexAccorsiAndKendallHale, //Alex Accorsi/ Kendall Hale
        AlexandraHefez, //Alexandra Hefez
        AlexandriaNeonakis, //Alexandria Neonakis
        AlexaRockman, //Alexa Rockman
        AlexShin, //Alex Shin
        AlibethZermeno, //Alibeth Zermeno
        AlicePisoni, //Alice Pisoni
        AlicePisoniAndWhitneyPollett, //Alice Pisoni / Whitney Pollett
        AmandaDuarteAndJulioCesar, //Amanda Duarte / Julio Cesar
        AmandaMacFarlane, //Amanda Mac Farlane
        AmberKommavongsa, //Amber Kommavongsa
        AndersonMahanski, //Anderson Mahanski
        AndreaFemerstrand, //Andrea Femerstrand
        AndreaParisi, //Andrea Parisi
        AndreasRocha, //Andreas Rocha
        AndreyChumak, //Andrey Chumak
        AndrewParisi, //Andrew Parisi
        AndrewPena, //Andrew Pena
        AndrewPenaAndAubreyArcher, // Andrew Pena / Aubrey Archer
        AndrewTheophilopoulos, //Andrew Theophilopoulos
        AndrewThompson, //Andrew Thompson
        AndrewTrabbold, //Andrew Trabbold
        AndyEstradaAndGregShrader, //Andy Estrada / Greg Shrader
        AndyEstradaAndStefanoZanchi, //Andy Estrada / Stefano Zanchi
        AngelinaSpikeRicardo, //Angelina Spike Ricardo
        AngieSimpson, //Angie Simpson
        AnhDang, //Anh Dang
        AnnaRudAndAnnnaStosik, //Anna Rud / Annna Stosik
        AnnaRudAndLivioCacciatore, //Anna Rud / Livio Cacciatore
        AnnaStosik, //Anna Stosik
        AntoineCouttolenc, //Antoine Couttolenc
        AntoineCouttolencAndSamantaErdini, //Antoine Couttolenc / Samanta Erdini
        AntoneCouttolenc, //Antone Couttolenc
        AntoniaFlechsig, //Antonia Flechsig
        AriannaRea, //Arianna Rea
        AristeidisZentelis, //Aristeidis Zentelis
        ArisZentelis, //Aris Zentelis
        AubreyArcher, //Aubrey Archer
        AurelieLise_Anne, //Aurelie Lise-Anne
        BeatriceBlue, //Beatrice Blue
        BenoMeli, //Beno Meli
        BeverlyArceAndJonathanLivslyst, //Beverly Arce / Jonathan Livslyst
        BrianKesinger, //Brian Kesinger
        BriannaGarcia, //Brianna Garcia
        BrianWeisz, //Brian Weisz
        BrieSchmida, //Brie Schmida
        BrittneyHackett, //Brittney Hackett
        BrynJones, //Bryn Jones
        BillRobinson, //Bill Robinson
        BillyWimblett, //Billy Wimblett
        CamKendell, //Cam Kendell
        CamKendellAndDaniellePowers, //Cam Kendell / Danielle Powers
        CanerSoylu, //CanerSoylu
        CarlosGomesCabral, //Carlos Gomes Cabral
        CarlosLuzzi, //CarlosLuzzi
        CarlosRuiz, //Carlos Ruiz
        CarminePucci, //Carmine Pucci
        CarminePucciAndLeonardoGiammichele, //Carmine Pucci / Leonardo Giammichele
        CaseyRobin, //Casey Robin
        CecileCarre, //Cecile Carre
        CecileCarreAndAnnaStosik, //Cecile Carre / Anna Stosik
        CelesteJamneck, //Celeste Jamneck
        CelesteJamneckAndMarianaMoreno, // Celeste Jamneck / Mariana Moreno
        CesarVergara, //Cesar Vergara
        CesarVergaraAndEriWelli, //Cesar Vergara / EriWelli
        ChunxiMu, //Chunxi Mu
        ClarieHummel, //Clarie Hummel
        ClioWolfensberger, //ClioWolfensberger
        ConnieKangAndJackieDroujiko, //Connie Kang / Jackie Droujiko
        Cookie, //Cookie
        CoryGodbey, //CoryGodbey
        CristianRomero, //Cristian Romero
        DavAugereau, //Dav Augereau
        DavAugereauAndGiuliaRiva, //Dav Augereau / Giulia Riva
        DaveAlvarezAndAlicePisoni, //Dave Alvarez / Alice Pisoni
        DaveAlvarezAndLivioCacciatore, //Dave Alvarez / Livio Cacciatore
        DaveBeauchene, //DaveBeauchene
        DefneTozum, //Defne Tozum
        DefneTozumAndDennyMinonne, //Defne Tozum / Denny Minonne
        DefneTozumAndLivioCacciatore, //Defne Tozum / Livio Cacciatore
        DennyMinonne, //Denny Minonne
        DevinYang, //DevinYang
        DiegoMachuca, // Diego Machuca
        DinulescuAlexandru, //Dinulescu Alexandru
        DiogoSaito, //Diogo Saito
        DomenicoRusso, //Domenico Russo
        DominikMayer, //Dominik Mayer
        DonAguillo, //Don Aguillo
        DougasDeLaHoz, // Dougas De La Hoz
        DouglasDeLaHoz, //Douglas DeLaHoz
        DustinPanzino, //Dustin Panzino
        DustinPanzinoAndLeonardoGiammichele, //Dustin Panzino / Leonardo Giammichele
        DuyenNguyenAndAubreyArcher, //Duyen Nguyen / Aubrey Archer
        DylanBonner, //Dylan Bonner
        DylanBonnerAndCelesteJamneck, //Dylan Bonner / Celeste Jamneck
        E_MeleranciAndL_Giammichele, //E. Meleranci / L. Giammichele
        EdgarPasten, // Edgar Pasten
        EduFrancisco, // Edu Francisco
        EduFranciscoAndAmandaDuarte, // Edu Francisco / Amanda Duarte
        EllieHorie, //Ellie Horie
        EllieHorieAndJenniferPark, //Ellie Horie / Jennifer Park
        EllieHorieAndMaraTango, //Ellie Horie / Mara Tango
        ElliotBaumAndVivTanner, //Elliot Baum / Viv Tanner
        ElliotBocxtaele, //Elliot Bocxtaele
        ElodieMondoloni, //Elodie Mondoloni
        EmilyAbeydeera, //EmilyAbeydeera
        ErikaWiseman, //Erika Wiseman
        ErinShin, //Erin Shin
        EriWelli, //Eri Welli
        EriWelliAndSamBurley, //Eri Welli / Sam Burley
        EtienneSavoie, //Etienne Savoie
        EvanaKisa, //EvanaKisa
        EvanaKisAndJochemVanGool, //Evana Kis / Jochem van Gool
        EvanaKisaAndLivioCacciatore, //Evana Kisa / Livio Cacciatore
        EvaWidermann, //Eva Widermann
        EverGalvezAndAnnaStosik, //Ever Galvez / Anna Stosik
        FedericoMariaCugliari, //Federico Maria Cugliari
        FedericoMCugliari, //Federico M. Cugliari
        FilipeLaurentino, //Filipe Laurentino
        FlorenciaVazquez, //Florencia Vazquez
        FrancescoColucci, //Francesco Colucci
        FrancescoDippolitoAndGiuseppeDiMaio, //Francesco D'ippolito / Giuseppe di Maio
        FrancescoDippolitoAndMariaEwart, // Francesco D'ippolito / Maria Ewart
        FrenchCarlomagno, //French Carlomagno
        FrenchCarlomagnoAndMarianaMoreno, // French Carlomagno / Mariana Moreno
        Gabe, //Gabe
        GabrielAngelo, //Gabriel Angelo
        GabrielQuinn, //Gabriel Quinn
        GabrielRomero, //GabrielRomero
        GakuKumatori, //Gaku Kumatori
        GeoffreyBoudout, //Geoffrey Boudout
        GianlucaBarone, //Gianluca Barone
        GiuliaRiva, //Giulia Riva
        GiuseppeDiMaio, //Giuseppe di Maio
        GonzaloKenny, //Gonzalo Kenny
        GusGadgetAndLeonardoGiammichele, //GusGadget / Leonardo Giammichele
        GraceTran, //Grace Tran
        Greez, //Greez
        GrzegorzKrysinski, //Grzegorz Krysinski
        Gwawi, //Gwawi
        HadjieJoos, //Hadjie Joos
        HadjieJoosAndPixSmith, //Hadjie Joos / PixSmith
        HaJungSong, // Ha Jung Song
        HedvigHaggman_Sund, //Hadvig Haggman-Sund
        HeidiNeunhoffer, //Heidi Neunhoffer
        HedvigH_S, //Hedvig H-S
        HyunaLee, //HyunaLee
        IanMacDonald, //Ian MacDonald
        IlariaSposetti, //Ilaria Sposetti
        IrishChua, //Irish Chua
        IsabellaCeravolo, //IsabellaCeravolo
        IsaiahMesq, //Isaiah Mesq
        IvanShavrin, //Ivan Shavrin
        JackieDroujko, //Jackie Droujko
        JacobMcAlister, //Jacob McAlister
        JakeMurphy, //Jake Murphy
        JakeParker, //Jake Parker
        JamesCMulligan, //James C Mulligan
        JamesReySanchez, //James Rey Sanchez
        JaredMathews, //Jared Mathews
        JaredNickerl, //JaredNickerl
        JaredNickerlAndAlexAccorsi, //Jared Nickerl / Alex Accorsi
        JaredNickerlAndAlicePisoni, //Jared Nickerl / Alice Pisoni
        JaredNickerlAndPatriBalanovsky, //Jared Nickerl / Patri Balanovsky
        JeremyAdams, //Jeremy Adams
        JaviSalas, //Javi Salas
        JavierSalas, //JavierSalas
        JeannePlounevez, //Jeanne Plounevez
        JeannePlounevezAndTheonidas, //Jeanne Plounevez / Theonidas
        JeffMerghart, //Jeff Merghart
        JeffMurchie, //JeffMurchie
        JennaGray, //Jenna Gray
        JenniferGheduzziAndLivioCacciatore, //Jennifer Gheduzzi / Livio Cacciatore
        JenniferPark, //Jennifer Park
        JenniferParkAndLeonardoGiammichele, //Jennifer Park / Leonardo Giammichele
        JenniferParkAndLivioCacciatore, //Jennifer Park / Livio Cacciatore
        JenniferWu, //Jennifer Wu
        JiahuiEvaGao, //Jiahui Eva Gao
        JimmyLo, //Jimmy Lo
        JoaoMoura, //Joao Moura
        JocelynSepulveda, //Jocelyn Sepulveda
        JochemVanGool, //Jochem van Gool
        JoelDuQue, //Joel Du Que
        JohnLoren, //John Loren
        JohnLorenAndCristianRomero, //John Loren / Cristian Romero
        JohnLorenAndNicholasKole, //John Loren / Nicholas Kole
        JonasPetrauskas, //Jonas Petrauskas
        JonathanLiyslyst, //Jonathan Liyslyst
        JonathanLivslystAndReneeChio, // Jonathan Livslyst / ReneeChio
        JonDenskAndHayleyEvans, //Jon Densk / Hayley Evans
        JosephBuenning, //Joseph Buenning
        JosepSole, //Josep Sole
        JoyAngAndGiuliaRiva, // Joy Ang / Giulia Riva
        JoyAngAndJaimePuga, // Joy Ang / Jaime Puga
        JuanDiegoLeon, //Juan Diego Leon
        JulienVandois, //Julien Vandois
        JulieVu, //Julie Vu
        JustinGerard, //Justin Gerard
        JustinRunfola, //Justin Runfola
        JulesDubost, //Jules Dubost
        Kapik, //Kapik
        KamilMurzyn, //KamilMurzyn
        KamilMurzynAndEriWell, //Kamil Murzyn / Eri Well
        KaitlinCuthbertson, //Kaitlin Cuthbertson
        KarenHallion, //Karen Hallion
        KasiaBrzezinska, //Kasia Brzezinska
        KendallHale, //Kendall Hale
        KendallHaleAndAnhDang, //Kendall Hale / Anh Dang
        KennethAnderson, //Kenneth Anderson
        KevinHong, //Kevin Hong
        KevinSidharta, //Kevin Sidharta
        KierstenHale, //Kiersten Hale
        Koni, //Koni
        KristinaChori, //KristinaChori
        KristinaChouriAndMarianaMoreno, //Kristina Chouri / Mariana Moreno
        KristenKaluba, //Kristen Kaluba
        KuyaJaypi, //Kuya Jaypi
        LadyShalirin, //LadyShalirin
        LaiaLopez, //Laia Lopez
        LauraPauselli, //Laura Pauselli
        LauraDePascale, //Laura De Pascale
        LaurenBarger, //Lauren Barger
        LaurenLevering, //Lauren Levering
        LaurenWalsh, //Lauren Walsh
        LavaHijzelaar, //LavaHijzelaar
        LavaHijzelaarAndEllieHorie, //Lava Hijzelaar / Ellie Horie
        LeonardoGiammichele, //LeonardoGiammichele
        LeviRogers, //Levi Rogers
        LinhDang, //Linh Dang
        LisanneKoeteeuw, //Lisanne Koeteeuw
        LisaParfenova, //Lisa Parfenova
        LissetteCarrera, //Lissette Carrera
        LorenzaPigliamosche, //Lorenza Pigliamosche
        LorenzaPigliamoscheAndLivioCacciatore, //Lorenza Pigliamosche / Livio Cacciatore
        LouisJones, //Louis Jones
        LucaPinelli, //Luca Pinelli
        LuigiAime, //Luigi Aime
        LuisHuerta, //Luis Huerta
        M_K_Manderson_JochemVanGool, //M. K. Manderson / Jochem van Gool
        M_RobertDaviesAndL_Giammichele, //M. Robert Davies / L. Giammichele
        MaddieShilt, //Maddie Shilt
        MariaDresden, //Maria Dresden
        ManeKandalyanManderson, //ManeKandalyanManderson
        ManeKandalyanMandersonAndLucaPinelli, //Mane Kandalyan Manderson / Luca Pinelli
        ManeKandalyanMandersonAndPixSmith, //Mane Kandalyan Manderson / Pix Smith
        MattChapman, //Matt Chapman
        MatteoMarzocco, //Matteo Marzocco
        MarcelBerg, //Marcel Berg
        MaliaEwart, //Malia Ewart
        MarianaMoreno, //Mariana Moreno
        MarioManzanares, //Mario Manzanares
        MarioOscarGabriele, //Mario Oscar Gabriele
        MassimilianoNarciso, //Massimiliano Narciso
        MassimilianoNarcisoAndMariekeFerrari, //Massimiliano Narciso / Marieke Ferrari
        MattGaser, //Matt Gaser
        MatthewOates, //Matthew Oates
        MatthewRobertDavies, //Matthew Robert Davies
        MarcoGiorgianni, //MarcoGiorgianni
        MariaZafrilla, //Maria Zafrilla
        MarianaMorenoAndPeterBrockhammer, // Mariana Moreno / Peter Brockhammer
        MarineJosephine, //MarineJosephine
        MaxGrecke, //Max Grecke
        MaxineVee, //Maxine Vee
        MaxineVeeAndDavidNavarroArenas, //Maxine Vee / David Navarro Arenas
        MaxUlichney, //Max Ulichney
        McKayAnderson, //Mckay Anderson
        MelMilton, //MelMilton
        MGiuliaRiva, //MGiulia Riva
        MichaelGuimont, ///Michael Guimont
        MichelaCacciatore, //Michela Cacciatore
        MichelaCacciatoreAndGiuliaPriori, //Michela Cacciatore / Giulia Priori
        MichaelaMartin, //Michaela Martin
        MikeParker, //Mike Parker
        MikeMu, //Mike Mu
        MikeMuAndLivioCacciatore, //Mike Mu / Livio Cacciatore
        MilaUseche, //Mila Useche
        MilicaCelikovic, //Milica Celikovic
        MonicaCatalano, //Monica Catalano
        MoniekSchilder, //Moniek Schilder
        noc4urne, //noc4urne
        NataliaTrykowska, //Natalia Trykowska
        NatalieDombois, //Natalie Dombois
        NicholasKole, //NicholasKole
        NichorasKole, //NichorasKole
        NicolaSaviori, //Nicola Saviori
        NicolaSavioriAndLivioCacciatore, //Nicola Saviori / Livio Cacciatore
        NicolaSavioriAndRaquelVillanueva, //Nicola Saviori / Raquel Villanueva
        NicolasKy, //Nicolas Ky
        NicolettaBaldari,//Nicoletta Baldari
        Noukah, //Noukah
        OggyChristiansson, //Oggy Christiansson
        OggysonArt, // Oggyson Art
        OlegYurkov, //OlegYurkov
        OliverDesiree, //Oliver Desiree
        OmarLozano, //Omar Lozano
        OrnellaSavarese, //Ornella Savarese
        OttoParedes, //Otto Paredes
        OttoSchmidt, //Otto Schmidt
        P_GaylordAndL_Giammichele, //P. Gaylord / L. Giammichele
        PabloHidalgo, //Pablo Hidalgo
        PabloHidalgoAndJeffMerghart, //Pablo Hidalgo / Jeff Merghart
        PaoYong, //PaoYong
        PaulineVoss, //Pauline Voss
        PeterBrockhammer, //Peter Brockhammer
        PhilippKruse, //PhilippKruse
        PietroBZemelo, //Pietro B. Zemelo
        Pirel, //Pirel
        PirelAndMarcoGiorgianni, //Pirel / MarcoGiorgianni
        PixSmith, //Pix Smith
        PriyaKakati, // Priya Kakati
        R_laBarberaAndL_Giammichele, //R. la Barbera / L. Giammichele
        RachelElese, //RachelElese
        RandyBishop, //Randy Bishop
        RaquelVillanueva, //Raquel Villanueva
        RiantiHidayat, //RiantiHidayat
        RiantiHidayatAndAlicePisoni, //Rianti Hidayat / Alice Pisoni
        RicardoCaria, //Ricardo Caria
        RichelleCanto, //Richelle Canto
        RobDiSalvo, //Rob Di Salvo
        RobertoGatto, //Roberto Gatto
        RodrigoCamilo, // Rodrigo Camilo
        RogerPerez, //Roger Perez
        RogerPerezAndHayleyEvans, //Roger Perez / Hayley Evans
        RogerPerezAndLeonardoGiammichele, //Roger Perez / Leonardo Giammichele
        RogieCustodioAndErinShin, //Rogie Custodio / Erin Shin
        RonBaird, //Ron Baird
        RosaLaBarbera, //Rosa la Barbera
        RosaLaBarberaAndLeonardoGiammichele, //Rosa la Barbera / Leonardo Giammichele
        RosaLaBarberaAndLivioCacciatore, //Rosa la Barbera / Livio Cacciatore
        RosaliaRadosti, //Rosalia Radosti
        RubinChung, //Rubin Chung
        RudyAndHill, //Rudy / Hill
        RudyHill, //Rudy Hill
        RudyHillAndDennyMinonne, // Rudy Hill / Denny Minonne
        RyanBittner, //Ryan Bittner
        RyanMoeck, //Ryan Moeck
        S_ShawAndL_Giammichele, //S.Shaw / L.Giammichele
        SedaCoskun, //Seda Coskun
        SamantaErdini, //Samanta Erdini
        SamNielson, //Sam Nielson
        Samoldstoree, //Samoldstoree
        SandaraTang, //Sandara Tang
        SandraRios, //Sandra Rios
        SarahSchmidt, //Sarah Schmidt
        SaraLeal_Loyal, //Sara Leal(Loyal)
        SauloNate, //Saulo Nate
        SCG, //SCG
        SerenaWade, //Serena Wade
        SergioMancinelli, //Sergio Mancinelli
        ShannonHallstein, //Shannon Hallstein
        SimangalisoShibaya, //SimangalisoShibaya
        SimangalisoSibaya, //SimangalisoSibaya
        SimangalisoSibayaAndMarioManzanares, //Simangaliso Sibaya / Mario Manzanares
        SimoneBuonfantino, //Simone Buonfantino
        SimoneTentoni, //Simone Tentoni
        StefanoSpagnuolo, //Stefano Spagnuolo
        StefanoZanchi, //Stefano Zanchi
        TaniaSoler, //TaniaSoler
        TanishaCherislin, //TanishaCherislin
        Taraneh, //Taraneh
        TeresitaQAndSCG, //Teresita Q. / SCG
        ThereseVildefall, //Therese Vildefall
        TomBancroft, //Tom Bancroft
        TomBancroftAndKristenBreshears, // Tom Bancroft / Kristen Breshears
        ToniBruno, //Toni Bruno
        TonyBancroftAndLindsayWeyman, //Tony Bancroft / Lindsay Weyman
        UrsulaDorada, //Ursula Dorada
        ValentinaGraziuso, //Valentina Graziuso
        ValentinPalombo, //Valentin Palombo
        ValerioBuonfantino, //Valerio Buonfantino
        VanessaMorales, //Vanessa Morales
        VeronicaDiLorenzoAndLivioCacciatore, //Veronica Di Lorenzo / Livio Cacciatore
        VickeyXieAndMarianaMoreno, //Vickey Xie / Mariana Moreno
        VictorYanoCovarrubias, //Victor "Yano" Covarrubias
        VivTanner, //Viv Tanner
        VivTannerAndElieHorie, // Viv Tanner / Elie Horie
        WhitneyPollett, // Whitney Pollett
        WietseTreurniet, //Wietse Treurniet
        WouterBruneel, //Wouter Bruneel
        YanoAndMilicaCelikovic, //"Yano" / Milica Celikovic
        YariLute, //Yari Lute
        YeYangAndRaquelVillanueva, //Ye Yang / Raquel Villanueva
        YrganeRamon, // Yrgane Ramon
        YuNguyen, //Yu Nguyen
        ZuzanaSokolovaAndLivioCacciatore, //Zuzana Sokolova / Livio Cacciatore
    }
}
