using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_04 : CardInfo
{
    public CardInfo_046_JA_04()
    {
        this.cardNo = "046_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジェットサム";
        this.cardName2 = "アースラの”かわいい子分”";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
