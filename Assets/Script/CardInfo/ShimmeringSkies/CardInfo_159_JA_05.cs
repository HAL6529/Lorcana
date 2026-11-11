using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_05 : CardInfo
{
    public CardInfo_159_JA_05()
    {
        this.cardNo = "159_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "マーリン";
        this.cardName2 = "知的な先見者";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
