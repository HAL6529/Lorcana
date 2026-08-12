using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_01 : CardInfo
{
    public CardInfo_018_JA_01()
    {
        this.cardNo = "018_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒvƒ“ƒcƒFƒ‹";
        this.cardName2 = "‚¢‚â‚µ‚ÌŽ’•¨";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Jochem Van Gool";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
