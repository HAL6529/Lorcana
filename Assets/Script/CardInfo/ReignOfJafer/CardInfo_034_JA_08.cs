using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_08 : CardInfo
{
    public CardInfo_034_JA_08()
    {
        this.cardNo = "034_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アルマ・マドリガル";
        this.cardName2 = "受け入れるおばあちゃん";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
