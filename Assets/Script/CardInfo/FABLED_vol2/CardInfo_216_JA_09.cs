using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_09 : CardInfo
{
    public CardInfo_216_JA_09()
    {
        this.cardNo = "216_JA_09";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "尊敬される王に";
        this.cardName2 = "ヘラクレスへの贈り物";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Epic;
    }
}
