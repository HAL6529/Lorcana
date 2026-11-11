using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_05 : CardInfo
{
    public CardInfo_005_JA_05()
    {
        this.cardNo = "005_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "キナイ";
        this.cardName2 = "お兄ちゃん";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ChunxiMu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
