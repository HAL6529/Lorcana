using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_01 : CardInfo
{
    public CardInfo_005_JA_01()
    {
        this.cardNo = "005_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "オリンポスの王";
        this.power = 6;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = "Alex Accorsi";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
