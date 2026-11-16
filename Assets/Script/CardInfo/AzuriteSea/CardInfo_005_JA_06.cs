using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_06 : CardInfo
{
    public CardInfo_005_JA_06()
    {
        this.cardNo = "005_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "シンバ";
        this.cardName2 = "お気楽王子";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarcoGiorgianni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
