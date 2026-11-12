using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_07 : CardInfo
{
    public CardInfo_021_JA_07()
    {
        this.cardNo = "021_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ペニー";
        this.cardName2 = "ボルトが大好きな人間";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
