using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_05 : CardInfo
{
    public CardInfo_109_JA_05()
    {
        this.cardNo = "109_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉXÉJÅ[";
        this.cardName2 = "ó†êÿÇËé“";
        this.power = 6;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DinulescuAlexandru;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
