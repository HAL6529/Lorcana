using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_04 : CardInfo
{
    public CardInfo_034_JA_04()
    {
        this.cardNo = "034_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "冥界";
        this.cardName2 = "ステュクス川";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
