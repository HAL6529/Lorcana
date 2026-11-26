using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_14 : CardInfo
{
    public CardInfo_142_JA_14()
    {
        this.cardNo = "142_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ラフィエット";
        this.cardName2 = "耳をそばだてる番犬";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandyLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
