using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_02 : CardInfo
{
    public CardInfo_173_JA_02()
    {
        this.cardNo = "173_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "îﬂåÄÇÃéÂêlåˆ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EvanaKisa;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
