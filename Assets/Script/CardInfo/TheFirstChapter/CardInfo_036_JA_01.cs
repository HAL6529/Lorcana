using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_01 : CardInfo
{
    public CardInfo_036_JA_01()
    {
        this.cardNo = "036_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "教育のあるフクロウ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Kendall Hale";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
