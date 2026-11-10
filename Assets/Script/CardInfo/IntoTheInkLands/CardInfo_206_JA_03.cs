using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_03 : CardInfo
{
    public CardInfo_206_JA_03()
    {
        this.cardNo = "206_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "アトランティスの守護者";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdamFenton;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
