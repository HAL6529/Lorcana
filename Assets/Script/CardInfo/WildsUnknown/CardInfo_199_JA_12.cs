using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_12 : CardInfo
{
    public CardInfo_199_JA_12()
    {
        this.cardNo = "199_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "TOUCH THE SKY";
        this.cardName2 = "タッチ・ザ・スカイ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
