using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_06 : CardInfo
{
    public CardInfo_042_JA_06()
    {
        this.cardNo = "042_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ラフィキ";
        this.cardName2 = "サバンナの祈祷師";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
