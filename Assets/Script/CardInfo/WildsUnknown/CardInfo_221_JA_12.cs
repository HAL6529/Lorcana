using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_221_JA_12 : CardInfo
{
    public CardInfo_221_JA_12()
    {
        this.cardNo = "221_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "インクレディボーイ";
        this.cardName2 = "バディ・パイン";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
