using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_12 : CardInfo
{
    public CardInfo_188_JA_12()
    {
        this.cardNo = "188_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "モーディ";
        this.cardName2 = "うんざり乳母";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
