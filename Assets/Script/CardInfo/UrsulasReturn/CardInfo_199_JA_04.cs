using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_04 : CardInfo
{
    public CardInfo_199_JA_04()
    {
        this.cardNo = "199_JA_04";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ƒgƒŠƒgƒ“‰¤‚Ì’º—ß";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}
