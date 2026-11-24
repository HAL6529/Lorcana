using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_12 : CardInfo
{
    public CardInfo_087_JA_12()
    {
        this.cardNo = "087_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ライル・ティベリウス・ローク";
        this.cardName2 = "雇われ冒険屋";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SytzeBrommersma;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
