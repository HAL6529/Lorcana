using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_12 : CardInfo
{
    public CardInfo_081_JA_12()
    {
        this.cardNo = "081_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "四方を巡る探索者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> {  EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
