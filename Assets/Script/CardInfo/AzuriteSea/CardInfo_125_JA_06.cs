using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_06 : CardInfo
{
    public CardInfo_125_JA_06()
    {
        this.cardNo = "125_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "威圧的なボス";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
