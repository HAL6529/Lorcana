using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_01 : CardInfo
{
    public CardInfo_007_JA_01()
    {
        this.cardNo = "007_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒwƒCƒwƒC";
        this.cardName2 = "‚¨‚â‚ÂŒ©‚Á‚¯!";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Jenna Gray";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
