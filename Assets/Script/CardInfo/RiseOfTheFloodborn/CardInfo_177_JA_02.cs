using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_02 : CardInfo
{
    public CardInfo_177_JA_02()
    {
        this.cardNo = "177_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉVÉìÉfÉåÉâ";
        this.cardName2 = "çÑí_Ç»ÇÈïPåN";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
