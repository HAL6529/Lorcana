using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_11 : CardInfo
{
    public CardInfo_161_JA_11()
    {
        this.cardNo = "161_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "村長トゥイ";
        this.cardName2 = "物語の紡ぎ手";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValentinPalombo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
