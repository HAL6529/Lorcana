using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_242_JA_11 : CardInfo
{
    public CardInfo_242_JA_11()
    {
        this.cardNo = "242_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "モアナ";
        this.cardName2 = "好奇心旺盛な探検家";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeslieStrock;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Iconic;
    }
}
