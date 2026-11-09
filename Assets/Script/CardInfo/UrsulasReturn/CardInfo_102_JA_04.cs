using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_04 : CardInfo
{
    public CardInfo_102_JA_04()
    {
        this.cardNo = "102_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アースラの庭";
        this.cardName2 = "不幸せものだらけ";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JonathanLiyslyst;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
