using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_07 : CardInfo
{
    public CardInfo_024_JA_07()
    {
        this.cardNo = "024_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "â§éq";
        this.cardName2 = "ópêSê[Ç¢ãÅç•é“";
        this.power = 0;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
