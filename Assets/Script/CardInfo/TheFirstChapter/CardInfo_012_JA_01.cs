using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_01 : CardInfo
{
    public CardInfo_012_JA_01()
    {
        this.cardNo = "012_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "いつだって友達";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Dave Beauchene";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
