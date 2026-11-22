using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_10 : CardInfo
{
    public CardInfo_039_JA_10()
    {
        this.cardNo = "039_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "コルドロン生まれの兵";
        this.cardName2 = "意志なき大群";
        this.power = 6;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
