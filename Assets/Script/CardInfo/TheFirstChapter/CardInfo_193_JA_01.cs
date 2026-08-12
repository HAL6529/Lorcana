using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_01 : CardInfo
{
    public CardInfo_193_JA_01()
    {
        this.cardNo = "193_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "でっかい妖精";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Cookie";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
