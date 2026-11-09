using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_03 : CardInfo
{
    public CardInfo_050_JA_03()
    {
        this.cardNo = "050_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マジカ・デ・スペル";
        this.cardName2 = "泥棒魔女";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
