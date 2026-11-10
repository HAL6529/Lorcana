using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_03 : CardInfo
{
    public CardInfo_103_JA_03()
    {
        this.cardNo = "103_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アリエル";
        this.cardName2 = "冒険好きな収集家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
