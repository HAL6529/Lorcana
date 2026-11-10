using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_04 : CardInfo
{
    public CardInfo_198_JA_04()
    {
        this.cardNo = "198_JA_04";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "THE MOB SONG";
        this.cardName2 = "ñÈèPÇÃâÃ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether10 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
