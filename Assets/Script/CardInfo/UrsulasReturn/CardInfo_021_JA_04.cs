using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_04 : CardInfo
{
    public CardInfo_021_JA_04()
    {
        this.cardNo = "021_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エリック王子";
        this.cardName2 = "航海王子";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LinhDang;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
