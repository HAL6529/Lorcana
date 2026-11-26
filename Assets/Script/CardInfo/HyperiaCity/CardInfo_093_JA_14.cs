using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_14 : CardInfo
{
    public CardInfo_093_JA_14()
    {
        this.cardNo = "093_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "極限への挑戦";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Caelys;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
