using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_12 : CardInfo
{
    public CardInfo_146_JA_12()
    {
        this.cardNo = "146_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ニムナル博士";
        this.cardName2 = "人間嫌いの天才";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcoGiorgianniAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
