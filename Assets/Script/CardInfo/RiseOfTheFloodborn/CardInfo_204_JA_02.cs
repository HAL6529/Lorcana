using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_02 : CardInfo
{
    public CardInfo_204_JA_02()
    {
        this.cardNo = "204_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "‹ØƒgƒŒŠí‹ï";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AntoniaFlechsig;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
