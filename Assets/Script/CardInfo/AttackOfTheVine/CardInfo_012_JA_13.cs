using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_13 : CardInfo
{
    public CardInfo_012_JA_13()
    {
        this.cardNo = "012_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ポカホンタス";
        this.cardName2 = "部族の導き手";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
