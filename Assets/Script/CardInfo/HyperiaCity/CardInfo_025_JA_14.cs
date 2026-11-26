using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_14 : CardInfo
{
    public CardInfo_025_JA_14()
    {
        this.cardNo = "025_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "警官のお助け";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
