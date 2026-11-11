using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_05 : CardInfo
{
    public CardInfo_187_JA_05()
    {
        this.cardNo = "187_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ピート";
        this.cardName2 = "レスリング・チャンピオン";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
