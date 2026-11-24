using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_12 : CardInfo
{
    public CardInfo_047_JA_12()
    {
        this.cardNo = "047_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "鬼火";
        this.cardName2 = "森の精霊";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
