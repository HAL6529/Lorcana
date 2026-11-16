using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_06 : CardInfo
{
    public CardInfo_014_JA_06()
    {
        this.cardNo = "014_JA_06";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "チップ＆デール";
        this.cardName2 = "リカバリー・レンジャーズ";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
