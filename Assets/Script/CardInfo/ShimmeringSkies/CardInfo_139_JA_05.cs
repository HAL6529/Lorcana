using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_05 : CardInfo
{
    public CardInfo_139_JA_05()
    {
        this.cardNo = "139_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "Ç±ÇÃê¢Ç≈ç≈çÇÇ…Ç–Ç«Ç¢èó";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
