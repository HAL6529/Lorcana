using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_07 : CardInfo
{
    public CardInfo_151_JA_07()
    {
        this.cardNo = "151_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "モーリスの自動マキ割り機";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
