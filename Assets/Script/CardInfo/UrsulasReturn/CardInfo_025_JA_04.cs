using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_04 : CardInfo
{
    public CardInfo_025_JA_04()
    {
        this.cardNo = "025_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アースラ";
        this.cardName2 = "ヴァネッサ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AngieSimpson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
