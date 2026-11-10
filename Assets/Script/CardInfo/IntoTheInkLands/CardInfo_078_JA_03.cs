using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_03 : CardInfo
{
    public CardInfo_078_JA_03()
    {
        this.cardNo = "078_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ライル・ティベリウス・ローク";
        this.cardName2 = "狡猾な雇われ兵";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
