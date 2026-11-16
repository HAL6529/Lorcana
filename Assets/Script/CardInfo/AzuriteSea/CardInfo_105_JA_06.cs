using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_06 : CardInfo
{
    public CardInfo_105_JA_06()
    {
        this.cardNo = "105_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "カカモラ";
        this.cardName2 = "海賊カタパルト";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
