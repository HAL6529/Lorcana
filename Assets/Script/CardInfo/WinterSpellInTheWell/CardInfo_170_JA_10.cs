using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_10 : CardInfo
{
    public CardInfo_170_JA_10()
    {
        this.cardNo = "170_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ホーンド・キングの城";
        this.cardName2 = "悪の要塞";
        this.power = 1;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AyssaLee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
