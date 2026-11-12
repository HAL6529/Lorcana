using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_07 : CardInfo
{
    public CardInfo_109_JA_07()
    {
        this.cardNo = "109_JA_07";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ÉWÉáÉìÅEÉVÉãÉoÅ[";
        this.cardName2 = "é∑îOê[Ç¢äCëØ";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
