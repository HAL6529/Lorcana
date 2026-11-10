using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_03 : CardInfo
{
    public CardInfo_084_JA_03()
    {
        this.cardNo = "084_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "明日の義賊";
        this.power = 4;
        this.toughness = 5;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.JohnLoren;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
