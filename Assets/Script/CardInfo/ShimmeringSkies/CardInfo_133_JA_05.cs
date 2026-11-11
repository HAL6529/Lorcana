using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_05 : CardInfo
{
    public CardInfo_133_JA_05()
    {
        this.cardNo = "133_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ˆø‚«”²‚©‚ê‚½Œ•";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
