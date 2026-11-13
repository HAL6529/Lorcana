using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_07 : CardInfo
{
    public CardInfo_203_JA_07()
    {
        this.cardNo = "203_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "スティール・コイル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.FrancescoColucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
