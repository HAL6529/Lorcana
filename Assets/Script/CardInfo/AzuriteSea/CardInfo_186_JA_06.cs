using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_06 : CardInfo
{
    public CardInfo_186_JA_06()
    {
        this.cardNo = "186_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "用心犬";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigHaggman_Sund;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
