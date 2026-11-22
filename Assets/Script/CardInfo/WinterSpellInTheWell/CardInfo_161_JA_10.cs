using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_10 : CardInfo
{
    public CardInfo_161_JA_10()
    {
        this.cardNo = "161_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヘン・ウェンの幻視";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VictorYanoCovarrubias;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
