using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_08 : CardInfo
{
    public CardInfo_148_JA_08()
    {
        this.cardNo = "148_JA_08";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "失せろ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
