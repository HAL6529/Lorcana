using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_07 : CardInfo
{
    public CardInfo_169_JA_07()
    {
        this.cardNo = "169_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "化学の達人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BriannaGarcia;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
