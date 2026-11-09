using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_04 : CardInfo
{
    public CardInfo_014_JA_04()
    {
        this.cardNo = "014_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マックス";
        this.cardName2 = "忠実なシープドッグ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
