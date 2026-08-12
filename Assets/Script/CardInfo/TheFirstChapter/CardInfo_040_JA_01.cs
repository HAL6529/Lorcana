using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_01 : CardInfo
{
    public CardInfo_040_JA_01()
    {
        this.cardNo = "040_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉGÉãÉT";
        this.cardName2 = "ïXè„ÇÃåNéÂ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Duyen Nguyen / Aubrey Archer";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
