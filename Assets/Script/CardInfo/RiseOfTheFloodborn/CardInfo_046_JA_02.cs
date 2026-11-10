using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_02 : CardInfo
{
    public CardInfo_046_JA_02()
    {
        this.cardNo = "046_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "キツネ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
