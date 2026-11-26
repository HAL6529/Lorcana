using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_14 : CardInfo
{
    public CardInfo_152_JA_14()
    {
        this.cardNo = "152_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トーマス・オマリー";
        this.cardName2 = "抜け目ない放浪者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdaDevecchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
