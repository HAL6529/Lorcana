using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_06 : CardInfo
{
    public CardInfo_104_JA_06()
    {
        this.cardNo = "104_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉJÉJÉÇÉâ";
        this.cardName2 = "èÊÇËçûÇ›ë‡";
        this.power = 5;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
