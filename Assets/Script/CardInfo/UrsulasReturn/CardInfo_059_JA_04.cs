using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_04 : CardInfo
{
    public CardInfo_059_JA_04()
    {
        this.cardNo = "059_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "イェン・シッド";
        this.cardName2 = "海の魔女";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
