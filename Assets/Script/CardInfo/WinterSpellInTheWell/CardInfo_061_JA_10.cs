using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_10 : CardInfo
{
    public CardInfo_061_JA_10()
    {
        this.cardNo = "061_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "飛び去れ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AgatheMolin;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}
