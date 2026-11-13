using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_07 : CardInfo
{
    public CardInfo_159_JA_07()
    {
        this.cardNo = "159_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉxÉã";
        this.cardName2 = "å©èKÇ¢î≠ñæâ∆";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
