using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_03 : CardInfo
{
    public CardInfo_147_JA_03()
    {
        this.cardNo = "147_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "航空士";
        this.power = 2;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.RogerPerez;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
