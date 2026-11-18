using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_08 : CardInfo
{
    public CardInfo_176_JA_08()
    {
        this.cardNo = "176_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "狩りの練習";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MoniekSchilder;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
