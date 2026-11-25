using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_13 : CardInfo
{
    public CardInfo_015_JA_13()
    {
        this.cardNo = "015_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ガストン";
        this.cardName2 = "傲慢ボウマン";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ManeKandalyanManderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
