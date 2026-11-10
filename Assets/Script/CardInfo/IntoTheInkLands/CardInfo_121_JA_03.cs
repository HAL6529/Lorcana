using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_03 : CardInfo
{
    public CardInfo_121_JA_03()
    {
        this.cardNo = "121_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "エリック王子";
        this.cardName2 = "腕利きの舵取り";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
