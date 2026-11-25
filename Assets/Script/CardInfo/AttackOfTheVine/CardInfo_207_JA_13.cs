using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_13 : CardInfo
{
    public CardInfo_207_JA_13()
    {
        this.cardNo = "207_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヴァインズの入り口";
        this.cardName2 = "ぶきみな抜け道";
        this.power = 1;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
