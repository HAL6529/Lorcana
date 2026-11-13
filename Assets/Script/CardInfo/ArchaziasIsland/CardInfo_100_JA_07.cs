using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_07 : CardInfo
{
    public CardInfo_100_JA_07()
    {
        this.cardNo = "100_JA_07";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "レディ";
        this.cardName2 = "すてきなスパニエル";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SaraLeal_Loyal;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
