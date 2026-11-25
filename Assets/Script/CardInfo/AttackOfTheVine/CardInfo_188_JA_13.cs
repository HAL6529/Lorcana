using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_13 : CardInfo
{
    public CardInfo_188_JA_13()
    {
        this.cardNo = "188_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "オムニドロイド";
        this.cardName2 = "索敵モード";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
