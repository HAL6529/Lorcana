using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_04 : CardInfo
{
    public CardInfo_157_JA_04()
    {
        this.cardNo = "157_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "魔法にかけられたシェフ";
        this.cardName2 = "お城のコンロ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JamesCMulligan;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
