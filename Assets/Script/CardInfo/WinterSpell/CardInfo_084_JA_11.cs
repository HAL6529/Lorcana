using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_11 : CardInfo
{
    public CardInfo_084_JA_11()
    {
        this.cardNo = "084_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "コッパー";
        this.cardName2 = "森の勇者";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
