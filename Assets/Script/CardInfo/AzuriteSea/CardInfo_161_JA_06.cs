using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_06 : CardInfo
{
    public CardInfo_161_JA_06()
    {
        this.cardNo = "161_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アリス";
        this.cardName2 = "ビン腕な船乗り";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DustinPanzino;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
