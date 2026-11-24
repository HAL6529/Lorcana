using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_12 : CardInfo
{
    public CardInfo_108_JA_12()
    {
        this.cardNo = "108_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "勇気ある探検家";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
