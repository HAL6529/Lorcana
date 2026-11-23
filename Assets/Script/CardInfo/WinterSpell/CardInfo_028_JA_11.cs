using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_11 : CardInfo
{
    public CardInfo_028_JA_11()
    {
        this.cardNo = "028_JA_11";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "荒れ狂う嵐";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.SuperRare;
    }
}
