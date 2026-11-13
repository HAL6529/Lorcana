using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_07 : CardInfo
{
    public CardInfo_004_JA_07()
    {
        this.cardNo = "004_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ボルト";
        this.cardName2 = "スーパードッグ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JohnLorenAndNicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
