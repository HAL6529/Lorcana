using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_14 : CardInfo
{
    public CardInfo_191_JA_14()
    {
        this.cardNo = "191_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "バルー";
        this.cardName2 = "貨物輸送パイロット";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
