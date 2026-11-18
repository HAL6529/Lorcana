using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_08 : CardInfo
{
    public CardInfo_177_JA_08()
    {
        this.cardNo = "177_JA_08";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "DOWN IN NEW ORLEANS";
        this.cardName2 = "それがニューオーリンズ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RubinChung;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}
