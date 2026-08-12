using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_01 : CardInfo
{
    public CardInfo_051_JA_01()
    {
        this.cardNo = "051_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "きまぐれな魔法使い";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
