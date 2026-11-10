using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_02 : CardInfo
{
    public CardInfo_125_JA_02()
    {
        this.cardNo = "125_JA_02";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ÉXÉJÅ[";
        this.cardName2 = "ã•à´Ç»ñdÇËâÆ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
