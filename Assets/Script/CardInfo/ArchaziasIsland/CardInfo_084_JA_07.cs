using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_07 : CardInfo
{
    public CardInfo_084_JA_07()
    {
        this.cardNo = "084_JA_07";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アメジスト・コイル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.FrancescoColucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
