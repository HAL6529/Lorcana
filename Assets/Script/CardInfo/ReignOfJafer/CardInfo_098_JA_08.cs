using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_08 : CardInfo
{
    public CardInfo_098_JA_08()
    {
        this.cardNo = "098_JA_08";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "大怪獣現る！";
        this.power = 5;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
