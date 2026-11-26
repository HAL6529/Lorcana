using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_14 : CardInfo
{
    public CardInfo_125_JA_14()
    {
        this.cardNo = "125_JA_14";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ワサビ";
        this.cardName2 = "バトルに備えろ！";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlbertoBesi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
