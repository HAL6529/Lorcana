using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_02 : CardInfo
{
    public CardInfo_199_JA_02()
    {
        this.cardNo = "199_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ïóÇÊêÅÇØ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.R_laBarberaAndL_Giammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}
