using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_221_JA_05 : CardInfo
{
    public CardInfo_221_JA_05()
    {
        this.cardNo = "221_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "アーサー";
        this.cardName2 = "勝利王";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.LisaParfenova;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
