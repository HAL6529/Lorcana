using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_13 : CardInfo
{
    public CardInfo_011_JA_13()
    {
        this.cardNo = "011_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ココアム";
        this.cardName2 = "部族の守り手";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MelMilton;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
