using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_12 : CardInfo
{
    public CardInfo_039_JA_12()
    {
        this.cardNo = "039_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "てれすけ";
        this.cardName2 = "ガタゴトするこびと";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
