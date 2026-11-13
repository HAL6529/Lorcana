using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_07 : CardInfo
{
    public CardInfo_194_JA_07()
    {
        this.cardNo = "194_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "オービル";
        this.cardName2 = "アホウドリ航空";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
