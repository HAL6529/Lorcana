using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_05 : CardInfo
{
    public CardInfo_196_JA_05()
    {
        this.cardNo = "196_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "‚Â‚Èˆø‚«";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
