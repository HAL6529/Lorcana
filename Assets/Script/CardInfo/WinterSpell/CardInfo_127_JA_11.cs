using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_11 : CardInfo
{
    public CardInfo_127_JA_11()
    {
        this.cardNo = "127_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ナニの反撃!";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.SuperRare;
    }
}
