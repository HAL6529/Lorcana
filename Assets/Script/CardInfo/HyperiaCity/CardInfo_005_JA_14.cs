using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_14 : CardInfo
{
    public CardInfo_005_JA_14()
    {
        this.cardNo = "005_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "自意識過剰な自慢屋";
        this.power = 1;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeeRowan;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
