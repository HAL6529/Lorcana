using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_13 : CardInfo
{
    public CardInfo_168_JA_13()
    {
        this.cardNo = "168_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "用事はどっさり！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}
