using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_215_JA_03 : CardInfo
{
    public CardInfo_215_JA_03()
    {
        this.cardNo = "215_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "海賊たちの天敵";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
