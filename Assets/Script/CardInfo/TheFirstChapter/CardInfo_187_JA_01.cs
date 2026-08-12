using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_01 : CardInfo
{
    public CardInfo_187_JA_01()
    {
        this.cardNo = "187_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "エリック王子";
        this.cardName2 = "勇猛果敢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Cristian Romero";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
