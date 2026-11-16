using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_06 : CardInfo
{
    public CardInfo_074_JA_06()
    {
        this.cardNo = "074_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "化学の天才";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AristeidisZentelis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
