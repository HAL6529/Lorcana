using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_02 : CardInfo
{
    public CardInfo_052_JA_02()
    {
        this.cardNo = "052_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "マーリン";
        this.cardName2 = "ウサギ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
