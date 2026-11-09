using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_04 : CardInfo
{
    public CardInfo_012_JA_04()
    {
        this.cardNo = "012_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉOÅ[ÉtÉBÅ[";
        this.cardName2 = "èeémë‡ÇÃåïém";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
