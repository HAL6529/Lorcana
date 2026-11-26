using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_14 : CardInfo
{
    public CardInfo_012_JA_14()
    {
        this.cardNo = "012_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "P. J. ピート";
        this.cardName2 = "熱狂的ファン";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
