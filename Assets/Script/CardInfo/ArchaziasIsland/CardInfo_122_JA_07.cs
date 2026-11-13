using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_07 : CardInfo
{
    public CardInfo_122_JA_07()
    {
        this.cardNo = "122_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "怒髪天";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AntoineCouttolencAndSamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
