using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_01 : CardInfo
{
    public CardInfo_115_JA_01()
    {
        this.cardNo = "115_JA_01";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "ブレイブ・リトル・テイラー";
        this.power = 5;
        this.toughness = 5;
        this.lore = 4;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
