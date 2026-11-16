using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_06 : CardInfo
{
    public CardInfo_067_JA_06()
    {
        this.cardNo = "067_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ピクシー・ダスト";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EllieHorieAndMaraTango;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
