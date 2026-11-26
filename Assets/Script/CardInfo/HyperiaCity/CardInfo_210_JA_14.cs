using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_14 : CardInfo
{
    public CardInfo_210_JA_14()
    {
        this.cardNo = "210_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "伝書フクロウ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GregShrader;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
