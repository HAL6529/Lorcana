using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_14 : CardInfo
{
    public CardInfo_188_JA_14()
    {
        this.cardNo = "188_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "バルー";
        this.cardName2 = "配達パイロット";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
