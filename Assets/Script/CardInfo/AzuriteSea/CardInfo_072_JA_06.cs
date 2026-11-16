using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_06 : CardInfo
{
    public CardInfo_072_JA_06()
    {
        this.cardNo = "072_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スティッチ";
        this.cardName2 = "エイリアンのバッカニーア";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Alien, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
