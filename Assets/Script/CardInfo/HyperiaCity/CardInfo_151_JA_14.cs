using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_14 : CardInfo
{
    public CardInfo_151_JA_14()
    {
        this.cardNo = "151_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "底なし好奇心";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TaniaSoler;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
