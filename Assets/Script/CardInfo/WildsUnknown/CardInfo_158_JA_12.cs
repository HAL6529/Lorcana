using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_12 : CardInfo
{
    public CardInfo_158_JA_12()
    {
        this.cardNo = "158_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "カシェキム";
        this.cardName2 = "叡智ある王";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
