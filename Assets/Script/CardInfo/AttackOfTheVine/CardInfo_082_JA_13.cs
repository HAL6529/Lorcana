using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_13 : CardInfo
{
    public CardInfo_082_JA_13()
    {
        this.cardNo = "082_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ラッセル";
        this.cardName2 = "ジュニア自然探険隊員";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
