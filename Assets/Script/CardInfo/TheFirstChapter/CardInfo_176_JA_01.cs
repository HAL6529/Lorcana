using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_01 : CardInfo
{
    public CardInfo_176_JA_01()
    {
        this.cardNo = "176_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ケルベロス";
        this.cardName2 = "三つ首の番犬";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Oleg Yurkov";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
