using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_11 : CardInfo
{
    public CardInfo_172_JA_11()
    {
        this.cardNo = "172_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ランチパッド";
        this.cardName2 = "隠れ家の番人";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
