using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_02 : CardInfo
{
    public CardInfo_115_JA_02()
    {
        this.cardNo = "115_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "かっとびライダー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
