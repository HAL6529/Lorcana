using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_01 : CardInfo
{
    public CardInfo_111_JA_01()
    {
        this.cardNo = "111_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "向こう見ず";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
