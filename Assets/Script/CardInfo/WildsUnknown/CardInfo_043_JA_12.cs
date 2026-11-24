using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_12 : CardInfo
{
    public CardInfo_043_JA_12()
    {
        this.cardNo = "043_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ごきげん";
        this.cardName2 = "ツンツンするこびと";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
