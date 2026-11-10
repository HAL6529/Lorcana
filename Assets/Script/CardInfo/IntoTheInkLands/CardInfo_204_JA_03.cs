using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_03 : CardInfo
{
    public CardInfo_204_JA_03()
    {
        this.cardNo = "204_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉoÉCÉÜÅ[";
        this.cardName2 = "ì‰ÇﬂÇ¢ÇΩè¿";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RyanMoeck;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
