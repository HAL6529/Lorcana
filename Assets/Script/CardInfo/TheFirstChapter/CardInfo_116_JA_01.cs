using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_01 : CardInfo
{
    public CardInfo_116_JA_01()
    {
        this.cardNo = "116_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "いつだってお上品";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Kenneth Anderson";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
