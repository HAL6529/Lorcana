using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_05 : CardInfo
{
    public CardInfo_144_JA_05()
    {
        this.cardNo = "144_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "Ç±ÇÃê¢Ç≈ç≈çÇÇ…î¸ÇµÇ¢èó";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
