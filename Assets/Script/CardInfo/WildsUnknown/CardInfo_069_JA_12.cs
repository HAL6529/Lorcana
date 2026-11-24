using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_12 : CardInfo
{
    public CardInfo_069_JA_12()
    {
        this.cardNo = "069_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "メリダ";
        this.cardName2 = "反抗的な娘";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
