using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_04 : CardInfo
{
    public CardInfo_175_JA_04()
    {
        this.cardNo = "175_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉAÉäÉGÉã";
        this.cardName2 = "âπãøÇÃêÌém";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
