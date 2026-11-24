using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_12 : CardInfo
{
    public CardInfo_044_JA_12()
    {
        this.cardNo = "044_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ねぼすけ";
        this.cardName2 = "スヤスヤするこびと";
        this.power = 1;
        this.toughness = 2;
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
