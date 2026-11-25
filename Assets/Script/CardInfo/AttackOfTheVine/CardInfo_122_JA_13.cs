using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_13 : CardInfo
{
    public CardInfo_122_JA_13()
    {
        this.cardNo = "122_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "野獣";
        this.cardName2 = "猛烈なる守護者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
