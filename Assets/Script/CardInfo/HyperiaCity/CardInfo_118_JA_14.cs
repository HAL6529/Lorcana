using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_14 : CardInfo
{
    public CardInfo_118_JA_14()
    {
        this.cardNo = "118_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "エルネスト・デラクルス";
        this.cardName2 = "百万人の大スター";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
