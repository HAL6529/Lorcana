using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_08 : CardInfo
{
    public CardInfo_147_JA_08()
    {
        this.cardNo = "147_JA_08";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "何でもするよ 友達のため";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether8 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
