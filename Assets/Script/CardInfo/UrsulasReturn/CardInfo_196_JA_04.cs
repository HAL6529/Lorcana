using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_04 : CardInfo
{
    public CardInfo_196_JA_04()
    {
        this.cardNo = "196_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ダイヤ プラチナ ペシャンコに！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JenniferPark;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
