using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_06 : CardInfo
{
    public CardInfo_127_JA_06()
    {
        this.cardNo = "127_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ÉXÉJÅ[";
        this.cardName2 = "ó‚çìÇ»ÇÈéÎÇËéË";
        this.power = 4;
        this.toughness = 2;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.Cookie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
