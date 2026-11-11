using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_05 : CardInfo
{
    public CardInfo_218_JA_05()
    {
        this.cardNo = "218_JA_05";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "キャンディ大王";
        this.cardName2 = "スイートなバケモノ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LorenzaPigliamosche;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
