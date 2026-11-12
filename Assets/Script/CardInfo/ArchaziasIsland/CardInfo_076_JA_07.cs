using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_07 : CardInfo
{
    public CardInfo_076_JA_07()
    {
        this.cardNo = "076_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "有能フクロウ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
