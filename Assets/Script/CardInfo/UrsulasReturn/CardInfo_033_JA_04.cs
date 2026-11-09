using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_04 : CardInfo
{
    public CardInfo_033_JA_04()
    {
        this.cardNo = "033_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アトランティカ";
        this.cardName2 = "コンサートホール";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AlexShin;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
