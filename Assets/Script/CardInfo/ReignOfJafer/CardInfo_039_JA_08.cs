using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_08 : CardInfo
{
    public CardInfo_039_JA_08()
    {
        this.cardNo = "039_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "キャンディ・ドリフト";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
