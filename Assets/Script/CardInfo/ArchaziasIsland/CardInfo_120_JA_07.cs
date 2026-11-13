using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_07 : CardInfo
{
    public CardInfo_120_JA_07()
    {
        this.cardNo = "120_JA_07";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "エメラルド・コイル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.FrancescoColucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
