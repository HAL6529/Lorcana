using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_01 : CardInfo
{
    public CardInfo_042_JA_01()
    {
        this.cardNo = "042_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ÉGÉãÉT";
        this.cardName2 = "ì~ÇÃê∏óÏ";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
