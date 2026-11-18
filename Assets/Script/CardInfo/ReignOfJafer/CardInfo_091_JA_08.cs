using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_08 : CardInfo
{
    public CardInfo_091_JA_08()
    {
        this.cardNo = "091_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "三月うさぎ";
        this.cardName2 = "ウサ晴らす変人";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DustinPanzino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
