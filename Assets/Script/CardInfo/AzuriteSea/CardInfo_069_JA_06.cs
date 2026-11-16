using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_06 : CardInfo
{
    public CardInfo_069_JA_06()
    {
        this.cardNo = "069_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "神秘の木";
        this.cardName2 = "ママ・オーディの家";
        this.power = 1;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
