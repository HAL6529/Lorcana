using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_13 : CardInfo
{
    public CardInfo_209_JA_13()
    {
        this.cardNo = "209_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ブー";
        this.cardName2 = "モンスターごっこ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
