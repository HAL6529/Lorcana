using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_07 : CardInfo
{
    public CardInfo_115_JA_07()
    {
        this.cardNo = "115_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "冷たく残酷な妬みの心";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
