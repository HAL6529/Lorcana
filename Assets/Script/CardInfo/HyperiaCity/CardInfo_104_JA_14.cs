using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_14 : CardInfo
{
    public CardInfo_104_JA_14()
    {
        this.cardNo = "104_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アビー・パーク";
        this.cardName2 = "くらくらファン";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarolinaAlvarez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
