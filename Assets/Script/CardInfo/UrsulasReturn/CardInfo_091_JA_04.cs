using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_04 : CardInfo
{
    public CardInfo_091_JA_04()
    {
        this.cardNo = "091_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "トール";
        this.cardName2 = "フローリスト";
        this.power = 4;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndersonMahanski;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
