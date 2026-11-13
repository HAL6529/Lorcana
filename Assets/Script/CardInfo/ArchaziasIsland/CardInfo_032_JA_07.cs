using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_07 : CardInfo
{
    public CardInfo_032_JA_07()
    {
        this.cardNo = "032_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パーラ";
        this.cardName2 = "器用なお針子";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
