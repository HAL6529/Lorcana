using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_14 : CardInfo
{
    public CardInfo_120_JA_14()
    {
        this.cardNo = "120_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "エルネスト・デラクルス";
        this.cardName2 = "手段選ばぬ音楽家";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer8 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
