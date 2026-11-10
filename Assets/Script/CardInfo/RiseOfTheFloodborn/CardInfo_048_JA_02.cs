using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_02 : CardInfo
{
    public CardInfo_048_JA_02()
    {
        this.cardNo = "048_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "マーリンのライバル";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ManeKandalyanMandersonAndPixSmith;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
