using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_02 : CardInfo
{
    public CardInfo_132_JA_02()
    {
        this.cardNo = "132_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "âΩÇ∆åƒÇÒÇæÅH";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}
