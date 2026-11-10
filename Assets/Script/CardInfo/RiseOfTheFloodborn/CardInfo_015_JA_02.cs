using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_02 : CardInfo
{
    public CardInfo_015_JA_02()
    {
        this.cardNo = "015_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "é©óRÇ»ó∑êl";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
