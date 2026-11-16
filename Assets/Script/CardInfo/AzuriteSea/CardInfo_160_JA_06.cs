using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_06 : CardInfo
{
    public CardInfo_160_JA_06()
    {
        this.cardNo = "160_JA_06";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "ヨウカイ";
        this.cardName2 = "科学的スーパーヴィラン";
        this.power = 6;
        this.toughness = 10;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
