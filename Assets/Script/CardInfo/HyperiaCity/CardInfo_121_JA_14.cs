using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_14 : CardInfo
{
    public CardInfo_121_JA_14()
    {
        this.cardNo = "121_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヘクター・リヴェラ";
        this.cardName2 = "俺はバラバラ";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer6 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
