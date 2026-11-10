using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_02 : CardInfo
{
    public CardInfo_075_JA_02()
    {
        this.cardNo = "075_JA_02";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "チェシャ猫";
        this.cardName2 = "影からニヤニヤ";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JeffMurchie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
