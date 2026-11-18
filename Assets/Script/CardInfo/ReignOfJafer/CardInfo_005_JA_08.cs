using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_08 : CardInfo
{
    public CardInfo_005_JA_08()
    {
        this.cardNo = "005_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アントニオ・マドリガル";
        this.cardName2 = "みんなとなかよし";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
