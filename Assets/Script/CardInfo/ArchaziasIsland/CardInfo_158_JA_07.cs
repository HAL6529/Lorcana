using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_07 : CardInfo
{
    public CardInfo_158_JA_07()
    {
        this.cardNo = "158_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ガエタン・モリエール";
        this.cardName2 = "もぐら";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
