using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_07 : CardInfo
{
    public CardInfo_121_JA_07()
    {
        this.cardNo = "121_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ファ家の祖母";
        this.cardName2 = "イキイキおばあちゃん";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
