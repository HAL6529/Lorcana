using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_04 : CardInfo
{
    public CardInfo_049_JA_04()
    {
        this.cardNo = "049_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@ÇÃÇŸÇ§Ç´";
        this.cardName2 = "å≥ãCÇ»ë|èúâÆ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
