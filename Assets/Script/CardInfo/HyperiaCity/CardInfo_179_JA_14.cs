using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_14 : CardInfo
{
    public CardInfo_179_JA_14()
    {
        this.cardNo = "179_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ナポレオン";
        this.cardName2 = "目を光らせる番犬";
        this.power = 5;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
