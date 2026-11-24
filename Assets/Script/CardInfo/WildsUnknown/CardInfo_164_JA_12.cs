using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_12 : CardInfo
{
    public CardInfo_164_JA_12()
    {
        this.cardNo = "164_JA_12";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "総員退去してください";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
