using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_14 : CardInfo
{
    public CardInfo_143_JA_14()
    {
        this.cardNo = "143_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アビゲイル＆アミリア";
        this.cardName2 = "ゴシップ好きのガチョウたち";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LauraPauselli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
