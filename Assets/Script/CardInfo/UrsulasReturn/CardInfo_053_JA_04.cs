using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_04 : CardInfo
{
    public CardInfo_053_JA_04()
    {
        this.cardNo = "053_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ペパ・マドリガル";
        this.cardName2 = "お天気おばさん";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
