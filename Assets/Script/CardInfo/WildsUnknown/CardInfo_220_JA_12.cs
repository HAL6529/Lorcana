using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_12 : CardInfo
{
    public CardInfo_220_JA_12()
    {
        this.cardNo = "220_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ポカホンタス";
        this.cardName2 = "揺るぎない旅人";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
