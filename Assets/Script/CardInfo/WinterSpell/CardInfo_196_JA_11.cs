using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_11 : CardInfo
{
    public CardInfo_196_JA_11()
    {
        this.cardNo = "196_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "昔ながらのこの営み";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaimePuga;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
