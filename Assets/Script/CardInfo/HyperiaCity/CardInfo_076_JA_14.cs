using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_14 : CardInfo
{
    public CardInfo_076_JA_14()
    {
        this.cardNo = "076_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "アイデア担当";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
