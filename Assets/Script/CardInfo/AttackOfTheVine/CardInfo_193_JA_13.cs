using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_13 : CardInfo
{
    public CardInfo_193_JA_13()
    {
        this.cardNo = "193_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "悪の女王の近衛";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LizRichards;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
