using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_07 : CardInfo
{
    public CardInfo_052_JA_07()
    {
        this.cardNo = "052_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "早口の神";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
