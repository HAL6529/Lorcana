using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_05 : CardInfo
{
    public CardInfo_152_JA_05()
    {
        this.cardNo = "152_JA_05";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "機転の利く発明家";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LaurenLevering;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
