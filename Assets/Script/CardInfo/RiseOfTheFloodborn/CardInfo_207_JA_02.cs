using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_02 : CardInfo
{
    public CardInfo_207_JA_02()
    {
        this.cardNo = "207_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アーサー";
        this.cardName2 = "魔法使いの弟子";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
