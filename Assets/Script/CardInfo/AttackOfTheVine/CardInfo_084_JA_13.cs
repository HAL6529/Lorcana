using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_13 : CardInfo
{
    public CardInfo_084_JA_13()
    {
        this.cardNo = "084_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ウィニフレッド";
        this.cardName2 = "もうたくさんだゾウ";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Noukah;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
