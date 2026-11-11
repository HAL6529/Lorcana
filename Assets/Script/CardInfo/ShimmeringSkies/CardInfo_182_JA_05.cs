using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_05 : CardInfo
{
    public CardInfo_182_JA_05()
    {
        this.cardNo = "182_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ナマーリ";
        this.cardName2 = "覚悟を決めた娘";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist3 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
