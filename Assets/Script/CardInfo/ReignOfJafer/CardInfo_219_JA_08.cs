using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_08 : CardInfo
{
    public CardInfo_219_JA_08()
    {
        this.cardNo = "219_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "シャン・ユーの剣";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JonathanLivslystAndReneeChio;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Enchanted;
    }
}
