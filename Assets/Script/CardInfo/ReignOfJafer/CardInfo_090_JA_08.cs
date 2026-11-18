using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_08 : CardInfo
{
    public CardInfo_090_JA_08()
    {
        this.cardNo = "090_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "トカゲのビル";
        this.cardName2 = "煙突掃除";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
