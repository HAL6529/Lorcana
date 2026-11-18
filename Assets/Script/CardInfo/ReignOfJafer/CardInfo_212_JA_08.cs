using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_08 : CardInfo
{
    public CardInfo_212_JA_08()
    {
        this.cardNo = "212_JA_08";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ここではみんなが魔法使い";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether9 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Enchanted;
    }
}
