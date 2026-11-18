using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_08 : CardInfo
{
    public CardInfo_118_JA_08()
    {
        this.cardNo = "118_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "板渡らせの刑だ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
