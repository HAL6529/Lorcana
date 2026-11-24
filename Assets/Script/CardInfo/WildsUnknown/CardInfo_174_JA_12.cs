using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_12 : CardInfo
{
    public CardInfo_174_JA_12()
    {
        this.cardNo = "174_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アンガス";
        this.cardName2 = "力強い馬";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MilicaCelikovic;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
