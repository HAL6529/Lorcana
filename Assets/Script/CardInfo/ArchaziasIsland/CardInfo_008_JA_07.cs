using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_07 : CardInfo
{
    public CardInfo_008_JA_07()
    {
        this.cardNo = "008_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スージー";
        this.cardName2 = "達者なお針子";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
