using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_05 : CardInfo
{
    public CardInfo_130_JA_05()
    {
        this.cardNo = "130_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "グリマー VS グリマー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
