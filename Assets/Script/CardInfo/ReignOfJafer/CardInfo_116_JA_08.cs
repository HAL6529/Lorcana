using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_08 : CardInfo
{
    public CardInfo_116_JA_08()
    {
        this.cardNo = "116_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÇªÇÍÇ∂Ç·Ç»ÇüÇüÇüÇ¢ÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
