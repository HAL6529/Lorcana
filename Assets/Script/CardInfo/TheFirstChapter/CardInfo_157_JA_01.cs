using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_01 : CardInfo
{
    public CardInfo_157_JA_01()
    {
        this.cardNo = "157_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "比類なき弓の名手";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "John Loren";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
