using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_05 : CardInfo
{
    public CardInfo_024_JA_05()
    {
        this.cardNo = "024_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "心優しいお友だち";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
