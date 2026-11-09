using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_04 : CardInfo
{
    public CardInfo_128_JA_04()
    {
        this.cardNo = "128_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "A PirateÅfs Life";
        this.cardName2 = "äCëØÇÃïÈÇÁÇµ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether6 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
