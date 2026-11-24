using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_12 : CardInfo
{
    public CardInfo_008_JA_12()
    {
        this.cardNo = "008_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "エリック王子";
        this.cardName2 = "高貴な剣士";
        this.power = 6;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MartaAndreeva;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
