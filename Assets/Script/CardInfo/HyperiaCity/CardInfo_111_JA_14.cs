using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_14 : CardInfo
{
    public CardInfo_111_JA_14()
    {
        this.cardNo = "111_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "熱中する観光客";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmandaDuarte;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
