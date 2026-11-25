using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_13 : CardInfo
{
    public CardInfo_116_JA_13()
    {
        this.cardNo = "116_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ハティ大佐";
        this.cardName2 = "行進するゾウ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
