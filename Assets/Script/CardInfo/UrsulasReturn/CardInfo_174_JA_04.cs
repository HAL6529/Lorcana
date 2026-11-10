using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_04 : CardInfo
{
    public CardInfo_174_JA_04()
    {
        this.cardNo = "174_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アリエル";
        this.cardName2 = "心を決めた人魚";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DylanBonner;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
