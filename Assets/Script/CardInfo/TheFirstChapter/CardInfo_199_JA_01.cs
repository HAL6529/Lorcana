using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_01 : CardInfo
{
    public CardInfo_199_JA_01()
    {
        this.cardNo = "199_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ˆø‚Á‚©‚«‰ñ‚µ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Amber Kommavongsa";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
