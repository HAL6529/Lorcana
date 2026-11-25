using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_13 : CardInfo
{
    public CardInfo_035_JA_13()
    {
        this.cardNo = "035_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "NOBODY LIKE U";
        this.cardName2 = "ノーバディ・ライク・ユー";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
