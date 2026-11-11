using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_05 : CardInfo
{
    public CardInfo_123_JA_05()
    {
        this.cardNo = "123_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ラティガン";
        this.cardName2 = "パーティーの台無し屋";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
