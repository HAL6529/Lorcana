using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_10 : CardInfo
{
    public CardInfo_026_JA_10()
    {
        this.cardNo = "026_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "手がかりを探せ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RubinChung;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
