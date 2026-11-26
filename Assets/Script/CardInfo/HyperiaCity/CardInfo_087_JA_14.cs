using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_14 : CardInfo
{
    public CardInfo_087_JA_14()
    {
        this.cardNo = "087_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "野ネズミのレスター君";
        this.cardName2 = "パークのマスコット";
        this.power = 0;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
