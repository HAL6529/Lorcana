using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_06 : CardInfo
{
    public CardInfo_049_JA_06()
    {
        this.cardNo = "049_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "従順なワタリガラス";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferWu;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
