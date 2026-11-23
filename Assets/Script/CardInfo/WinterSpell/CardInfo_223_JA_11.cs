using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_223_JA_11 : CardInfo
{
    public CardInfo_223_JA_11()
    {
        this.cardNo = "223_JA_11";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "リロ";
        this.cardName2 = "ロックスター";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DomenicoRusso;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
