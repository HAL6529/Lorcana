using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_05 : CardInfo
{
    public CardInfo_145_JA_05()
    {
        this.cardNo = "145_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ÉmÉbÉeÉBÉìÉKÉÄÇÃÉVÉFÉäÉt";
        this.cardName2 = "êKÇÃÇ≈Ç©Ç¢ó~í£ÇË";
        this.power = 5;
        this.toughness = 9;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.JosepSole;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
