using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_06 : CardInfo
{
    public CardInfo_055_JA_06()
    {
        this.cardNo = "055_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "世界一素晴らしい魔女";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
