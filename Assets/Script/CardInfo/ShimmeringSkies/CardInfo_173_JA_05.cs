using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_05 : CardInfo
{
    public CardInfo_173_JA_05()
    {
        this.cardNo = "173_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒo";
        this.cardName2 = "Ž¸‚í‚ê‚½‰¤Žq";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
