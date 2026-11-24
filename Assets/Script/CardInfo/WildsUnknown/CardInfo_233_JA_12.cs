using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_233_JA_12 : CardInfo
{
    public CardInfo_233_JA_12()
    {
        this.cardNo = "233_JA_12";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "レヴィアタン";
        this.cardName2 = "アトランティスの守護怪獣";
        this.power = 10;
        this.toughness = 10;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Monster, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
