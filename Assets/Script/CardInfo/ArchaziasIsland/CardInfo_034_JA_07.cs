using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_07 : CardInfo
{
    public CardInfo_034_JA_07()
    {
        this.cardNo = "034_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "コーダ";
        this.cardName2 = "小さいクマさん";
        this.power = 2;
        this.toughness = 2;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
