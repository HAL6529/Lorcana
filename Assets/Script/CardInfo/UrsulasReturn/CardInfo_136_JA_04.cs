using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_04 : CardInfo
{
    public CardInfo_136_JA_04()
    {
        this.cardNo = "136_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "åPó˚èÍ";
        this.cardName2 = "íbòBÇÃíå";
        this.power = 1;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
