using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_14 : CardInfo
{
    public CardInfo_068_JA_14()
    {
        this.cardNo = "068_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マーリンの工房店";
        this.cardName2 = "魔法マーケット";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.MaryamSefati;
        this.classList = new List<EnumController.Class> { };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
