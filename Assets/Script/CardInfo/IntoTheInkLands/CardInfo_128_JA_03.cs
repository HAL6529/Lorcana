using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_03 : CardInfo
{
    public CardInfo_128_JA_03()
    {
        this.cardNo = "128_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ã}ç~â∫îöåÇ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
