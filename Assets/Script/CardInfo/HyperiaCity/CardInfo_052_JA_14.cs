using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_14 : CardInfo
{
    public CardInfo_052_JA_14()
    {
        this.cardNo = "052_JA_14";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "マーリン";
        this.cardName2 = "インク・ドロップ細工師";
        this.power = 6;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.KierstenHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
