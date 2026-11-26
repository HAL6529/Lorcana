using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_14 : CardInfo
{
    public CardInfo_181_JA_14()
    {
        this.cardNo = "181_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "サー・ケイ";
        this.cardName2 = "勝つためなら何でもやる";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SebastianLozano;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
