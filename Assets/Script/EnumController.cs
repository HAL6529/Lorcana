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
        Detective, //探偵
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
        HyperiaCity, //ハイペリアシティ
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
        Villain, //ヴィランズ
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
        WinterSpellInTheWell,
        WinterSpell,
        WildsUnknown,
        AttackOfTheVine,
        HyperiaCity,
    }


    //KeywordAvilityを編集する場合は、SearchFilterClassも修正すること。
    public enum KeywordAvility
    {
        Adventurous, //冒険心
        Alert, //警戒
        Bodyguard,
        Challenger1, //果敢+1
        Challenger2, //果敢+2
        Challenger3, //果敢+3
        Challenger4, //果敢+4
        Challenger5, //果敢+5
        Challenger7, //果敢+7
        ComboShift4, //まとめて変身4
        ComboShift6, //まとめて変身6
        DuoShift0, //おふたり変身0
        Evasive, //回避
        FloodBornShift7, //フラッドボーン変身7
        MadrigalShift3, //マドリガル家変身3
        PuppyShift3, //子犬変身3
        PotatoShift5, //ポテト変身5
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
        ShiftRemove2InkDrops, //変身:インク・ドロップを2つ取り除く
        Singer2, //歌声2
        Singer3, //歌声3
        Singer4, //歌声4
        Singer5, //歌声5
        Singer6, //歌声6
        Singer7, //歌声7
        Singer8, //歌声8
        Singer9, //歌声9
        SingTogether3, //合唱3
        SingTogether5, //合唱5
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
        TemporaryRedPandaShift2, //かりそめレッサーパンダ変身2
        TemporaryShift3, //かりそめ変身3
        TemporaryShift4, //かりそめ変身4
        TemporaryShift7, //かりそめ変身7
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

    //Titleを編集する場合は、ExtendUtil, SearchClassも修正すること。
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
        Brave, //メリダとおそろしの森
        BrotherBear, //ブラザー・ベア
        Chipmunk, // チップとデール
        Cinderella, //シンデレラ
        Coco, //リメンバー・ミー
        DarkwingDuck, // ダックにおまかせ ダークウィング・ダック
        DuckTales, //ダックテイル
        Dumbo, //ダンボ
        Encanto, //ミラベルと魔法だらけの家
        Fantasia, //ファンタジア
        Frozen, //アナと雪の女王
        Gargoyles, //ガーゴイルズ
        Hercules, //ヘラクレス
        TaleSpin, //テイルスピン
        Tangled, //塔の上のラプンツェル
        TheAdventuresOfIchabodAndMrToad, //イカボードとトード氏
        TheAristocats, //おしゃれキャット
        TheBlackCauldron, //コルドロン
        TheEmperorsNewGroove, //ラマになった王様
        TheFoxAndTheHound, //きつねと猟犬
        TheGreatMouseDetective, //オリビアちゃんの大冒険
        TheIncredibles, //Mr.インクレディブル
        TheJungleBook, //ジャングル・ブック
        TheLionKing, //ライオンキング
        TheLittleMermaid,  //リトル・マーメイド
        ThePrincessAndTheFrog, //プリンセスと魔法のキス
        TheRescuers, // ビアンカの大冒険
        TheSwordInTheStone, //王様の剣
        TheTaleOfAMouse, //The Tale of a Mouse
        ToyStory, //トイ・ストーリー
        TreasurePlanet, //トレジャー・プラネット
        TurningRed, //私ときどきレッサーパンダ
        LadyAndTheTramp, //わんわん物語
        LiloAndStitch, //リロ・アンド・スティッチ
        Lorcana, //ロルカナ
        MickeyMouse, //ミッキーマウス
        Moana, //モアナと伝説の海
        MonstersInc, // モンスターズインク
        Mulan, //ムーラン
        OneHundredAndOneDalmatians, //101匹わんちゃん
        OswaldTheLuckyRabbit, //オズワルド・ザ・ラッキー・ラビット
        PeterPan, //ピーターパン
        Pinocchio, //ピノキオ
        Pocahontas, //ポカホンタス
        RayaAndTheLastDragon, //ラーヤと龍の王国
        RobinHood, //ロビン・フッド
        SleepingBeauty, //眠れる森の美女
        SnowWhiteAndTheSevenDwarfs, //白雪姫
        Up, //カールじいさんの空飛ぶ家
        WinnieThePooh, //クマのプーさん
        WreckItRalph, //シュガーラッシュ
        Zootopia, //ズートピア
    }

    //Typeを編集する場合は、SearchFilterClass, EditCardPanelも修正すること。
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
        AdaDevecchi, //Ada Devecchi
        AdamBunch, //Adam Bunch
        AdamFenton, //Adam Fenton
        AdamFord, //Adam Ford
        AdrianneGumaya, //AdrianneGumaya
        AgatheMolin, // Agathe Molin
        AilbethZermeno, //Ailbeth Zermeno
        AishaDurmagambetova, //Aisha Durmagambetova
        AishDurmagmbetova, // Aish Durmagmbetova
        AitorSebastian, //Aitor Sebastian
        AlanBatson, //Alan Batson
        AlbertoBesi, // Alberto Besi
        AlbertoDalLago, // Alberto Dal Lago
        AlejandroHernandez, //Alejandro Hernandez
        AlexAccorsi, //AlexAccorsi
        AlexAccorsiAndGraceTran, //Alex Accorsi / Grace Tran
        AlexAccorsiAndKendallHale, //Alex Accorsi/ Kendall Hale
        AlexAccorsiAndLeonardoGiammichele, //Alex Accorsi / Leonardo Giammichele
        AlexandraHefez, //Alexandra Hefez
        AlexandriaNeonakis, //Alexandria Neonakis
        AlexaRockman, //Alexa Rockman
        AlexShin, //Alex Shin
        AlibethZermeno, //Alibeth Zermeno
        AlicePisoni, //Alice Pisoni
        AlicePisoniAndWhitneyPollett, //Alice Pisoni / Whitney Pollett
        AlineBeserman, // Aline Beserman
        AlyssaLee, //Alyssa Lee
        AmandaDuarte, // Amanda Duarte
        AmandaDuarteAndJulioCesar, //Amanda Duarte / Julio Cesar
        AmandaMacFarlane, //Amanda Mac Farlane
        AmberKommavongsa, //Amber Kommavongsa
        AndersonMahanski, //Anderson Mahanski
        AndreaFemerstrand, //Andrea Femerstrand
        AndreaParisi, //Andrea Parisi
        AndreasRocha, //Andreas Rocha
        AndreyChumak, //Andrey Chumak
        AndrewChesworth, // Andrew Chesworth
        AndrewParisi, //Andrew Parisi
        AndrewPena, //Andrew Pena
        AndrewPenaAndAubreyArcher, // Andrew Pena / Aubrey Archer
        AndrewPenaAndSergioMancinelli, // Andrew Pena / Sergio Mancinelli
        AndrewTheophilopoulos, //Andrew Theophilopoulos
        AndrewThompson, //Andrew Thompson
        AndrewTrabbold, //Andrew Trabbold
        AndyEstradaAndGregShrader, //Andy Estrada / Greg Shrader
        AndyEstradaAndStefanoZanchi, //Andy Estrada / Stefano Zanchi
        AngelinaSpikeRicardo, //Angelina Spike Ricardo
        AngelMoonlight, //Angel Moonlight
        AngieSimpson, //Angie Simpson
        AnhDang, //Anh Dang
        AnnaRudAndAnnnaStosik, //Anna Rud / Annna Stosik
        AnnaRudAndLivioCacciatore, //Anna Rud / Livio Cacciatore
        AnnaStosik, //Anna Stosik
        AnneNeyens, //Anne Neyens
        ArtieRodriguez, //Artie Rodriguez
        AntoineCouttolenc, //Antoine Couttolenc
        AntoineCouttolencAndSamantaErdini, //Antoine Couttolenc / Samanta Erdini
        AntoneCouttolenc, //Antone Couttolenc
        AntoniaFlechsig, //Antonia Flechsig
        ArchApolar, // Arch Apolar
        AriannaRea, //Arianna Rea
        AristeidisZentelis, //Aristeidis Zentelis
        ArisZentelis, //Aris Zentelis
        AubreyArcher, //Aubrey Archer
        AurelieLise_Anne, //Aurelie Lise-Anne
        AyssaLee, // Ayssa Lee
        BeatriceBlue, //Beatrice Blue
        BeatriceBlueAndOttoParedes, // Beatrice Blue / Otto Paredes
        BenoMeli, //Beno Meli
        BeverlyArceAndJonathanLivslyst, //Beverly Arce / Jonathan Livslyst
        BoliNolascoAndCesarVergara, // Boli Nolasco / Cesar Vergara
        BrettOwens, // Brett Owens
        BrianKesinger, //Brian Kesinger
        BriannaGarcia, //Brianna Garcia
        BrianWeisz, //Brian Weisz
        BrieSchmida, //Brie Schmida
        BrittneyHackett, //Brittney Hackett
        BrrokesEggleston, // Brrokes Eggleston
        BrunoMirandaDeFreitas, // Bruno Miranda de Freitas
        BrynJones, //Bryn Jones
        BillRobinson, //Bill Robinson
        BillyMartin, // Billy Martin
        BillyWimblett, //Billy Wimblett
        Caelys, // Caelys
        CamKendell, //Cam Kendell
        CamKendellAndAlejandroHernandez, // Cam Kendell / Alejandro Hernandez
        CamKendellAndDaniellePowers, //Cam Kendell / Danielle Powers
        CanerSoylu, //CanerSoylu
        CarinaScyrinaHeller, // Carina 'Scyrina' Heller
        CarlosGomesCabral, //Carlos Gomes Cabral
        CarlosLuzzi, //CarlosLuzzi
        CarlosRuiz, //Carlos Ruiz
        CarlosSallas, //Carlos Sallas
        CarminePucci, //Carmine Pucci
        CarminePucciAndLeonardoGiammichele, //Carmine Pucci / Leonardo Giammichele
        CarolinaAlvarez, // Carolina Alvarez
        CaroWaro, //Caro Waro
        CaseyRobin, //Casey Robin
        CecileCarre, //Cecile Carre
        CecileCarreAndAnnaStosik, //Cecile Carre / Anna Stosik
        CelesteJamneck, //Celeste Jamneck
        CelesteJamneckAndMarianaMoreno, // Celeste Jamneck / Mariana Moreno
        CarmineCassese, // Carmine Cassese
        CesarVergara, //Cesar Vergara
        CesarVergaraAndAlexAccorsi, //Cesar Vergara / Alex Accorsi
        CesarVergaraAndEriWelli, //Cesar Vergara / EriWelli
        CaseyJoOcean, // Casey Jo Ocean
        ChemeneDeHeus, // Chemene de Heus
        ChunxiMu, //Chunxi Mu
        ClarieHummel, //Clarie Hummel
        ClioSchaffner, //Clio Schaffner
        ClioWolfensberger, //ClioWolfensberger
        ConnieKangAndJackieDroujiko, //Connie Kang / Jackie Droujiko
        Cookie, //Cookie
        CoryGodbey, //CoryGodbey
        CristianRomero, //Cristian Romero
        CrosbyGuerrero, // Crosby Guerrero
        DaniellePowers, //Danielle Powers
        DaniFdezAndGregShrader, // Dani Fdez / Greg Shrader
        DavAugereau, //Dav Augereau
        DavAugereauAndGiuliaRiva, //Dav Augereau / Giulia Riva
        DaveAlvarezAndAlicePisoni, //Dave Alvarez / Alice Pisoni
        DaveAlvarezAndLivioCacciatore, //Dave Alvarez / Livio Cacciatore
        DaveBeauchene, //DaveBeauchene
        DaveMitchesonAndPaulHogg, // Dave Mitcheson / Paul Hogg
        DavidForrest, // David Forrest
        DavidGalopim, // David Galopim
        DavidOtalora, // David Otalora
        DavidOtaloraAndXaviPlanas, // David Otalora / Xavi Planas
        DefneTozum, //Defne Tozum
        DefneTozumAndDennyMinonne, //Defne Tozum / Denny Minonne
        DefneTozumAndLivioCacciatore, //Defne Tozum / Livio Cacciatore
        DennyMinonne, //Denny Minonne
        DevinElleKurtz, // Devin ElleKurtz
        DevinYang, //Devin Yang
        DevMadan, // Dev Madan
        DevMadanAndEriWelli, //Dev Madan / Eri Welli
        DevMadanAndLeonardoGiammichele, //Dev Madan / Leonardo Giammichele
        DianaDiz, //Diana Diz
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
        EricaDurso, //Erica D'urso
        EricTan, // Eric Tan
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
        FahedAlrajil, // Fahed Alrajil
        FedericoMariaCugliari, //Federico Maria Cugliari
        FedericoMCugliari, //Federico M. Cugliari
        FilipeLaurentino, //Filipe Laurentino
        FlorenciaVazquez, //Florencia Vazquez
        FrancescoColucci, //Francesco Colucci
        FrancescaRisoldi, //Francesca Risoldi
        FrancescoDippolitoAndGiuseppeDiMaio, //Francesco D'ippolito / Giuseppe di Maio
        FrancescoDippolitoAndMariaEwart, // Francesco D'ippolito / Maria Ewart
        FrenchCarlomagno, //French Carlomagno
        FrenchCarlomagnoAndMarianaMoreno, // French Carlomagno / Mariana Moreno
        Gabe, //Gabe
        GabrielaGalvan, //Gabriela Galvan
        GabrielAngelo, //Gabriel Angelo
        GabrielNascimento, // Gabriel Nascimento
        GabrielQuinn, //Gabriel Quinn
        GabrielRomero, //GabrielRomero
        GakuKumatori, //Gaku Kumatori
        GeoffreyBoudout, //Geoffrey Boudout
        GiacomoBoni, //Giacomo Boni
        GianlucaBarone, //Gianluca Barone
        GiuliaLacopiniAndLivioCacciatore, // Giulia lacopini / Livio Cacciatore
        GiuliaRiva, //Giulia Riva
        GiuseppeDiMaio, //Giuseppe di Maio
        GonzaloKenny, //Gonzalo Kenny
        GusGadgetAndLeonardoGiammichele, //GusGadget / Leonardo Giammichele
        GustavoChinaide, // Gustavo Chinaide
        GraceTran, //Grace Tran
        Greez, //Greez
        GregShrader, //Greg Shrader
        GrzegorzKrysinski, //Grzegorz Krysinski
        Gwawi, //Gwawi
        HadjieJoos, //Hadjie Joos
        HadjieJoosAndPixSmith, //Hadjie Joos / PixSmith
        HanaAugustine, //Hana Augustine
        HaniaCzyzewska, // Hania Czyzewska
        HaJungSong, // Ha Jung Song
        HedvigHaggman_Sund, //Hadvig Haggman-Sund
        HeidiNeunhoffer, //Heidi Neunhoffer
        HedvigH_S, //Hedvig H-S
        HollieHibbert, // Hollie Hibbert
        HyunaLee, //HyunaLee
        IanMacDonald, //Ian MacDonald
        IlariaSposetti, //Ilaria Sposetti
        IrishChua, //Irish Chua
        IsabellaCeravolo, //IsabellaCeravolo
        IsabellaCaravoloAndPalomaSauvage, //Isabella Caravolo / Paloma Sauvage
        IsaiahMesq, //Isaiah Mesq
        IvanShavrin, //Ivan Shavrin
        JackieDroujko, //Jackie Droujko
        JacobMcAlister, //Jacob McAlister
        JaimePuga, //Jaime Puga
        JanelReh, //Janel Reh
        JakeMurphy, //Jake Murphy
        JakeParker, //Jake Parker
        JamesCMulligan, //James C Mulligan
        JamesReySanchez, //James Rey Sanchez
        JanePica, //Jane Pica
        JaredMathews, //Jared Mathews
        JaredNickerl, //JaredNickerl
        JaredNickerlAndAlexAccorsi, //Jared Nickerl / Alex Accorsi
        JaredNickerlAndAlicePisoni, //Jared Nickerl / Alice Pisoni
        JaredMathewsAndAmberKommavongsa, //Jared Mathews / Amber Kommavongsa
        JaredNickerlAndPatriBalanovsky, //Jared Nickerl / Patri Balanovsky
        JeremyAdams, //Jeremy Adams
        JeremyAdamsAndJaimePuga, //Jeremy Adams / Jaime Puga
        Jaryclea, //Jaryclea
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
        JuanPabloVelazquez, //Juan Pablo Velazquez
        JustinGerard, //Justin Gerard
        JustinRunfola, //Justin Runfola
        JulesDubost, //Jules Dubost
        JulianDelRey, //Julian del Rey
        JulienVandois, //Julien Vandois
        JulietteOberndorfer, //Juliette Oberndorfer
        JulieVu, //Julie Vu
        Kapik, //Kapik
        KamilMurzyn, //KamilMurzyn
        KamilMurzynAndEriWell, //Kamil Murzyn / Eri Well
        KaitlinCuthbertson, //Kaitlin Cuthbertson
        Kaluba, //Kaluba
        KarenHallion, //Karen Hallion
        KasiaBrzezinska, //Kasia Brzezinska
        KatlinCuthbertson, // Katlin Cuthbertson
        KatyaCyan, // Katya Cyan
        KeiYotsuba, //Kei Yotsuba
        KendallHale, //Kendall Hale
        KendallHaleAndAnhDang, //Kendall Hale / Anh Dang
        KendallHaleAndAubreyArcher, //Kendall Hale / Aubrey Archer
        KennethAnderson, //Kenneth Anderson
        KevinHong, //Kevin Hong
        KevinSidharta, //Kevin Sidharta
        KevinSlawinski, //Kevin Slawinski
        KierstenHale, //Kiersten Hale
        Koni, //Koni
        KristinaChori, //KristinaChori
        KristinaChouriAndMarianaMoreno, //Kristina Chouri / Mariana Moreno
        KristenKaluba, //Kristen Kaluba
        Kurokuma, // Kurokuma
        KuyaJaypi, //Kuya Jaypi
        Kyeri, //Kyeri
        LadyShalirin, //LadyShalirin
        LadyShalirinAndEriWelli, //Lady Shalirin / Eri Welli
        LaiaLopez, //Laia Lopez
        LaraCarson, // Lara Carson
        LauraPauselli, //Laura Pauselli
        LauraDePascale, //Laura De Pascale
        LaurenBarger, //Lauren Barger
        LaurenLevering, //Lauren Levering
        LaurenWalsh, //Lauren Walsh
        LavaHijzelaar, //LavaHijzelaar
        LavaHijzelaarAndEllieHorie, //Lava Hijzelaar / Ellie Horie
        LeeRowan, //Lee Rowan
        LenSimonAndHayleyEvans, // Len Simon / Hayley Evans
        LeonardoGiammichele, //LeonardoGiammichele
        LeslieStrock, // Leslie Strock
        LeviRogers, //Levi Rogers
        LinhDang, //Linh Dang
        LisanneKoeteeuw, //Lisanne Koeteeuw
        LisaParfenova, //Lisa Parfenova
        LissetteCarrera, //Lissette Carrera
        LissetteCarreraAndBrettOwens, // Lissette Carrera / Brett Owens
        LivioCacciatore, //Livio Cacciatore
        LizRichards, // Liz Richards
        LorenaPiloreta, // Lorena Piloreta
        LorenzaPigliamosche, //Lorenza Pigliamosche
        LorenzaPigliamoscheAndLivioCacciatore, //Lorenza Pigliamosche / Livio Cacciatore
        LouisJones, //Louis Jones
        LucaPinelli, //Luca Pinelli
        LuigiAime, //Luigi Aime
        LuisHuerta, //Luis Huerta
        LuisHuertaAndLynnsMagicWorlds, //Luis Huerta / Lynns Magic Worlds
        LynnsMagicWorlds, // Lynn's Magic Worlds
        LyleCruse, // Lyle Cruse
        M_K_Manderson_JochemVanGool, //M. K. Manderson / Jochem van Gool
        M_RobertDaviesAndL_Giammichele, //M. Robert Davies / L. Giammichele
        MaddieShilt, //Maddie Shilt
        MagentaMuraca, // Magenta Muraca
        MagentaMuracaAndGraceTran, //Magenta Muraca / Grace Tran
        ManeKandalyanManderson, //ManeKandalyanManderson
        ManeKandalyanMandersonAndLucaPinelli, //Mane Kandalyan Manderson / Luca Pinelli
        ManeKandalyanMandersonAndPixSmith, //Mane Kandalyan Manderson / Pix Smith
        MaliaEwart, //Malia Ewart
        MaorSharvit, // Maor Sharvit
        MarcelBerg, //Marcel Berg
        MarceloVignali, // Marcelo Vignali
        MarcinKarolewski, // Marcin Karolewski
        MarcinPanasiuk, // Marcin Panasiuk
        MarcoGiorgianni, //MarcoGiorgiann
        MarcoGiorgianniAndLivioCacciatore, //Marco Giorgianni / Livio Cacciatore
        MarcoGuadalupi, //Marco Guadalupi
        MariaDresden, //Maria Dresden
        MariaDresdenAndEllieHorie, // Maria Dresden / Ellie Horie
        MariaEwart, // Maria Ewart
        MariaLuisaPetrarca, // Maria Luisa Petrarca
        MarianaMoreno, //Mariana Moreno
        MarianaMuGaliano, // Mariana "mu" Galiano
        MarineJosephine, //MarineJosephine
        MarioManzanares, //Mario Manzanares
        MarioOscarGabriele, //Mario Oscar Gabriele
        MartaAndreeva, // Marta Andreeva
        MaryamSefati, //Maryam Sefati
        MassimilianoNarciso, //Massimiliano Narciso
        MassimilianoNarcisoAndMariekeFerrari, //Massimiliano Narciso / Marieke Ferrari
        MattChapman, //Matt Chapman
        MatteoMarzocco, //Matteo Marzocco
        MattGaser, //Matt Gaser
        MatthewOates, //Matthew Oates
        MatthewRobertDavies, //Matthew Robert Davies
        MarianaMorenoAndPeterBrockhammer, // Mariana Moreno / Peter Brockhammer
        MariaZafrilla, //Maria Zafrilla
        MaxGrecke, //Max Grecke
        MaximilienBorie, // Maximilien Borie
        MaxineVee, //Maxine Vee
        MaxineVeeAndDavidNavarroArenas, //Maxine Vee / David Navarro Arenas
        MaxUlichney, //Max Ulichney
        McKayAnderson, //Mckay Anderson
        McKayAndersonAndTheonidas, //McKay Anderson / Theonidas
        MedusaDollmaker, // Medusa Dollmaker
        MelissaBallesterosAndAlejandroHernandez, // Melissa Ballesteros / Alejandro Hernandez
        MelMilton, //MelMilton
        MGiuliaRiva, //MGiulia Riva
        MichaelGuimont, ///Michael Guimont
        MichelaCacciatore, //Michela Cacciatore
        MichelaCacciatoreAndGiuliaPriori, //Michela Cacciatore / Giulia Priori
        MichaelaMartin, //Michaela Martin
        MichaelaMartinAndLivioCacciatore, // Michaela Martin / Livio Cacciatore
        MiguelLasarte, // Miguel Lasarte
        MikeParker, //Mike Parker
        MikeMu, //Mike Mu
        MikeMuAndLivioCacciatore, //Mike Mu / Livio Cacciatore
        MilaUseche, //Mila Useche
        MilicaCelikovic, //Milica Celikovic
        MonicaCatalano, //Monica Catalan
        MonicaCatalanoAndKristenBreshears, //Monica Catalano / Kristen Breshears
        MoniekSchilder, //Moniek Schilder
        noc4urne, //noc4urne
        NataliaTrykowska, //Natalia Trykowska
        NatalieDombois, //Natalie Dombois
        NargesJafari, //Narges Jafari
        NevenaNikolcheva, // Nevena Nikolcheva
        NicholasKole, //NicholasKole
        NicolaSaviori, //Nicola Saviori
        NicolaSavioriAndLivioCacciatore, //Nicola Saviori / Livio Cacciatore
        NicolaSavioriAndRaquelVillanueva, //Nicola Saviori / Raquel Villanueva
        NicolasKy, //Nicolas Ky
        NicolettaBaldari,//Nicoletta Baldari
        NicolettaBaldariAndPatriBalanovsky, // Nicoletta Baldari / Patri Balanovsky
        Noukah, //Noukah
        NuelSalinasAndPaloGraglia, //Nuel Salinas / Palo Graglia
        OggyChristiansson, //Oggy Christiansson
        OggysonArt, // Oggyson Art
        OlegYurkov, //OlegYurkov
        OlgaAndriyenko, //Olga Andriyenko
        OliverDesiree, //Oliver Desiree
        OmarLozano, //Omar Lozano
        OrnellaSavarese, //Ornella Savarese
        OttoParedes, //Otto Paredes
        OttoSchmidt, //Otto Schmidt
        P_GaylordAndL_Giammichele, //P. Gaylord / L. Giammichele
        PabloHidalgo, //Pablo Hidalgo
        PabloHidalgoAndJeffMerghart, //Pablo Hidalgo / Jeff Merghart
        PalomaSauvage, // Paloma Sauvage
        PaoYong, //PaoYong
        PaulineVoss, //Pauline Voss
        PeterBrockhammer, //Peter Brockhammer
        PatriBalanovsky, // Patri Balanovsky
        PernilleOrum, //Pernille Orum
        PhillipKruse, // Phillip Kruse
        PietroBZemelo, //Pietro B. Zemelo
        Pirel, //Pirel
        PirelAndMarcoGiorgianni, //Pirel / MarcoGiorgianni
        PixSmith, //Pix Smith
        PepeDelgadoNavarro, // Pepe Delgado Navarro
        PriyaKakati, // Priya Kakati
        R_laBarberaAndL_Giammichele, //R. la Barbera / L. Giammichele
        RachelElese, //RachelElese
        RafalWojtunik, //Rafal Wojtunik
        RandyBishop, //Randy Bishop
        RaquelVillanueva, //Raquel Villanueva
        RaquelVillanuevaAndGraceTran, //Raquel Villanueva / GraceTran
        ReneeChio, // Renee Chio
        RiantiHidayat, //RiantiHidayat
        RiantiHidayatAndAlicePisoni, //Rianti Hidayat / Alice Pisoni
        RicardoCaria, //Ricardo Caria
        RicardoCariaAndPixSmith, // Ricardo Caria / Pix Smith
        RichelleCanto, //Richelle Canto
        RizalBadar, // Rizal Badar
        RobDiSalvo, //Rob Di Salvo
        RobertoGatto, //Roberto Gatto
        RodrigoCamilo, // Rodrigo Camilo
        RodrigoRaposo, // Rodrigo Raposo
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
        RudyHillAndMikeParker, // Rudy Hill / Mike Parker
        RyanBittner, //Ryan Bittner
        RyanMoeck, //Ryan Moeck
        S_ShawAndL_Giammichele, //S.Shaw / L.Giammichele
        SamantaErdini, //Samanta Erdini
        SamNielson, //Sam Nielson
        Samoldstoree, //Samoldstoree
        SandaraTang, //Sandara Tang
        SandraRios, //Sandra Rios
        SandyLee, // Sandy Lee
        SarahSchmidt, //Sarah Schmidt
        SaraLeal_Loyal, //Sara Leal(Loyal)
        SebastianLozano, //Sebastian Lozano
        SergioMancinell, //Sergio Mancinell
        SauloNate, //Saulo Nate
        SCG, //SCG
        SedaCoskun, //Seda Coskun
        SerenaWade, //Serena Wade
        SergioMancinelli, //Sergio Mancinelli
        SGeer, //SGeer
        ShannonHallstein, //Shannon Hallstein
        SimangalisoShibaya, //SimangalisoShibaya
        SimangalisoSibaya, //SimangalisoSibaya
        SimangalisoSibayaAndMarioManzanares, //Simangaliso Sibaya / Mario Manzanares
        SimoneBuonfantino, //Simone Buonfantino
        SimoneGiovanardi, //Simone Giovanardi
        SimoneTentoni, //Simone Tentoni
        SlawomirManiak, // Slawomir Maniak
        StefanoSpagnuolo, //Stefano Spagnuolo
        StefanoSpagnuoloAndAdamFord, //Stefano Spagnuolo / Adam Ford
        StefanoZanchi, //Stefano Zanchi
        SvetlozaraNikolova, // Svetlozara Nikolova
        SytzeBrommersma, // Sytze Brommersma
        TaniaSoler, //TaniaSoler
        TanishaCherislin, //TanishaCherislin
        Taraneh, //Taraneh
        TeresitaQAndSCG, //Teresita Q. / SCG
        ThereseVildefall, //Therese Vildefall
        TimVanGalen, // Tim van Galen
        TomBancroft, //Tom Bancroft
        TomBancroftAndKristenBreshears, // Tom Bancroft / Kristen Breshears
        TomekPietrzyk, // Tomek Pietrzyk
        TomWhalen, // Tom Whalen
        ToniBruno, //Toni Bruno
        TonyBancroftAndLindsayWeyman, //Tony Bancroft / Lindsay Weyman
        UrsulaDorada, //Ursula Dorada
        ValentinaGraziuso, //Valentina Graziuso
        ValentinaGraziusoAndGraceTran, // Valentina Graziuso / Grace Tran
        ValentinPalombo, //Valentin Palombo
        ValerioBuonfantino, //Valerio Buonfantino
        ValerioBuonfantinoAndAmandaDuarte, // Valerio Buonfantino / Amanda Duarte
        VanessaMorales, //Vanessa Morales
        VeronicaDiLorenzoAndLivioCacciatore, //Veronica Di Lorenzo / Livio Cacciatore
        VickeyXieAndMarianaMoreno, //Vickey Xie / Mariana Moreno
        VictorYanoCovarrubias, //Victor "Yano" Covarrubias
        VivTanner, //Viv Tanner
        VivTannerAndElieHorie, // Viv Tanner / Elie Horie
        WhitneyPollett, // Whitney Pollett
        WietseTreurniet, //Wietse Treurniet
        WouterBruneel, //Wouter Bruneel
        XaviPlanasTorrents, //Xavi Planas Torrents
        YanoAndMilicaCelikovic, //"Yano" / Milica Celikovic
        YariLute, //Yari Lute
        YeYangAndRaquelVillanueva, //Ye Yang / Raquel Villanueva
        YrganeRamon, // Yrgane Ramon
        YuNguyen, //Yu Nguyen
        YuNguyenAndMarianaMoreno, // Yu Nguyen / Mariana Moreno
        ZuzanaSokolovaAndLivioCacciatore, //Zuzana Sokolova / Livio Cacciatore
    }
}
