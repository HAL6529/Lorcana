using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_12 : CardInfo
{
    public CardInfo_041_JA_12()
    {
        this.cardNo = "041_JA_12";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "おこりんぼ";
        this.cardName2 = "カンカンするこびと";
        this.power = 7;
        this.toughness = 7;
        this.lore = 2;
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
