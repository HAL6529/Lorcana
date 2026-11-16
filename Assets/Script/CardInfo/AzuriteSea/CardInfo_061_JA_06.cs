using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_06 : CardInfo
{
    public CardInfo_061_JA_06()
    {
        this.cardNo = "061_JA_06";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "驚異の大トリックスター";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
