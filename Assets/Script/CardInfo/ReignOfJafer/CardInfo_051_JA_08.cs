using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_08 : CardInfo
{
    public CardInfo_051_JA_08()
    {
        this.cardNo = "051_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ブルーノ・マドリガル";
        this.cardName2 = "一意専心";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NataliaTrykowska;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
