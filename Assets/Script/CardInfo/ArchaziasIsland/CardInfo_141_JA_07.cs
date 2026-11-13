using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_07 : CardInfo
{
    public CardInfo_141_JA_07()
    {
        this.cardNo = "141_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "çcåRè´åR";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive};
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
