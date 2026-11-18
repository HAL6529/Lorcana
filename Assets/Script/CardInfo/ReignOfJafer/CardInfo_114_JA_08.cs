using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_08 : CardInfo
{
    public CardInfo_114_JA_08()
    {
        this.cardNo = "114_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "宝を奪った！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
