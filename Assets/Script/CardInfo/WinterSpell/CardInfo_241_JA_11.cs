using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_241_JA_11 : CardInfo
{
    public CardInfo_241_JA_11()
    {
        this.cardNo = "241_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ポカホンタス";
        this.cardName2 = "平和の使者";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DomenicoRusso;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Iconic;
    }
}
