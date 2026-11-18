using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_08 : CardInfo
{
    public CardInfo_082_JA_08()
    {
        this.cardNo = "082_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "誰だって弱点はある";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LinhDang;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
