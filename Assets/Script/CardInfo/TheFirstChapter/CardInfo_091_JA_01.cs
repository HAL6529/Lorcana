using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_01 : CardInfo
{
    public CardInfo_091_JA_01()
    {
        this.cardNo = "091_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "飛び続けネバーランド";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Koni";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
