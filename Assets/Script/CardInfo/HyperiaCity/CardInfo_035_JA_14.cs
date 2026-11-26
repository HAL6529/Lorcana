using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_14 : CardInfo
{
    public CardInfo_035_JA_14()
    {
        this.cardNo = "035_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "オーエン・バーネット";
        this.cardName2 = "ザナトスの補佐役";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
