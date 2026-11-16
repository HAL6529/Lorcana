using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_06 : CardInfo
{
    public CardInfo_150_JA_06()
    {
        this.cardNo = "150_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "ずるいキツネ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift1 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
