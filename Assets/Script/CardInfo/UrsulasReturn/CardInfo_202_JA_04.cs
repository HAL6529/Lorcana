using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_04 : CardInfo
{
    public CardInfo_202_JA_04()
    {
        this.cardNo = "202_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "RLSÉåÉKÉVÅ[çÜÇÃëÂñC";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LuigiAime;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
