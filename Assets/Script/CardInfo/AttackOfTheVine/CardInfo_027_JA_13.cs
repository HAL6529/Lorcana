using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_13 : CardInfo
{
    public CardInfo_027_JA_13()
    {
        this.cardNo = "027_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ポカホンタス＆ミーコ";
        this.cardName2 = "冒険仲間";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
