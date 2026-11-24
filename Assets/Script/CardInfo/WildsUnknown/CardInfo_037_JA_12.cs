using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_12 : CardInfo
{
    public CardInfo_037_JA_12()
    {
        this.cardNo = "037_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "白雪姫";
        this.cardName2 = "朝日のように朗らかに";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
