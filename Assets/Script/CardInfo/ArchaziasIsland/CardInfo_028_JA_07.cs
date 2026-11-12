using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_07 : CardInfo
{
    public CardInfo_028_JA_07()
    {
        this.cardNo = "028_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "レディ";
        this.cardName2 = "ミス・ニューヨーク";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
