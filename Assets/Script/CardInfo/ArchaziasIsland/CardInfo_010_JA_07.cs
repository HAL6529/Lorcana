using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_07 : CardInfo
{
    public CardInfo_010_JA_07()
    {
        this.cardNo = "010_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ƒgƒ‰ƒ“ƒv";
        this.cardName2 = "— ˜H’n•é‚ç‚µ‚ÌŒ¢";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
