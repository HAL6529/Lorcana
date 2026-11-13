using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_07 : CardInfo
{
    public CardInfo_183_JA_07()
    {
        this.cardNo = "183_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ÉwÉãÉKÅEÉVÉìÉNÉåÉA";
        this.cardName2 = "ìSÇÃèó";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Samoldstoree;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
