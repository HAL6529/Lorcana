using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_13 : CardInfo
{
    public CardInfo_147_JA_13()
    {
        this.cardNo = "147_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "クアッカージャック";
        this.cardName2 = "おかしなおもちゃ職人";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain, EnumController.Class.Inventor};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
