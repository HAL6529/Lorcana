using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_02 : CardInfo
{
    public CardInfo_072_JA_02()
    {
        this.cardNo = "072_JA_02";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ÉxÉã";
        this.cardName2 = "êXÇÃíÜÇÃéÀéË";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
