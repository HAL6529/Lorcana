using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_13 : CardInfo
{
    public CardInfo_086_JA_13()
    {
        this.cardNo = "086_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "ハチドリ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
