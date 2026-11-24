using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_12 : CardInfo
{
    public CardInfo_137_JA_12()
    {
        this.cardNo = "137_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "砂漠の放浪者";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSlawinski;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
