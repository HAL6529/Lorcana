using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_01 : CardInfo
{
    public CardInfo_119_JA_01()
    {
        this.cardNo = "119_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "恐れ知らずの戦士";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Anh Dang";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
