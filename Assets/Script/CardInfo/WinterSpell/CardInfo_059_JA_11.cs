using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_11 : CardInfo
{
    public CardInfo_059_JA_11()
    {
        this.cardNo = "059_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "プア";
        this.cardName2 = "ブーたれてるブタ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
