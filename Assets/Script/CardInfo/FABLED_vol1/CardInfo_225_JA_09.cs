using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_225_JA_09 : CardInfo
{
    public CardInfo_225_JA_09()
    {
        this.cardNo = "225_JA_09";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "CIRCLE OF LIFE";
        this.cardName2 = "サークル・オブ・ライフ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether8 };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Legendary;
    }
}
