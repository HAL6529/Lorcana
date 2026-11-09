using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_04 : CardInfo
{
    public CardInfo_061_JA_04()
    {
        this.cardNo = "061_JA_04";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "Second Star to the Right";
        this.cardName2 = "âEÇ©ÇÁ2î‘ñ⁄ÇÃêØ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NataliaTrykowska;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether10 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
