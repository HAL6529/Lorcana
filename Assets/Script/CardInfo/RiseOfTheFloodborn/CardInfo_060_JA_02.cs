using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_02 : CardInfo
{
    public CardInfo_060_JA_02()
    {
        this.cardNo = "060_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "ホラーみたいなしわしわ女";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CaseyRobin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
