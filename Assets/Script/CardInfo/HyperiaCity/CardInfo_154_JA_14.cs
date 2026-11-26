using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_14 : CardInfo
{
    public CardInfo_154_JA_14()
    {
        this.cardNo = "154_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "デイキャンプのインストラクター";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaredMathewsAndAmberKommavongsa;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
