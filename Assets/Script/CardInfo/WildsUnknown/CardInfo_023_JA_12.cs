using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_12 : CardInfo
{
    public CardInfo_023_JA_12()
    {
        this.cardNo = "023_JA_12";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "王子";
        this.cardName2 = "想い人の探索者";
        this.power = 0;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulieVu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
