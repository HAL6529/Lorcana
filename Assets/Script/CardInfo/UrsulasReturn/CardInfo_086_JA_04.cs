using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_04 : CardInfo
{
    public CardInfo_086_JA_04()
    {
        this.cardNo = "086_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "意地悪なやつ";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
