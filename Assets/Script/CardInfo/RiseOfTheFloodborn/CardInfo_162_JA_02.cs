using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_02 : CardInfo
{
    public CardInfo_162_JA_02()
    {
        this.cardNo = "162_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "‚¤‚³‚¬‚Ì‚ ‚È‚ð‚Ü‚Á‚³‚©‚³‚Ü";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
