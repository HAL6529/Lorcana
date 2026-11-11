using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_05 : CardInfo
{
    public CardInfo_160_JA_05()
    {
        this.cardNo = "160_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "–¢—ˆ‚ÌŒ¶Ž‹";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}
