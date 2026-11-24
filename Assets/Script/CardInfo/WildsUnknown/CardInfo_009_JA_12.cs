using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_12 : CardInfo
{
    public CardInfo_009_JA_12()
    {
        this.cardNo = "009_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドロレス・マドリガル";
        this.cardName2 = "どんなことでも全部聞こえてる人";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
