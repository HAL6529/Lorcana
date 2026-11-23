using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_11 : CardInfo
{
    public CardInfo_086_JA_11()
    {
        this.cardNo = "086_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ビクシー";
        this.cardName2 = "森の友だち";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
