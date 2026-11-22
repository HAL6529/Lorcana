using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_10 : CardInfo
{
    public CardInfo_078_JA_10()
    {
        this.cardNo = "078_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フックハンド";
        this.cardName2 = "意外といいやつ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
