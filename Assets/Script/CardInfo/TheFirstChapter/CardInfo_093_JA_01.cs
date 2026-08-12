using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_01 : CardInfo
{
    public CardInfo_093_JA_01()
    {
        this.cardNo = "093_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "頼りになるよ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Caner Soylu";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
