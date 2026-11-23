using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_11 : CardInfo
{
    public CardInfo_044_JA_11()
    {
        this.cardNo = "044_JA_11";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ターラン";
        this.cardName2 = "魔法の剣を振るう者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
