using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_04 : CardInfo
{
    public CardInfo_139_JA_04()
    {
        this.cardNo = "139_JA_04";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ÉAÉäÉGÉã";
        this.cardName2 = "ïÛï®é˚èWâ∆";
        this.power = 3;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.TaniaSoler;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
