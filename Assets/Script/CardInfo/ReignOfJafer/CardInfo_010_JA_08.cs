using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_08 : CardInfo
{
    public CardInfo_010_JA_08()
    {
        this.cardNo = "010_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "好奇心の子";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
