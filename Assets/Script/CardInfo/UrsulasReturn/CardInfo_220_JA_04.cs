using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_04 : CardInfo
{
    public CardInfo_220_JA_04()
    {
        this.cardNo = "220_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉAÉäÉGÉã";
        this.cardName2 = "âπãøÇÃêÌém";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.noc4urne;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
