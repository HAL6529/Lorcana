using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_07 : CardInfo
{
    public CardInfo_154_JA_07()
    {
        this.cardNo = "154_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "抜け目ない守銭奴";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
