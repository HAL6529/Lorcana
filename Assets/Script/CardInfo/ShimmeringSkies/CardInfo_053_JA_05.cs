using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_05 : CardInfo
{
    public CardInfo_053_JA_05()
    {
        this.cardNo = "053_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マジカ・デ・スペル";
        this.cardName2 = "冷酷な魔女";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
