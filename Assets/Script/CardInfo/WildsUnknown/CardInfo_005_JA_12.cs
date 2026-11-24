using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_12 : CardInfo
{
    public CardInfo_005_JA_12()
    {
        this.cardNo = "005_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ペドロ・マドリガル";
        this.cardName2 = "家長";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HaniaCzyzewska;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
