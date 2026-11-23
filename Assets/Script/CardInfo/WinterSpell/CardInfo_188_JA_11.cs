using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_11 : CardInfo
{
    public CardInfo_188_JA_11()
    {
        this.cardNo = "188_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "ダークウォリアー";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
