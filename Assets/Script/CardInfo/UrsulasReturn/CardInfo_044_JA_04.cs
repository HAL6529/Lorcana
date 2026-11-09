using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_04 : CardInfo
{
    public CardInfo_044_JA_04()
    {
        this.cardNo = "044_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "フロットサム＆ジェットサム";
        this.cardName2 = "ウツボ・カラミティ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftDiscard2Cards };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
