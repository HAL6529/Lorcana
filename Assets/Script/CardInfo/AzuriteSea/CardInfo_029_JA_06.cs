using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_06 : CardInfo
{
    public CardInfo_029_JA_06()
    {
        this.cardNo = "029_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "レスキュー・レンジャー出動！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
