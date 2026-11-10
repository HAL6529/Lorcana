using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_04 : CardInfo
{
    public CardInfo_106_JA_04()
    {
        this.cardNo = "106_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "薄情者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeMu;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
