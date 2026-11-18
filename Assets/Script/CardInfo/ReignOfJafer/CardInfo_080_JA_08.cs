using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_08 : CardInfo
{
    public CardInfo_080_JA_08()
    {
        this.cardNo = "080_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レバーを引いて！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarioManzanares;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
