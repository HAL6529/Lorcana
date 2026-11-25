using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_13 : CardInfo
{
    public CardInfo_039_JA_13()
    {
        this.cardNo = "039_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "大得意の呪文使い";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OrnellaSavarese;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
