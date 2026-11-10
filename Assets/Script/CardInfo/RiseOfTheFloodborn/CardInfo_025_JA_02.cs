using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_02 : CardInfo
{
    public CardInfo_025_JA_02()
    {
        this.cardNo = "025_JA_02";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "îíê·ïP";
        this.cardName2 = "à‰åÀÇ…äËÇ¢Ç";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
