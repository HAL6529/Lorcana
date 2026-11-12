using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_07 : CardInfo
{
    public CardInfo_086_JA_07()
    {
        this.cardNo = "086_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉOÉãÅ[ÉìÉW";
        this.cardName2 = "ñCèpét";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimangalisoSibayaAndMarioManzanares;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
