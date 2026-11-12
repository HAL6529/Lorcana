using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_07 : CardInfo
{
    public CardInfo_056_JA_07()
    {
        this.cardNo = "056_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "インチキ呪文使い";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JocelynSepulveda;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
