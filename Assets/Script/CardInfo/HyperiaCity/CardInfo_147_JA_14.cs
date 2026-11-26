using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_14 : CardInfo
{
    public CardInfo_147_JA_14()
    {
        this.cardNo = "147_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ライオンハート";
        this.cardName2 = "この街をきれいに！";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
