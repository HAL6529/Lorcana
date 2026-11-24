using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_12 : CardInfo
{
    public CardInfo_086_JA_12()
    {
        this.cardNo = "086_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "エリノア";
        this.cardName2 = "名高い外交家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
