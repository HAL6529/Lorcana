using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_03 : CardInfo
{
    public CardInfo_048_JA_03()
    {
        this.cardNo = "048_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マジカ・デ・スペル";
        this.cardName2 = "野心家の魔女";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
