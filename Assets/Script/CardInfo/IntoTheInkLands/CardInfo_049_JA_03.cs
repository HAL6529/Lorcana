using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_03 : CardInfo
{
    public CardInfo_049_JA_03()
    {
        this.cardNo = "049_JA_03";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "マジカ・デ・スペル";
        this.cardName2 = "ミダス王の手";
        this.power = 4;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.LaurenLevering;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
