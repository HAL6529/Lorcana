using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_05 : CardInfo
{
    public CardInfo_086_JA_05()
    {
        this.cardNo = "086_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒNƒ‰ƒ‰ƒxƒ‹";
        this.cardName2 = "‚¨‚Á‚¿‚å‚±‚¿‚å‚¢";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
