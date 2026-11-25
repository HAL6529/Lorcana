using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_13 : CardInfo
{
    public CardInfo_080_JA_13()
    {
        this.cardNo = "080_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "塔の番人";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
