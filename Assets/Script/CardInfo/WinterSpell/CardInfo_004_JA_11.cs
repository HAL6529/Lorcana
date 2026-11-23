using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_11 : CardInfo
{
    public CardInfo_004_JA_11()
    {
        this.cardNo = "004_JA_11";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "プンバァ";
        this.cardName2 = "いてつくイボイノシシ";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SandyLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
