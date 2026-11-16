using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_06 : CardInfo
{
    public CardInfo_015_JA_06()
    {
        this.cardNo = "015_JA_06";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "かしこいウサギ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
