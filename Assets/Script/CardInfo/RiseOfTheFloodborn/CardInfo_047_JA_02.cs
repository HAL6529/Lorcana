using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_02 : CardInfo
{
    public CardInfo_047_JA_02()
    {
        this.cardNo = "047_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "紫の竜";
        this.power = 5;
        this.toughness = 7;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
