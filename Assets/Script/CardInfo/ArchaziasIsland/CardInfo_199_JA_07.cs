using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_07 : CardInfo
{
    public CardInfo_199_JA_07()
    {
        this.cardNo = "199_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉKÉìÉgÉD";
        this.cardName2 = "óêÌÇÃé∑çsäØ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
