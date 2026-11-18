using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_08 : CardInfo
{
    public CardInfo_040_JA_08()
    {
        this.cardNo = "040_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ペニーはあんたの人間よ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
