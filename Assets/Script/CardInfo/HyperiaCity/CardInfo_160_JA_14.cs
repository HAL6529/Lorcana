using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_14 : CardInfo
{
    public CardInfo_160_JA_14()
    {
        this.cardNo = "160_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クララベル";
        this.cardName2 = "お散歩にお出かけ";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHaleAndAubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
