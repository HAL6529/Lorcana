using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_08 : CardInfo
{
    public CardInfo_150_JA_08()
    {
        this.cardNo = "150_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "浮かれ頭";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
