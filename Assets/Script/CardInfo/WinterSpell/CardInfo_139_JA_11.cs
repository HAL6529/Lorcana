using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_11 : CardInfo
{
    public CardInfo_139_JA_11()
    {
        this.cardNo = "139_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ピグレット";
        this.cardName2 = "雪に見とれちゃうよ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AurelieLise_Anne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
