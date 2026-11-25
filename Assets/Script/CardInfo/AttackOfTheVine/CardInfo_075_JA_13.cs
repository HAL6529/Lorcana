using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_13 : CardInfo
{
    public CardInfo_075_JA_13()
    {
        this.cardNo = "075_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "エリー･フレドリクセン";
        this.cardName2 = "愛する妻";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
