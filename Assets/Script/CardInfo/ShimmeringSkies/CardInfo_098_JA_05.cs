using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_05 : CardInfo
{
    public CardInfo_098_JA_05()
    {
        this.cardNo = "098_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プリンス・ジョンの鏡";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
