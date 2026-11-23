using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_230_JA_11 : CardInfo
{
    public CardInfo_230_JA_11()
    {
        this.cardNo = "230_JA_11";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "トッド";
        this.cardName2 = "魚取りの名人";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MariaLuisaPetrarca;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
