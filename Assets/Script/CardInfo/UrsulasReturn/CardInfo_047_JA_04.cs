using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_04 : CardInfo
{
    public CardInfo_047_JA_04()
    {
        this.cardNo = "047_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ルイーサ・マドリガル";
        this.cardName2 = "魔法の力持ち";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
