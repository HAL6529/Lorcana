using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_13 : CardInfo
{
    public CardInfo_095_JA_13()
    {
        this.cardNo = "095_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "塔を棄てよラプンツェル";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
