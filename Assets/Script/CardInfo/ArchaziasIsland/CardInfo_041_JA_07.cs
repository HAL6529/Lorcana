using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_07 : CardInfo
{
    public CardInfo_041_JA_07()
    {
        this.cardNo = "041_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アンバー・コイル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.FrancescoColucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
