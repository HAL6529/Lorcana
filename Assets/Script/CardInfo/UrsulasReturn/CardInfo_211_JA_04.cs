using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_211_JA_04 : CardInfo
{
    public CardInfo_211_JA_04()
    {
        this.cardNo = "211_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "忠実なる使い魔";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftDiscardAnActionCard, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
