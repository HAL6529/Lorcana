using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_11 : CardInfo
{
    public CardInfo_113_JA_11()
    {
        this.cardNo = "113_JA_11";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "イドゥナ";
        this.cardName2 = "驚く王妃";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PatriBalanovsky;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Queen};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
