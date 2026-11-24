using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_234_JA_12 : CardInfo
{
    public CardInfo_234_JA_12()
    {
        this.cardNo = "234_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "Mr.インクレディブル";
        this.cardName2 = "怪力パパ";
        this.power = 6;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
