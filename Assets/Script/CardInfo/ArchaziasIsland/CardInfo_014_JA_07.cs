using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_07 : CardInfo
{
    public CardInfo_014_JA_07()
    {
        this.cardNo = "014_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉIÅ[ÉçÉâ";
        this.cardName2 = "ñ⁄äoÇﬂÇÃêXÇÃî¸èó";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
