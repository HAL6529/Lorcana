using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_08 : CardInfo
{
    public CardInfo_151_JA_08()
    {
        this.cardNo = "151_JA_08";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ここじゃみんながヘンテコなのさ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
