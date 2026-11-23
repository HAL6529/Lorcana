using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_11 : CardInfo
{
    public CardInfo_033_JA_11()
    {
        this.cardNo = "033_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジョン・スミスのコンパス";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
