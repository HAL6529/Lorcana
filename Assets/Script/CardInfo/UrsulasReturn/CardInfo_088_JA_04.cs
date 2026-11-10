using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_04 : CardInfo
{
    public CardInfo_088_JA_04()
    {
        this.cardNo = "088_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フィリップ王子";
        this.cardName2 = "森の番人";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
