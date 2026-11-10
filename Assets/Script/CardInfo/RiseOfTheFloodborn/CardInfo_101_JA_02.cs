using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_02 : CardInfo
{
    public CardInfo_101_JA_02()
    {
        this.cardNo = "101_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "‚²‚¿‚»‚¤‚Ìƒxƒ‹";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
