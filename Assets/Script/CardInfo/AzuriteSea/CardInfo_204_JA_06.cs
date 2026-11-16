using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_06 : CardInfo
{
    public CardInfo_204_JA_06()
    {
        this.cardNo = "204_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ã‚âÕãcâÔÇÃâÔãcèÍ";
        this.cardName2 = "ñ@íÏ";
        this.power = 1;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
