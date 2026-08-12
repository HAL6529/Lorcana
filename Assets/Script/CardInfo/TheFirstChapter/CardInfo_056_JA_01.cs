using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_01 : CardInfo
{
    public CardInfo_056_JA_01()
    {
        this.cardNo = "056_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "ê´à´Ç»Ç§Ç Ç⁄ÇÍâÆ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
