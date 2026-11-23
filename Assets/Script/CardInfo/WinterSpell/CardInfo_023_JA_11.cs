using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_11 : CardInfo
{
    public CardInfo_023_JA_11()
    {
        this.cardNo = "023_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "シンバ";
        this.cardName2 = "飛び掛かり上手";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandyLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
