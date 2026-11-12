using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_07 : CardInfo
{
    public CardInfo_022_JA_07()
    {
        this.cardNo = "022_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フィックス・イット・フェリックス JR.";
        this.cardName2 = "小粒なヒーロー";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
