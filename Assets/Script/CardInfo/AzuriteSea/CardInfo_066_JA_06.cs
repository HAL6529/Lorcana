using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_06 : CardInfo
{
    public CardInfo_066_JA_06()
    {
        this.cardNo = "066_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マッドハッターのティーポット";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndreaParisi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}
